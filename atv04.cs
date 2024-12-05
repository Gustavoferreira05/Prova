/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWord
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira data (formato: 01/01/2024):");
        string data1Input = Console.ReadLine();

        Console.WriteLine("Digite a segunda data (formato: 01/01/2024)):");
        string data2Input = Console.ReadLine();

        DateTime data1, data2;

       
        bool data1Valida = DateTime.TryParseExact(data1Input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data1);
        bool data2Valida = DateTime.TryParseExact(data2Input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data2);

        if (!data1Valida || !data2Valida)
        {
            Console.WriteLine("Uma ou ambas as datas inseridas estão em formato inválido.");
            return;
        }

        
        TimeSpan diferenca = data2 - data1;

        Console.WriteLine($"A diferença entre as duas datas é de {Math.Abs(diferenca.Days)} dias.");
    }
}
