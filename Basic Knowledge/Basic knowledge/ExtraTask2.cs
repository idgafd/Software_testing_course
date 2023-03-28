using System;

namespace BasicKnowledge
{
    public class ExtraTask2
    {
        public static string numberToIPAdress(uint num)
        {
            int tracker = 0;
            uint[] binArray = new uint[32];
            while (tracker < 32)
            {
                binArray[tracker] = (num % 2);
                num /= 2;
                tracker++;
            }
            tracker = 0;
            string output = "";
            while (tracker < 4)
            {
                uint dec = 0;
                int pow = 0;
                for (int j = tracker * 8; j < tracker * 8 + 8; j++)
                {
                    dec += binArray[j] * (uint)Math.Pow(2, pow);
                    pow++;
                }
                output = output.Insert(0, dec.ToString());
                if (tracker != 3)
                {
                    output = output.Insert(0, ".");
                }
                tracker++;
            }
            return output;
        }
    }
}
