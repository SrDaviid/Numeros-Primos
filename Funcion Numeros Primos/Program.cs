using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcion_Numeros_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
        int n, i,c;
        c = 0;
        Console.WriteLine("Ingrese un numero ");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i <=n; i ++)
        {
            if(n % i == 0)
            {
                c = c+ 1;
            }
        }
        if (c > 2)
        {
            Console.WriteLine("{0} No es primo", n);
        }
        else
        {
            Console.WriteLine("{0} Es primo", n);
        }
        Console.ReadLine();
        }
    }
    
}
