/* 
Hunter Clezie 
Spring 2026
RCET2265
ConvertAndValidate
github url: 
*/
namespace ConvertAndValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            do
            {
                //prompt user for an input
                Console.WriteLine("Please enter a number to convert, or press \"Q\" to quit");
                userInput = Console.ReadLine();

                //attempt conversion and display result
                if (TryConvertToInt(userInput, out int convertedValue))
                {
                    Console.WriteLine($"Conversion successful! The integer value is: {convertedValue}");
                }

                //if conversion fails, display error message
                else
                {
                    Console.WriteLine("Conversion failed, Please enter a valid number.");
                }

            } while (userInput != "Q" && userInput != "q");

            //clear console before exiting
            Console.Clear();
            Console.WriteLine("Have a nice day!");

            //pause
            Console.Read();
        }

        //method to attempt conversion of a string to int, returns a true if successful and a false if not
        static bool TryConvertToInt(string input, out int result)
        {
            bool successful = true;
            result = 0; //out requires an assignment no matter what

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }

            catch
            {
                result = 0;
                return false;
            }
        }
    }
}
