using System;

namespace BlanceNumberbracket
{
    class Program
    {
        public static bool Part(String s)
        {
            int count = 0;
            int missing = 0;
            char[] arr = s.ToCharArray();
            int temp = 0;
            Array.Sort(arr);
            if (arr.Length % 2 == 0)
            {
                for (int i = 0; i < arr.Length; i += 2)
                {
                    temp = i + 1;
                    if (temp <= arr.Length)
                    {
                        if (arr[i] == arr[temp])
                        {
                            count++;

                        }
                        else
                        {
                            return false;
                            break;
                        }
                    }

                }
            }
            else
            {
                return false;
            }
            return true;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(Part("595889723326657"));
        }
    }
}