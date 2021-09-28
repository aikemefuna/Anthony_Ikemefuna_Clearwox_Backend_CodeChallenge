using System;
using System.Collections.Generic;

namespace Question6Excercise
{
    public static class QuestionClass
    {
        public static List<string> NamesList = new List<string>()
        {
        "Jimmy",
        "Jeffrey",
        "John",
        };

        public static object TESTModule(object value)
        {
            var result = new object();
            switch (value)
            {
                case int n when ((int.TryParse(value.ToString(), out n)) && (n >= 1 && n <= 4)):
                    result = n * 2;
                    break;

                case int n when ((int.TryParse(value.ToString(), out n)) && (n > 4)):
                    result = n * 3;
                    break;

                case int n when ((int.TryParse(value.ToString(), out n)) && (n < 1)):
                    throw new Exception();


                case float n when ((float.TryParse(value.ToString(), out n)) && (n >= 1.0f && n <= 2.0f)):
                    result = 3.0f;
                    break;

                case string n when (value is string):
                    result = value.ToString().ToUpper();
                    break;

                case string n when (value != null):
                    result = value;
                    break;

            }
            return result;
        }
    }
}
