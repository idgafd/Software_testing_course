namespace BasicKnowledge
{
    public class Task4
    {
        public static int FindTargetSum(int[] numbers, int target)
        {
            int outputCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    if (sum == target)
                    {
                        outputCount++;
                    }
                }
            }

            return outputCount;
        }
    }
}
