// <copyright file="NumberInputReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SortConsole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Reads Numbers from the Input.
    /// </summary>
    public static class NumberInputReader
    {
        /// <summary>
        /// Converts the numbers from the <paramref name="input"/> into an
        /// integer array.
        /// </summary>
        /// <param name="input">Coded numbers.</param>
        /// <returns>Number values as integer array.</returns>
        public static int[] ReadNumberFromInput(string input)
        {
            //string[] result = new string[input.Length];
            int[] invalid = new int[0];
            //int i = 0;
            //int j = 0;
            //while (i < input.Length)
            //{
            //    if ((char)input[i] == 44 || (char)input[i] == 32)
            //    {
            //        j++;
            //    }
            //    else if ((char)input[i] > 57 || (char)input[i] < 45)
            //    {
            //        return invalid;
            //    }
            //    else
            //    {
            //        result[j] = result[j] + input[i];
            //    }

            //    i++;
            //}

            //int nullnumb=0;
            //for (int f = 0; f < result.Length; f++)
            //{
            //    if (result[f] == null)
            //    {
            //        nullnumb++;
            //    }
            //}




            //int[]transform = new int[result.Length-nullnumb];
            //for (int k = 0; k < result.Length; k++)
            //{
            //    if (result[k] != null)
            //    {
            //        int q;
            //        bool success = int.TryParse(result[k], out q);
            //        transform[k] = q;
            //    }

            //}
            for (int i = 0; i < input.Length; i++) 
            {
                if (((char)input[i] > 57 || (char)input[i] < 45 || input[i] == 46) && (char)input[i] != 44 && (char)input[i] != 32)
                {
                    return invalid;
                }
                if (!input.Contains((char)44))
                {
                    return invalid;
                }
            }
            string[] numbers = input.Split(',');

            int[] transform = new int[numbers.Length];
            for (int k = 0; k < numbers.Length; k++)
            {

                if (numbers[k] != null)
                {
                    int q;
                    bool success = int.TryParse(numbers[k].Trim(), out q);
                    transform[k] = q;
                }

            }

            return transform;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>

    }
}
