using System.Collections.Generic;

namespace BasicKnowledge
{
    public class Task1
    {
        public static List<object> GetIntegersFromList(List<object> inputList)
        {
            List<object> outputList = new List<object>();
            foreach(var element in inputList)
            {
                if(element is int)
                {
                    outputList.Add(element);
                }
            }
            return outputList;
        }
    }
}
