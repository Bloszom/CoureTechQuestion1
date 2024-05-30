namespace CoureTechQuestion1
{
    public class TotalScore
    {
        public static int CalculateScore(int[] numbers)
        {
            int score = 0;
            foreach (int num in numbers)
            {
                if (num == 8)
                {
                    score += 5;
                }
                if (num % 2 == 0)
                {
                    score += 1;
                }
                else
                {
                    score += 3;
                }
            }
            return score;

        }
    }
      
}
