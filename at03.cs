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
        Console.Write("Informe sua idade em dias: ");

       
        int idade = int.Parse(Console.ReadLine());

     
        int anos = idade / 365;
        int meses = (idade % 365) / 30;
        int dias = (idade % 365) % 30;

      
        Console.WriteLine($"Você tem {anos} ano(s), {meses} mês(es) e {dias} dia(s).");
    }
}
