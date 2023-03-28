namespace BasicKnowledge
{
    public class Task2
    {
        public static string FirstNonRepeatingLetter(string input)
        {
            string lowercaseInput = input.ToLower();
            for (int i = 0; i < lowercaseInput.Length; i++)
            {
                int count = lowercaseInput.Length - lowercaseInput.Replace(lowercaseInput[i].ToString(), "").Length;
                if (count == 1)
                {
                    return input[i].ToString();
                }
            }

            return "";
        }
    }
}
