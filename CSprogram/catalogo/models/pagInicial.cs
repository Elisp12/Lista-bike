using System;
namespace catalogo.models
{
    public class pagInicial
    {
        public string nomeMod {get; set;}
        public string cor {get; set;}
        public int tm {get; set;}
        public int vlcd {get; set;}
        public virtual void mostrar()
        {
            Console.WriteLine($"Nome/Modelo: {nomeMod}");
        }
    }

}