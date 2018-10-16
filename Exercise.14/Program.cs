using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._14
{
    class Program
    {
        static void Main(string[] args)
        {
            char doAgain;
            bool userRepeat = true;
            while (userRepeat == true)
            {

                Console.Write("Hello user! Please enter a number: ");

                try
                {
                    int userNumber = Int16.Parse(Console.ReadLine());

                    for (int i = 1; i <= userNumber; i++)
                    {
                        int iSquared = i * i;
                        Console.WriteLine(iSquared);
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("I'm sorry, I do not recognize that input.");
                    Console.WriteLine(" ");
                }

                Console.WriteLine("Would you like to run this program again? Y or N");
                doAgain = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(" ");

                if (doAgain == 'Y' || doAgain == 'y')
                {
                    userRepeat = true;
                }

                else
                {
                    userRepeat = false;
                }
            }
        }
    }
}
