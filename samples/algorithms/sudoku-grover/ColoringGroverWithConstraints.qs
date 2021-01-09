

namespace Microsoft.Quantum.Sample.ColoringGroverWithConstraints {
	open Microsoft.Quantum.Arithmetic;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Canon;

    open Microsoft.Quantum.Intrinsic;

	/// # Summary
    /// Read color from a register.
    ///
    /// # Input
    /// ## register
    /// The register of qubits to be measured.
    operation MeasureColor (register : Qubit[]) : Int {
        return MeasureInteger(LittleEndian(register));
    }

    /// # Summary
    /// Read coloring from a register.
    ///
    /// # Input
    /// ## bitsPerColor
    /// Number of bits per color.
    /// ## register
    /// The register of qubits to be measured.
    operation MeasureColoring (bitsPerColor : Int, register : Qubit[]) : Int[] {
        let numVertices = Length(register) / bitsPerColor;
        let colorPartitions = Partitioned(ConstantArray(numVertices - 1, bitsPerColor), register);
        return ForEach(MeasureColor, colorPartitions);
    } 

    /// # Summary
    /// N-bit color equality oracle (no extra qubits.)
    ///
    /// # Input
    /// ## color0
    /// First color.
    /// ## color1
    /// Second color.
    ///
    /// # Output
    /// Target will be 1 if colors are the same.
    operation ApplyColorEqualityOracle (color0 : Qubit[], color1 : Qubit[], 
        target : Qubit) : Unit is Adj+Ctl {
        within {
            for ((q0, q1) in Zip(color0, color1)) {
                // compute XOR of q0 and q1 in place (storing it in q1).
                CNOT(q0, q1);
            }
        } apply {
            // if all XORs are 0, the bit strings are equal.
            ControlledOnInt(0, X)(color1, target);
        }
    }

    operation ApplyVertexColoringOracle (numVertices : Int, bitsPerColor : Int, edges : (Int, Int)[],
	startingColorConstraints : (Int, Int)[],
    colorRegister : Qubit[],
    target : Qubit) : Unit is Adj + Ctl{
        let nEdges = Length(edges);
        let nStartingColorConstraints = Length(startingColorConstraints);
        // We are looking for a solution that:
        // (a) has no edge with same color at both ends and
        // (b) has no Vertex with a color that violates the starting Color constraints.
        using ((edgeConflicQubits, startingColorConflicQubits) = (Qubit[nEdges], Qubit[nStartingColorConstraints])) {
            within {

            }
        }
    }

    /// # Summary
    /// Grovee
    operation ApplyPhaseOracle (oracle : ((Qubit[], Qubit) => Unit is Adj),
    register : Qubit[]) : Unit is Adj {

        using (target = Qubit()) {
            within {
                // Put the target into the |-> state.
                X(target);
                H(target);
            } apply {
                // Apply the marking oracle; since the target is in the |-> state,
                // flipping the target if the register saticfies the oracle condition
                // will apply a -1 factor to the state.

                oracle(register, target);
            }
        }
    }

    operation ApplyGroversAlgorithmLoop (register : Qubit[],
	oracle : ((Qubit[], Qubit) => Unit is Adj), iterations : Int) : Unit {
        let applyPhaseOracle = 
    }
}