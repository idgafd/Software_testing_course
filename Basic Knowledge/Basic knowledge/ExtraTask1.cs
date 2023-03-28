using System;

namespace BasicKnowledge
{
    public class ExtraTask1
    {

        public static int ReturnBiggerNumber(int number)
        {
            int[] arrNumber = new int[number.ToString().Length];
            int tracker = 0;
            while (number > 0)
            {
                arrNumber[tracker] = number % 10;
                number /= 10;
                tracker++;
            }
 
            tracker = 0;
            bool checkIfItsReal = true;
            while (tracker < arrNumber.Length - 1)
            {
                if (arrNumber[tracker] > arrNumber[tracker + 1])
                {
                    checkIfItsReal = false;
                    int temp = arrNumber[tracker];
                    arrNumber[tracker] = arrNumber[tracker + 1];
                    arrNumber[tracker + 1] = temp;
                    while (tracker > 0)
                    {
                        if (arrNumber[tracker] > arrNumber[tracker - 1])
                        {
                            temp = arrNumber[tracker];
                            arrNumber[tracker] = arrNumber[tracker - 1];
                            arrNumber[tracker - 1] = temp;
                        }
                        tracker--;
                    }
                    break;
                }
                else tracker++;
            }
            if (checkIfItsReal)
            {
                return -1;
            }
            number = 0;
            for (int i = 0; i < arrNumber.Length; i++)
            {
                number = number + arrNumber[i] * (int)(Math.Pow(10, i));
            }
            return number;
        }
    }
}
