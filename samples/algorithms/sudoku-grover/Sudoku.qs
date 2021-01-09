

namespace Microsoft.Quantum.Sample.SudokuGrover {
	open Microsoft.Quantum.Arrays;

	open Microsoft.Quantum.Sample.ColoringGroverWithConstraints;

	operation SolvePuzzle(numVertices : Int, size : Int, emptyQuareEdges : (Int, Int)[],
	startingNumberConstraints : (Int, Int)[]) : (Bool, Int[]) {
		let bitsPerColor = size == 9 ? 4 | 2;
		mutable oracle = ApplyColorEqualityOracle(numVertices, bitsPerColor, emptyQuareEdges, startingNumberConstraints, _, _)
	}
}