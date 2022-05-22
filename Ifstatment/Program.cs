using System;

namespace Ifstatment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi User, Enter your age: ");
            
            int user = Convert.ToInt32(Console.ReadLine()); 

            if (user <= 10)
            {
                Console.WriteLine("User is 10 or younger");
            }
            else if (user > 10 && user < 16)
            {
                Console.WriteLine("User is older than 10 but young than 16");
            }
            else if (user > 19 && user < 39)
            {
                Console.WriteLine("User is between 19 and 39");
            }
            else if (user > 45 && user < 50)
            {
                Console.WriteLine("User us between 45 and 50");
            }
            else if (user > 60)
            {
                Console.WriteLine("User is 60 plus");
            }
                    
        }
    }
}
