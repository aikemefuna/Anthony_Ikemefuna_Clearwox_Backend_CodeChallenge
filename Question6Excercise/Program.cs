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
    }
}
