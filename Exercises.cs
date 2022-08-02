using System;

namespace Testing
{
    public class Exercises
    {
        public static bool CompareArray(int[] arg1, int[] arg2)
        {
            bool isArrayEqual = true;

            if (arg1.Length == arg2.Length)
            {
                for (int i = 0; i < arg2.Length; i++)
                {
                    if(arg1[i] != arg2[i])
                    {
                        isArrayEqual = false;
                    }
                }
            }
            return isArrayEqual;
        }

        public static int GetArrayLength()
        {
            Console.Write($"Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            return arrayLength;
        }

        public static void StoreArrayElementInInput(int[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write($"Enter value for element [{i}]: ");
                args[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
