// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Quantum.QsCompiler.SyntaxTokens

open System.Collections.Immutable
open System.Numerics
open Microsoft.Quantum.QsCompiler.Diagnostics
open Microsoft.Quantum.QsCompiler.DataTypes

// marker interface used for types on which tuple matching can be done
type ITuple =
    interface
    end


// Q# literals

type QsFunctor =
    | Adjoint
    | Controlled

type QsResult =
    | Zero
    | One

type QsPauli =
    | PauliX
    | PauliY
    | PauliZ
    | PauliI


// Q# symbols

type QsSymbolKind<'Symbol> =
    /// Let's make the distinction for things that *have* to be an unqualified symbol.
    | Symbol of string
    | QualifiedSymbol of string * string
    /// For bindings.
    | SymbolTuple of ImmutableArray<'Symbol>
    /// Used for the arguments of the original method omitted upon functor gen declaration.
    | OmittedSymbols
    /// Used to allow destructs of the form let (_,a) = ...
    | MissingSymbol
    | InvalidSymbol

// not an ITuple because currently, empty symbol tuples are used if no arguments are given to functor generators
type QsSymbol = { Symbol: QsSymbolKind<QsSymbol>; Range: QsNullable<Range> }
