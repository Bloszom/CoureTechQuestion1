using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using CoureTechQuestion1;

namespace CoureTechQuestion1
{
    public class Program
    { 
        static void Main(string[] args)
        {           

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 15, 25, 35 };
            int[] array3 = { 8, 8 };

            int totalScore1 = TotalScore.CalculateScore(array1); 
            Console.WriteLine("Total Score1: " + totalScore1); 

            int totalScore2 = TotalScore.CalculateScore(array2); 
            Console.WriteLine("Total Score2: " + totalScore2); 

            int totalScore3 = TotalScore.CalculateScore(array3);
            Console.WriteLine("Total Score3: " + totalScore3); 

        }
      
    }
}
