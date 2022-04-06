
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
            Random r1 = new Random();
            Random r2 = new Random();
            int user_score = 0, computer1_score = 0, computer2_score = 0 ,index1,index2;
            string computer1_choice, computer2_choice,user_choice;
            string[] options = new string[2];
            
            options[0] = "on";
            options[1] = "back";

            while (true)
            {
                index1 = r1.Next(0, 2);
                computer1_choice = options[index1];
                index2 = r2.Next(0, 2);
                computer2_choice = options[index2];
                user_choice = Console.ReadLine();
                Console.WriteLine(computer1_choice);
                Console.WriteLine(computer2_choice);
                if (computer1_choice == "on" && user_choice == "back"&& computer2_choice == "back")

                {
                    computer1_score++;
                }

                else if (computer1_choice == "back" && user_choice == "on" && computer2_choice == "back" )
                {
                    user_score++;
                }

                else if (computer1_choice == "back" && user_choice == "back" && computer2_choice == "on")
                {
                    computer2_score++;
                }
               
                if (computer1_score ==5 || user_score==5 ||computer2_score ==5 )
                    
                { 
                    break;
                }

            }
            if (computer_score1 == 5)
            {
                Console.WriteLine("COMPUTER1 WIN ");
               
            }
            else if (user_score == 5)
            {
                Console.WriteLine(" YOU WIN");
                
            }
            else if (computer_score2 == 5)
            {
                Console.WriteLine("COMPUTER2 WIN ");
            }  
           
            
            
       
              
        }

    }
}

          