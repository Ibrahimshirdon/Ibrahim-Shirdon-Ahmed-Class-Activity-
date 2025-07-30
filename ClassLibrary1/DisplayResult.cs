using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLibrary1

{
    public class DisplayResult
    {
        public static void DisplayReport(string name, int id, int incorrect, int correct, int score, int maxScore)
        {
            Console.WriteLine($"\nReport for {name} (ID: {id})");
            Console.WriteLine($"Correct Answers: {correct}");
            Console.WriteLine($"Incorrect Answers: {incorrect}");
            Console.WriteLine($"Total Score: {score}/{maxScore}\n");
        }

    }
}
