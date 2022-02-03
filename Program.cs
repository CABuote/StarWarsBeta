using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{





    class Program
    {


        static void Main(string[] args)


        {


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("In a galaxy far far away.... ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\r\nWhich path will you forego?");
            Console.WriteLine("\r\nType 'D' for Darkside Imperials, Type 'A' for Rebel Alliance");
            Console.Write("\r\n\r\n\r\n\r\nEnter your Faction: ");

            
            string alliance = Console.ReadLine();
            alliance = alliance.ToUpper();

           

            bool success = false;
            while (!success)
            {
                


            switch (alliance)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have choosen to follow the path of the good. Welcome, to the Rebel alliance");

                        //display list of rebelList
                        success = true;

                        break;
                        
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have chosen the Darkside. Welcome, to the Imperial Alliance!");
                        success=true;
                        
                        //display list from imperialList
                        break;

                    case "M":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Welcome to the Database. Bounty Hunter ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        
                        Console.WriteLine("\r\rThis is the way");

                        //Display list of Bounty Hunters

                        //Display Contracts
                        success=true;
                        break;
                    default:
                        //Defaulted "robot" 
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Hey robot... Learn how to follow the rules....");
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\r Beep");
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("\r\n\n\n Bop");
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine("\r\n\r\n\n Boop");
                        //error message repeat loop
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("You have entered an invalid function...");
                        Console.ForegroundColor = ConsoleColor.White;
                        //add original
                        Console.WriteLine("\r\nType 'D' for Darkside Imperials, Type 'A' for Rebel Alliance");

                        alliance = Console.ReadLine().ToUpper();
                        break;
                }
           
            }
            

            // For imperials
            // Console.WriteLine(" Welcome to the Imperial alliance. Please choose your character.");

            //For Rebels
            // Console.WriteLine(" Welcome to the Rebel alliance. Please choose your character.");

            //show list of imperialList

            //choose character
        }

    }
}
//Block below is proper
/*
{
    string alliance = Console.ReadLine();
    alliance = alliance.ToUpper();

    if (alliance == "A")
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("You have choosen to follow the path of the good. Rebel!");
        return;
    }
    if (alliance == "D")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Welcome to the Darkside, Imperial.");
        return;
    }
    if (alliance == "M")
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Welcome to the Galaxy, Bounty Hunter. ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("This is the way");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Hey robot... Learn how to follow the rules....beep bop boop");
    }

}


Console.WriteLine("Choose your Ranking");


*/
//Block above is proper



//this returns true if the string that was inputted is John Smit

//once you pick a faction produce list of available characters per faction

//make a list of storm troopers

// display lists of available troopers once user selects 'D'

// display list of available Rebels once user selects 'R'

//Display bounty hunters when user types " m'











//choose your alliance

// Choose rebel or darkside

//Use conversion functions to convert string to int


// display Welcome message

// input from user which side  " Imperial/ Rebel

// Choose your Character


