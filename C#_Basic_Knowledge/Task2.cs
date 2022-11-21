using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Knowledge
{
    public class Task2
    {
        public static string FirstNonRepeatingLetter(string inputString)
        {
            string loweredInputString = inputString.ToLower();
            for (int i = 0; i < loweredInputString.Length; i++)
            {
                int count = loweredInputString.Length - loweredInputString.Replace(loweredInputString[i].ToString(), "").Length;
                if (count == 1)
                {
                    return inputString[i].ToString();
                }
            }

            return "";
        }
    }
}
