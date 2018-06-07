using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Animal lula = new Animal();
            Animal tota = new Animal();
            Console.ReadKey();
        }
    }

    class Animal
    {
        public static int UltimoCodigo = 0;
        public int Codigo;

        public Animal()
        {
            Codigo = UltimoCodigo;
            UltimoCodigo++;
        }
        }
    }

