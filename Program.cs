using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace ZkouskaHandmana
{
    internal class Program
    {
        private static void Zakresli(int wrong)
        {
            
            if (wrong == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\  |");
                Console.WriteLine("    ===");
            }
        }

        private static int printWord    (   List<char> guessedLetters, String slovo )
        {
            int counter = 0;
            int správně = 0;
            Console.Write("\r\n");
            foreach (char c in slovo)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    správně += 1;
                }
                else
                {
                    Console.Write("  ");
                }
                counter += 1;
            }
        
            return správně;
        }

        private static void printLines(String slovo)
        {
            Console.Write("\r");
            foreach (char c in slovo)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305 ");
            }
        }

        static void Main(string[] args)
        {
            

            Random random = new Random();
            List<string> wordDictionary = new List<string> { "kočka " , "strom",   "jachta " , "sluchátka", "postel", "výlet", "pomáhat", "ovoce" };
                     
            int index = random.Next(wordDictionary.Count);
            String slovo = wordDictionary[index];

            foreach (char x in slovo)
            {
                Console.Write("_ ");
            }

            int délkaSlova = slovo.Length;
            int kolikChyb = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

/*Console.WriteLine("vyber si kategorii: Zvířata, potraviny, nábytek");
int kategorii = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vybral jsi si: " + kategorii); */


            while (kolikChyb != 6 && currentLettersRight != délkaSlova)
            {
    

                Console.Write("\n Odhad: ");
                foreach (char letter in currentLettersGuessed)
                {
                    Console.Write(letter + " ");
                }
               
                Console.Write("\n Hádej písmeno: ");
                char letterGuessed = Console.ReadLine()[0];


         
                if (currentLettersGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\n Tohle písmeno už jsi hádal:");
                    Zakresli(kolikChyb);
                    currentLettersRight = printWord(currentLettersGuessed, slovo);
                    printLines(slovo);
                }
                else
                {
                    bool right = false;
                    for (int i = 0; i < slovo.Length; i++) { if (letterGuessed == slovo[i]) { right = true; } }

                    
                    if (right)
                    {
                       Zakresli(kolikChyb);
                        
                        currentLettersGuessed.Add(letterGuessed);
                        currentLettersRight = printWord(currentLettersGuessed, slovo);
                        Console.Write("\r\n");
                        printLines(slovo);
                    }
                 
                    else
                    {
                        kolikChyb += 1;
                        currentLettersGuessed.Add(letterGuessed);
                        
                       Zakresli(amountOfTimesWrong);
                        
                        currentLettersRight = printWord(currentLettersGuessed, slovo);
                        Console.Write("\r\n");
                        printLines(slovo);
                    }
                }
            }
            Console.WriteLine("\r\n Konec hry");
        }
    }
}
