using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args) //Execução
    {
        Console.WriteLine("O analista de Numeros");

        var listaDeNumeros = new List<int> { 5, 1, 9, 0, 7, -2 };

        var resultado = AnalisarNumeros(listaDeNumeros);

        Console.WriteLine($"O menor valor é {resultado.menorValor}");
        Console.WriteLine($"O maior valor é {resultado.maiorValor}");
    }

    public static (int menorValor, int maiorValor) AnalisarNumeros(List<int> numeros) // código para encontrar valores.
    {
        int menorValor = numeros[0];
        int maiorValor = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero < menorValor)
            {
                menorValor = numero;
            }
            if (numero > maiorValor)
            {
                maiorValor = numero;
            }

        }
        return (menorValor, maiorValor);


    }


}











