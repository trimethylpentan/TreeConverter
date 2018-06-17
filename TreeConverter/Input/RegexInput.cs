using System;
using System.Text.RegularExpressions;
namespace TreeConverter
{
    public class RegexInput : InputInterface
    {
        readonly string message;

        readonly Regex regex; 

        string errorMessage;

        public RegexInput(string message, Regex regex)
        {
            this.message = message;
            this.regex = regex;
        }

        public string GetErrorMessage()
        {
            return errorMessage;
        }

        public string GetInput()
        {
            Console.WriteLine(message);

            return Console.ReadLine();
        }

        public bool IsValid(string input)
        {
            if (regex.IsMatch(input))
            {
                return true;
            }

            errorMessage = 
                "Die Eingabe entspricht nicht dem vorgegbenen Format!";
            return false;
        }
    }
}
