// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Quantum.QsCompiler.Diagnostics

open System
open System.Collections.Generic

type ErrorCode =
    | ExcessBracketError = 1001
    | MissingBracketError = 1002
    | MissingStringDelimiterError = 1003

    | MisplacedOpeningBracket = 2001
