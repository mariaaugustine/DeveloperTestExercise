using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDetails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            InputConverter.GetResult(input);  
            Console.ReadLine();
        }

        public static class InputConverter
        {
            public static string GetResult(string input)
            {
                string result = "Please give valid input.";
                string[] arr = input.Split(' ');

                if (arr.Length > 1) //check if inputs are supplied
                {
                    string versionOrSize = arr[0]; //first element of array
                    string fileName = arr[1];  //second element of array - filename

                    if (versionOrSize != "" && fileName != "") //check if array elements are not empty
                    {
                        if (versionOrSize == "-v" || versionOrSize == "--v" || versionOrSize == "/v" || versionOrSize == "--version") //if version 
                        {
                            result = "1";
                            //result = FileDetails.Version(fileName); // get the version number
                        }

                        if (versionOrSize == "-s" || versionOrSize == "--s" || versionOrSize == "/s" || versionOrSize == "--size") //if size
                        {
                            result = "2";
                            //result = FileDetails.Size(fileName).ToString(); // get size of file
                        }
                        Console.WriteLine(result);  // print result      
                    }
                    else
                    {
                        Console.WriteLine("Please give valid input.");
                    }
                }
                else
                {
                    Console.WriteLine("Please give valid input.");
                }

                return result;
            }
        }
    }
}
