/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("A frase está vazia ou contém apenas espaços.");
        }
        else
        {
           
            string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            int totalLetras = frase.Replace(" ", "").Length;

            Console.WriteLine($"A frase contém {palavras.Length} palavras.");
            Console.WriteLine($"A frase contém {totalLetras} letras.");
        }
    }
}
