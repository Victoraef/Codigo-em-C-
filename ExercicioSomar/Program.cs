using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    public static void Main(string[] args)
    {
        somaAN(5, 3);
        somaAN(1, 7);      
        
    }
    public static void somaAN(int a, int n)
    {
        int cont = a;
        string resultado = a + "+";
        int aux = a;
        for (int i = 1; i < n; i++)
        {
            cont += (a + i);
            aux = a + i;
            resultado += aux;
            if (i != n - 1)
            {
                resultado += "+";
            }
        }

        Console.WriteLine(resultado + "=" + cont);

    }
}

