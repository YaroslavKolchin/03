using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForYaroslav
{
    class Program
    {
        public static void ShowIntArray(int[] array)   
        {
            foreach (int i in array)
            {
                Console.Write(i+" ");
            }
        }

        public static int ShowMaxInt(int[] array)
        {
            return array.Max();
        }

        public static int ShowMaxEven(int[] array)
        {
            Array.Sort(array);
            int a = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && a<array[i])
                {
                    a = array[i];
                }
            }
            return a;
        }

        public static void DelByIndex(ref int[] data, int delIndex)
        {
            int[] newData = new int[data.Length - 1];
            for (int i = 0; i < delIndex; i++)
            {
                newData[i] = data[i];
            }
            for (int i = delIndex; i < newData.Length; i++)
            {
                newData[i] = data[i + 1];
            }
            data = newData;
        }

        public static void DelByValue(ref int[] data, int delValue)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == delValue)
                {
                    DelByIndex(ref data, i);
                    i--;
                }
            }
        }

        public static void NullEvenRows(ref int[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i,i]%2==0)     
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        data[i, j] = 0;
                    }
                }
            }
        }

        public static int ReadUntilPoint()
        {
            bool pointBool = true;
            string s = "";
            char a;
            int SpaceNum = 0;
            while (pointBool)
            {
                a = Console.ReadKey().KeyChar;
                s += a;
                if (a == '.')
                {
                    pointBool = false;
                }
            }

            foreach (var i in s)
            {
                if (i == ' ')
                {
                    SpaceNum++;
                }
            }

            return SpaceNum;
        }

        static void Main(string[] args)
        {
            //int[] array = new int[] { 1, 8, 3, 6, 5, 0, 2, 6, 4, 9 };
            // ShowMaxInt(array);
            int a = ReadUntilPoint();
            Console.WriteLine();
            Console.WriteLine(a+" пробелов");
            Console.ReadKey();


        }
    }
}
