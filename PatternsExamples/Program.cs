using PatternsExamples.Patterns.Behavioral;
using PatternsExamples.Patterns.Creational;
using PatternsExamples.Patterns.Structural;
using System;

namespace PatternsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            CreationalPatternsRunner.Run();
            StructuralPatternsRunner.Run();
            BehavioralPatternsRunner.Run();

            Console.ReadKey();
        }
    }
}
