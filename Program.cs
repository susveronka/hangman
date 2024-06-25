
using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;
namespace VS;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
 internal class Program
    {
  
        static void Main(string[] args)
        {
           

            Random random = new Random();
            List<string> slova = new List<string> { "kočka", "zahrada", "sluchátka", "auto", "peněženka", "mobil", "howdy", "ovoce", "nápoj" };
            int index = random.Next(slova.Count);
            String náhodnéSlovo = slova[index];

            foreach (char x in náhodnéSlovo)
            {
                Console.Write("_ ");
            }

            int délkaSlova = náhodnéSlovo.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while (amountOfTimesWrong != 6 && currentLettersRight != délkaSlova)
            {
                Console.Write("\nZatím uhádnuté písmena");
                foreach (char letter in currentLettersGuessed)
                {
                    Console.Write(letter + " ");
                }
               
                Console.Write("\nHádej písmeno: ");
                char písmeno = Console.ReadLine()[0];
                // Check if that letter has already been guessed
                if (currentLettersGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\n už si uhádl tohle písmeno");
                    printHangman(amountOfTimesWrong);
                    currentLettersRight = printWord(currentLettersGuessed, náhodnéSlovo);
                    printLines(náhodnéSlovo);
                }
                else
                {
                 
                    bool right = false;
                    for (int i = 0; i < náhodnéSlovo.Length; i++) { if (písmeno == náhodnéSlovo[i]) { right = true; } }

                   
                    if (right)
                    {
                        printHangman(amountOfTimesWrong);
            
                        currentLettersGuessed.Add(písmeno);
                        currentLettersRight = printWord(currentLettersGuessed, náhodnéSlovo);
                      
                        
                    }
                   
                    else
                    {
                        amountOfTimesWrong += 1;
                        currentLettersGuessed.Add(písmeno);
                      
                        currentLettersRight = printWord(currentLettersGuessed, náhodnéSlovo);
                        Console.Write("\r\n");
                       
                    }
                }
            }
            Console.WriteLine("\r\n Konec hry");
        }
    }
}
