using System.ComponentModel;

using System;


class Oběšenec
{

static void Main()

{





string input = Console.ReadLine().ToUpper();
string copyInput = input;
int lives = 10;

do
    {
        Console.Clear();
Console.WriteLine("pokusů:" + lives);

for(int i = 0; i< input.Length; i++)
{

    if(copyInput.Contains(input[i]))
    {

        Console.Write("_ ");
    }
    else
    {


        Console.Write( input[i] + " ");
    }
}

Console.WriteLine();
Console.Write("Zadejte písmeno");

ConsoleKeyInfo cki = Console.ReadKey();
 
Console.WriteLine();

if(input.Contains(char.ToUpper(cki.KeyChar)))
{

    copyInput = copyInput.Replace(char.ToUpper(cki.KeyChar).ToString(), "");
}
else
lives--;
     } while (lives > 0 && copyInput != "");

 if (lives != 0)
{
 
 Console.Write("výhra");
}

else
{

    Console.Write("prohra");
}

Console.WriteLine("odpověd byla" + input );}
 }