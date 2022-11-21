using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Knowledge
{
    public class Task1
    {
        public static List<object> GetIntegersFromList(List<object> inputList)
        {
            List<object> outputList = new List<object>();
            foreach (var v in inputList)
            {
                if (v is int)
                {
                    outputList.Add(v);
                }
            }
            return outputList;
        }
    }
}
