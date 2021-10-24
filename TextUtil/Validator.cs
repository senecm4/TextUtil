using System;
using TextUtil;
namespace TextUtil
{
    public class Validator
    {
        // public int UserInputInt { get; set; }
        // public bool ValidMenuInput { get; set; }
        public int validateINT(int userInputInt, bool validMenuInput)
        {
            try
            {
                userInputInt = Convert.ToInt32(Console.ReadLine());
                validMenuInput = true;
                return userInputInt;
            }
            catch (System.Exception) // may have to specifiy specific error in future
            {
                Writers.Error.WriteNL("Input Failure!");
                userInputInt = -1;
                return -1;
            }
        }

        public string validateSTRING(string userInputString, bool validMenuInput)
        {
            try
            {
                userInputString = Convert.ToString(Console.ReadLine());
                validMenuInput = true;
                return userInputString;
            }
            catch (System.Exception)
            {
                Writers.Error.WriteNL("Input Failure!");
                userInputString = null;
                return null;
            }
        }
    }

    public static class Validators
    {
        public static Validator Validator = new Validator();
    }
}