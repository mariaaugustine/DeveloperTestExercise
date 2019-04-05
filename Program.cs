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
            string output=InputConverter.GetResult(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        public static class InputConverter
        {
            public static string GetResult(string input)
            {
                string result = "Please give valid input.";
                try
                {
                    string[] arr = input.Split(' ');

                    if (arr.Length > 1) //check if inputs are supplied
                    {
                        string versionOrSize = arr[0]; //first element of array
                        string fileName = arr[1];  //second element of array - filename

                        if (versionOrSize != "" && fileName != "") //check if array elements are not empty
                        {
                            if (versionOrSize == "-v" || versionOrSize == "--v" || versionOrSize == "/v" || versionOrSize == "--version") //if version 
                            {                                
                                result = FileDetails.Version(fileName); // get the version number
                            }

                            if (versionOrSize == "-s" || versionOrSize == "--s" || versionOrSize == "/s" || versionOrSize == "--size") //if size
                            {                                
                                result = FileDetails.Size(fileName).ToString(); // get size of file
                            }                                  
                        }
                        else
                        {
                            result="Please give valid input.";
                        }
                    }
                    else
                    {
                        result="Please give valid input.";
                    }
                }
                catch(Exception e)
                {
                    result= e.ToString();
                }

                return result;
            }
        }
    }
}
