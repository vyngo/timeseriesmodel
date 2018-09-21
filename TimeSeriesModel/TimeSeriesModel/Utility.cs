using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSeriesModel
{
    class Utility
    {
        static public int FindMaxFromList(int[] list)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }

        static public int[] SortAscendList(int[] list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = i; j < list.Count(); j++)
                {
                    if (list[j] < list[i])
                    {
                        int temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }
            return list;
        }

        static public int[] SortDescendList(int[] list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = i; j < list.Count(); j++)
                {
                    if (list[j] > list[i])
                    {
                        int temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }
            return list;
        }
    }
}
