
namespace Microsoft.Quantum.Samples.DatabaseSearch {
	open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Arrays;

	//////////////////////////////////////////////////////////////////////////
    // Introduction //////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////

    // This sample will walk through several examples of searching a database
    // of N elements for a particular marked item using just O(1/√N) queries
    // to the database. In particular, we will follow Grover's algorithm, as
    // described in the standard library guide.

    // We will model the database by an oracle D that acts to map indices
    // to a flag indicating whether a given index is marked. In particular,
    // let |z〉 be a single-qubit computational basis state (that is, either
    // |0〉 or |1〉, and let |k〉 be a state representing an index k ∈ {0, 1,
    // …, N }. Then

    //     D |z〉 |k〉 = |z ⊕ xₖ〉 |k〉,

    // where x = x₀ x₁ … x_{N - 1} is a binary string such that xₖ is 1
    // if and only if the kth item is marked, and where ⊕ is the classical
    // exclusive OR gate. Note that given this definition, we know how D
    // transforms arbitrary states by linearity -- given an input state
    // that is a linear combination of orthogonal states |z〉|k〉 summed over the
    // z and k indices, D acts on each state independently.

    // First, we work out an example of how to construct and apply D without
    // using the canon. We then implement all the steps of Grover search
    // manually using this database oracle. Second, we show the amplitude
    // amplification libraries provided with the canon can make this task
    // significantly easier.

    //////////////////////////////////////////////////////////////////////////
    // Database Search with Manual Oracle Definitions ////////////////////////
    //////////////////////////////////////////////////////////////////////////

    /// # Summary
    /// Given a qubit to use to store a mark bit and a register corresponding
    /// to a database, marks the first qubit conditioned on the register
    /// state being the all-ones state |11…1〉.
    ///
    /// # Input
    /// ## markedQubit
    /// A qubit to be targeted by an `X` operation controlled on whether
    /// the state of `databaseRegister` corresponds to a market item.
    /// ## databaseRegister
    /// A register representing the target of a query to the database.
    ///
    /// # Remarks
    /// Implements the operation
    ///
    ///     |z〉 |k〉 ↦ |z ⊕ f(k)〉 |k〉,
    ///
    /// where f(k) = 1 if and only if k = 2^(Length(databaseRegister)) - 1 and
    /// 0 otherwise.
    operation ApplyDatabaseOracle(markedQubit : Qubit, databaseRegister : Qubit[]) : Unit is Adj + Ctl {
        // The Controlled functor applies its operation conditioned on the
        // first input being in the |11…1〉 state, which is precisely
        // what we need for this example.
        Controlled X(databaseRegister, markedQubit);
    }


    // Grover's algorithm for quantum database searching requires that we
    // prepare the state given by the uniform superposition over all
    // computational basis states,

    //     |u〉 = Σₖ |k〉 = H^{⊗ n} |00…0〉,

    // where we have labeled n-qubit states by the integers formed by
    // interpreting their computational basis labels as big-endian
    // representations. For example, |2〉 in this notation is |10〉 in the
    // computational basis of two qubits.

    // Resolving this convention, then,

    //     |u〉 = |++…+〉.

    // This state is easy to implement given the input state |00..0), and we
    // call the oracle that does so U.

    /// # Summary
    /// Given a register of qubits initially in the state |00…0〉, prepares
    /// a uniform superposition over all computational basis states.
    ///
    /// # Input
    /// ## databaseRegister
    /// A register of n qubits initially in the |00…0〉 state.
    operation ApplyUniformSuperpositionOracle(databaseRegister : Qubit[]) : Unit is Adj + Ctl {
        ApplyToEachCA(H, databaseRegister);
    }

    operation ApplyStatePreparationOracle (markedQubit : Qubit, databaseRegister : Qubit[]) : Unit is Adj + Ctl {
        ApplyUniformSuperpositionOracle(databaseRegister);
        ApplyDatabaseOracle(markedQubit, databaseRegister);
    }

    operation ReflectAboutMarkedState(markedQubit : Qubit) : Unit {
        // Marked elements always have the marked qubit in the state |1〉.
        R1(PI(), markedQubit);
    }
}