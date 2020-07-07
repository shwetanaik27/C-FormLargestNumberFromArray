using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 57,9,75,7,79,53,5,63 };
            string result = Program.GetLargestNumber(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string GetLargestNumber(int[] arrNumbers)
        {
            string[] strArr = arrNumbers.Select(x => x.ToString()).ToArray();

            Array.Sort(strArr);
            Array.Reverse(strArr);

            char[] charArrayOuter, charArrayInner;

            for (int i = 0; i < strArr.Length; i++)
            {
                charArrayOuter = strArr[i].ToCharArray();
                for (int j = 0; j < strArr.Length; j++)
                {
                    charArrayInner = strArr[j].ToCharArray();

                    //Only check the numbers starting with same digit
                    if (charArrayOuter[0] == charArrayInner[0])
                    {
                        if (int.Parse(strArr[i] + strArr[j]) > int.Parse(strArr[j] + strArr[i]))
                        {                            
                            string temp = string.Empty;
                            temp = strArr[i];
                            strArr[i] = strArr[j];
                            strArr[j] = temp;
                        }
                    }
                }
            }

            string output = string.Concat(strArr);
            return output;
        }
    }
}
