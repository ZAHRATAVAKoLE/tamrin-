
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int user_score = 0, computer_score = 0, index;
            string computer_choice, user_choice;
            string[] options = new string[2];
            
            options[0] = "on";
            options[1] = "back";

            while (true)
            {
                index = r.Next(0, 2);
                computer_choice = options[index];
                user_choice = Console.ReadLine();
                Console.WriteLine(computer_choice);
                if (computer_choice == "on" && user_choice == "back")
                {
                    computer_score++;
                }

                else if (computer_choice == "back" && user_choice == "on")
                {
                    user_score++;
                }

                if (computer_score ==5 || user_score==5)
                    
                { 
                    break;
                }

            }
            if (computer_score == 5)
            {
                Console.WriteLine("COMPUTER WIN ");
               
            }
            else if (user_score == 5)
            {
                Console.WriteLine(" YOU WIN");
                
            }

            
            
       
              
        }

    }
}

          