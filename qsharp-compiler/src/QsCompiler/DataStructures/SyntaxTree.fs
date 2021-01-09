// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Quantum.QsCompiler.SyntaxTree

open System
open System.Collections.Immutable
open System.Linq
open Microsoft.Quantum.QsCompiler.DataTypes
open Microsoft.Quantum.QsCompiler.SyntaxTokens


// IMPORTANT: if the data structures in this file are changed to classes,
// there are a bunch of places in the code that will break because they rely on structural equality!


type QsBindingKind =
    /// indicates a binding to one or more immutable variables - i.e. the value of the variable cannot be modified or re-bound
    | ImmutableBinding
    /// indicates a binding to one or more mutable variables - i.e. the value of the variables can be modified later on
    /// -> note that mutable bindings in Q# do *not* behave in exactly the way a reference binding would
    | MutableBinding


type QsSpecializationKind =
    /// indicates the specialization of a declared callable that is executed when the callable is called without any applied functors
    | QsBody
    /// indicates the specialization of a declared operation that is executed when the callable is called after applying an odd number of Adjoint functors
    | QsAdjoint
    /// indicates the specialization of a declared operation that is executed when the callable is called after applying one or more Controlled functors
    | QsControlled
    /// indicates the specialization of a declared operation that is executed when the callable is called after applying an odd number of Adjoint functors and one ore more Controlled functors
    | QsControlledAdjoint


type QsCallableKind =
    /// Indicates a Q# callable whose effect(s) may be non-deterministic -
    /// in particular, any modifications of the quantum state or any probabilistic side effects are only possible within operations.
    | Operation
    /// Indicates a Q# callable whose effect(s) are fully deterministic -
    /// in particular, the callable is guaranteed to have the same effects whenever called with the same arguments.
    /// -> Any modifications of the quantum state or any probabilistic side effects are only possible within operations.
    | Function
    /// Indicates the type constructor for a user defined Q# type.
    | TypeConstructor


/// Note: Q# binding scopes are specific to qubit management and hence only valid within Q# operations.
type QsQubitScopeKind =
    /// Indicates a Q# allocation scope -
    /// i.e. a using directive indicating which (clean) qubits are to be allocated,
    /// followed by a statement block during which the initialized qubits are available,
    /// before being released again (in a clean state) at the end of the scope.
    | Allocate
    /// Indicates a Q# scope during which external qubits are to be borrowed -
    /// i.e. a borrow directive indicating which (dirty) qubits are to be borrowed,
    /// followed by a statement block during which the borrowed qubits are available.
    /// At the end of the scope the bound variables go out of scope and the qubits are "returned".
    /// The returned qubits are expected to be in the same state they were in when borrowed.
    | Borrow


/// used to represent a qualified name within Q# - i.e. a namespace name followed by a symbol name
type QsQualifiedName =
    {
        /// the name of the namespace in which a namespace element is declared
        Namespace: string
        /// the declared name of the namespace element
        Name: string
    }
    override this.ToString() = sprintf "%s.%s" this.Namespace this.Name


type SymbolTuple =
    /// indicates in invalid variable name
    | InvalidItem
    /// indicates a valid Q# variable name
    | VariableName of string
    /// indicates a tuple of Q# variable names or (nested) tuples of variable names
    | VariableNameTuple of ImmutableArray<SymbolTuple>
    /// indicates a place holder for a Q# variable that won't be used after the symbol tuple is bound to a value
    | DiscardedItem
    interface ITuple


/// use to represent all forms of Q# bindings
type QsBinding<'T> =
    {
        /// the kind of the binding (binding to mutable or immutable variables)
        Kind: QsBindingKind
        /// the variables to which the right hand side (Rhs) of the binding is bound given as symbol tuple
        Lhs: SymbolTuple
        /// the value which is bound to the variables on the left hand side (Lhs) of the binding
        Rhs: 'T
    }


type Identifier =
    /// an identifier referring to a locally declared variable visible on the current scope
    | LocalVariable of string
    /// in identifier referring to a globally declared callable -> note that type names are *not* represented as identifiers
    | GlobalCallable of QsQualifiedName
    /// an identifier of unknown origin - i.e. the identifier could not be associated with any globally declared callable or local variable
    | InvalidIdentifier


/// used to represent position information for declared variables
/// relative to the position of a chosen root-node (e.g. the specialization declaration)
type QsLocation =
    {
        /// position offset (line and character) for Range relative to the chosen root node
        Offset: Position
        /// range relative to Offset
        Range: Range
    }


/// used to represent the use of a type parameter within a fully resolved Q# type
type QsTypeParameter =
    // TODO: origin needs adapting if we ever allow to declare type parameters on specializations
    {
        /// the qualified name of the callable the type parameter belongs to
        Origin: QsQualifiedName
        /// the name of the type parameter
        TypeName: string
        /// the range at which the type parameter occurs relative to the statement (or partial statement) root
        /// -> is Null for auto-generated type information, i.e. in particular for inferred type information
        Range: QsNullable<Range>
    }


type ResolvedCharacteristics =
    private
        {
            // the private constructor enforces the guarantees given for any instance of ResolvedCharacteristics
            // -> teh static member New replaces the record constructor
            _Characteristics:
        }

type QsNamespaceElement =
    /// denotes a Q# callable is either a function or operation (type constructors are auto-generated)
    | QsCallable of QsCallable
    /// denotes a Q# user defined type
    | QsCustomType of QsCustomType
    member this.GetFullName() =
        match this with
        | QsCallable call -> call.FullName
        | QsCustomType typ -> typ.FullName

type QsNamespace =
    {
        /// the name of the namespace -
        /// represented as non-nullable string, since Q# does not support nested namespaces
        Name: string
        /// all elements contained in the namespace - i.e. functions, operation, and user defined types
        /// Note: specifizations for declared callables must be contained in the same namespace as the callable declaration,
        /// and are represented as part of the callable they belong to.
        Elements: ImmutableArray<
    }

