using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ExemploStatic
    {
        static void Main(string[] args)
        {
            Animal lula = new Animal();
            Animal tota = new Animal();
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
