using System;
using catalogo.models;
namespace catalogo
{
    public class Program
    {
        static void Main(String[] args)
        {
            pagInicial b1 = new pagInicial();
            b1.nomeMod ="MTB001";
            b1.mostrar();
            desc d1 = new desc();
            d1.mostrar();
        }
    }
}
