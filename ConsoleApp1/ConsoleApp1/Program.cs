using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Using the C# language, have the function SimpleSymbols(str) take the str parameter being passed and determine 
 * if it is an acceptable sequence by either returning the string true or false. 
 * The str parameter will be composed of + and = symbols with several letters between them (ie. ++d+===+c++==a) 
 * and for the string to be true each letter must be surrounded by a + symbol. So the string to the left would be false. 
 * 
 * The string will not be empty and will have at least one letter. 
 * 
 * Input:"+d+=3=+s+"
 * Output:"true"
 * 
 * Input:"f++d+"
 * Output:"false"
 * 
 * */
namespace ConsoleApp1
{
    class MainClass
    {
        public static string SimpleSymbols(string str)
        {
            char[] ch = str.ToCharArray();
            bool keepTrying = true;
            int i = 1;

            if ((ch[0] >= 97 && ch[0] <= 122) || (ch[ch.Length-1] >= 97 && ch[ch.Length-1] <= 122))
            {
                keepTrying = false;
            }
            while (i<ch.Length-1 && keepTrying)
            
            {
                if (ch[i] >= 97 && ch[i] <= 122)
                {
                    if (!(ch[i-1] == '+' && ch[i+1] == '+'))
                    {
                        keepTrying = false;
                    }
                }
                i++;
            }

            if (keepTrying)
            {
                return "true";
            }
            else
            {
                return "false";
            }

        }


        static void Main()
        {
            // keep this function call here
            Console.WriteLine(SimpleSymbols(Console.ReadLine()));
        }

    }
}
