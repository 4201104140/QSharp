
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Linq;
using static System.Math;

namespace Microsoft.Quantum.Samples.DatabaseSearch
{
    class Program
    {
        public static void Pause()
        {
            Console.WriteLine("\n\nPress any key to continue...\n\n");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Setup

            // We begin by defining a quantum simulator to be our target
            // machine.
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            #endregion

            #region Random Database Search with Manual Oracle Definitions

            // Let us investigate the success probability of classical random search.
            // This corresponds to the case where we only prepare the start state, and
            // do not perform any Grover iterates to amplify the marked subspace.
            var nIterations = 0;

            // We now define the size `N` = 2^n of the database to searched in terms of 
            // number of qubits `n`. 
            var nDatabaseQubits = 3;
            var databaseSize = Pow(2.0, nDatabaseQubits);

            // We now execute the classical random search and verify that the success 
            // probability matches the classical result of 1/N. Let us repeat 100
            // times to collect enough statistics.
            var classicalSuccessProbability = 1.0 / databaseSize;
            var repeats = 1000;
            var successCount = 0;

            Console.Write(
                $"Classical random search for marked element in database.\n" +
                $"  Database size: {databaseSize}.\n" +
                $"  Success probability:  {classicalSuccessProbability}\n\n");


            
            foreach (var idxAttempt in Enumerable.Range(0, repeats))
            {
                // Each operation has a static method called Run which takes a simulator as
                // an argument, along with all the arguments defined by the operation itself.
                var task = ApplyQuantumSearch
            }
            #endregion
        }
    }
}
