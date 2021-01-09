
#nullable enable

using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Quantum.Samples.SudokuGrover
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleToRun = args.Length > 0 ? args[0] : "all";

            //var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            int[,] answer4 = {
                { 1,2,3,4 },
                { 3,4,1,2 },
                { 2,3,4,1 },
                { 4,1,2,3 } };

            SudokuClassic sudokuClassic = new SudokuClassic();

            if (puzzleToRun == "4x4-classic" || puzzleToRun == "all")
            {
                // Test solving a 4x4 Sudoku puzzle using classical computing.
                // Missing numbers are denoted by 0.
                int[,] puzzle4 = {
                    { 0,2,0,4 },
                    { 3,0,0,2 },
                    { 0,0,4,1 },
                    { 4,0,2,0 } };
                Console.WriteLine("Solving 4x4 using classical computing.");
                ShowGrid(puzzle4);
                bool resultFound = sudokuClassic.SolveSudokuClassic(puzzle4);
                VerifyAndShowResult(resultFound, puzzle4, answer4);
            }
        }

        /// <summary>
        /// If result was found, verify it is correct (matches the answer) and show it
        /// </summary>
        /// <param name="resultFound">True if a result was found for the puzzle</param>
        /// <param name="puzzle">The puzzle to verify</param>
        /// <param name="answer">The correct puzzle result</param>
        static void VerifyAndShowResult(bool resultFound, int[,] puzzle, int[,] answer)
        {
            if (!resultFound)
                Console.WriteLine("No solution found.");
            else
            {
                bool good = puzzle.Cast<int>().SequenceEqual(answer.Cast<int>());
                if (good)
                    Console.WriteLine("Result verified correct.");
                ShowGrid(puzzle);
            }
            Pause();
        }

        /// <summary>
        /// Display the puzzle
        /// </summary>
        static void ShowGrid(int[,] puzzle)
        {
            int size = puzzle.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new String('-', 4 * size + 1));
                for (int j = 0; j < size; j++)
                {
                    if (puzzle[i, j] == 0)
                        Console.Write("|   ");
                    else
                        Console.Write($"| {puzzle[i, j],1} ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine(new String('-', 4 * size + 1));
        }

        /// <summary>
        /// Pause execution with a message and wait for a key to be pressed to continue.
        /// </summary>
        static void Pause()
        {
            System.Console.WriteLine("\n\nPress any key to continue...\n\n");
            System.Console.ReadKey();
        }

    }
}
