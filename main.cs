/* 
  Author: Rylei
  Copyright: 2021
  Description: L
*/
using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //Here is the beginning
    //state the name of the character
    //intordouce first question

    Console.WriteLine ("you are trapped in a dark cave");
    Console.WriteLine ("you hear a faint screem in the background");
    Console.WriteLine ("you hear your name... ");

    //Variables - a word that represents data 
      //name
      //health

    //Conventions - for local variables in C# - typical way of doing something
      //a word or phrase that represents contents
      //Variables start with a lowercase letter
      //variables with more than one word use camelCase
        //numberOfstudents

    //Data type
      //Different types of data have different opperations

    //String - any sequence of characters

    string weapon = "Dagger";
    Console.WriteLine("You pick up the " + weapon);
    Console.WriteLine("You weild the " + weapon);
    
    Console.WriteLine(" ");

    Console.Write("What is your name? ");
    string name = Console.ReadLine();
    Console.WriteLine("Greetings, " + name);

    Console.WriteLine(" ");

    //int: integer - numbers (whole)

    int health = 25;
    Console.WriteLine("Your health: " + health);

    Console.WriteLine("You are struck for 5 damage!");
    health -= 5;
    Console.WriteLine("Your health: " + health);

    Console.WriteLine(" ");

    Console.WriteLine("You eat a golden apple to double your health");
    health *= 2; //(+=, -=, *=, /=)
    Console.WriteLine("Your health: " + health);

    Console.WriteLine(" ");

    //double: number with a decimal point

    double money = 19.99;
    Console.WriteLine("Your wallet: " + money);

    Console.WriteLine(" ");
    
    //bool
    bool isAlive = health > 0;
    Console.WriteLine("Alive; " + isAlive);

  }
}

