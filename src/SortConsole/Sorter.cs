using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortConsole
{
   

    public class Sorter {
       
        public static int[] sort(int[] x) {
            int l = x.Length;

            for (int i = 0; i < l - 1; i++) {
                for (int j = 0; j < l - i - 1; j++) {
                    if (x[j] > x[j + 1]) {
                        int temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;
                    }
                }
            }


            return x;
        }

    }
}
