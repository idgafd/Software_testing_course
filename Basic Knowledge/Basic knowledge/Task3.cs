namespace BasicKnowledge
{
    public class Task3
    {
        public static int DigitalRoot(int inputInt)
        {
            if (inputInt < 10)
            {
                return inputInt;
            }

            int sum = 0;
            while (inputInt >= 10)
            {
                sum += inputInt % 10;
                inputInt = inputInt / 10;
            }
            sum += inputInt;

            return DigitalRoot(sum);
        }
    }
}
