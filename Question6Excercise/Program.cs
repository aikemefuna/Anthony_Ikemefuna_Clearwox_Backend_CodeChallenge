using System;

namespace Question6Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = QuestionClass.NamesList;
            //iterate and print names
            var response = string.Join(Environment.NewLine, names);
            var responses = QuestionClass.TESTModule(-1);
            Console.WriteLine(response); ;
        }
        public static int[] rotateArray(int[] array, int d)
        {

            int n = array.Length;

            int[] rotatedVal = new int[n];

            Array.Copy(array, d, rotatedVal, 0, n - d);
            Array.Copy(array, 0, rotatedVal, n - d, d);

            return rotatedVal;
        }
    }
}
