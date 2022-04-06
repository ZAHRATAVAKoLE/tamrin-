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
            int user_score=0, computer_score=0 , index;
            string computer_choice, user_choice;
            string[] options = new string[3];
            options[0] = "rock";
            options[1] = " paper";
            options[2] = "scissor";
            for (int i = 0; i < 5; i++) 
            {
                index = r.Next(0,3);
                computer_choice = options[index];
                user_choice =Console.ReadLine();
                Console.WriteLine(computer_choice);
                if (computer_choice == "paper" && user_choice==" rock")
                {
                    computer_score++;
                }

                else if( computer_choice == "scissor" && user_choice== "rock")
                {
                    user_score++;
                }
                else if( computer_choice == "scissor" && user_choice=="scissor")
                {
                    computer_score++;

                    user_score++;
                }
                else if( computer_choice == " rock" && user_choice==" rock")
                {
                    computer_score++;

                    user_score++;
                }
                else if( computer_choice == " paper" && user_choice==" paper")
                {
                    computer_score++;

                    user_score++;
                }

                if (computer_choice == "rock" && user_choice == " paper")
                {
                    user_score++;
                }
                else if (computer_choice == "rock" && user_choice == "scissor")
                {
                    computer_score++;
                }
                else if (computer_choice == "scissor" && user_choice == "paper")
                {
                    computer_score++;
                }
                else if (computer_choice == "paper" && user_choice == "scissor")
                {
                    user_score++;
                }
                
            }
            if (computer_score < user_score)
            {
                Console.WriteLine(" YOU WIN");
            }
            if (computer_score > user_score)
            {
                Console.WriteLine(" COMPUTER WIN");
            }

            else
            {
                Console.WriteLine(" DRAW");
            }
        }

    }
}
