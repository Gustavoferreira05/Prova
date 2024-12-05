/******************************************************************************

Welcome to GDB Online.
  GDB online is an online compiler and debugger tool for C, C++, Python, PHP, Ruby, 
  C#, OCaml, VB, Perl, Swift, Prolog, Javascript, Pascal, COBOL, HTML, CSS, JS
  Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Digite (A) para vertebrado ou (B) para invertebrado:");
        string n1 = Console.ReadLine();

        Console.WriteLine("Digite se (A) ave, (B) mamífero, (C) inseto ou (D) anelídeo:");
        string n2 = Console.ReadLine();

        Console.WriteLine("Digite (A) carnívoro, (B) onívoro, (C) herbívoro ou (D) hematófago:");
        string n3 = Console.ReadLine();

       
        string frase1 = n1.ToUpper();
        string frase2 = n2.ToUpper();
        string frase3 = n3.ToUpper();

        if (frase1 == "A")
        {
            if (frase2 == "A" && frase3 == "A")
            {
                Console.WriteLine("O ANIMAL É UMA ÁGUIA!");
            }
            else if (frase2 == "A" && frase3 == "B")
            {
                Console.WriteLine("O ANIMAL É UMA POMBA!");
            }
            else if (frase2 == "B" && frase3 == "B")
            {
                Console.WriteLine("O ANIMAL É UM HOMEM!");
            }
            else if (frase2 == "B" && frase3 == "C")
            {
                Console.WriteLine("O ANIMAL É UMA VACA!");
            }
            else
            {
                Console.WriteLine("Nenhum animal correspondente foi encontrado para essas opções!");
            }
        }
        else if (frase1 == "B")
        {
            if (frase2 == "C" && frase3 == "D")
            {
                Console.WriteLine("O ANIMAL É UMA LAGARTA!");
            }
            else if (frase2 == "D" && frase3 == "D")
            {
                Console.WriteLine("O ANIMAL É UMA SANGUESSUGA!");
            }
            else if (frase2 == "D" && frase3 == "B")
            {
                Console.WriteLine("O ANIMAL É UMA MINHOCA!");
            }
            else
            {
                Console.WriteLine("Nenhum animal correspondente foi encontrado para essas opções!");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma categoria válida foi selecionada.");
        }

        Console.WriteLine("Não pedi o nome, pois daria muito tempo, mas apliquei as funções corretamente nos caracteres!");
    }
}
