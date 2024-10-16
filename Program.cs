/*
// Primeira questão 
using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 4;  
        ContadorCrescente(1, numero);
    }

    static void ContadorCrescente(int atual, int numero)
    {
        Console.WriteLine(atual);

        if (atual < numero)
        {
            ContadorCrescente(atual + 1, numero);
        }
    }
}*/


/*
//Segunda questão

using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 4; 
        ContadorDecrescente(numero);
    }

    static void ContadorDecrescente(int numero)
    {
        while (numero >= 0)
        {
            Console.WriteLine(numero);

            numero--;
        }
    }
}

*/


/*
using System;
 
 //Terceira questão

class Program
{
    static void Main(string[] args)
    {
        int numero = 4;
        ContadorSimetrico(1, numero, false);
    }

    static void ContadorSimetrico(int atual, int numero, bool reverso)
    {
        
        Console.WriteLine(atual);

        
        if (atual == numero && !reverso)
        {
            ContadorSimetrico(atual - 1, numero, true);
        }
        else if (!reverso)
        {
            ContadorSimetrico(atual + 1, numero, false);
        }
        else if (reverso && atual > 1)
        {
            ContadorSimetrico(atual - 1, numero, true);
        }
    }
}*/