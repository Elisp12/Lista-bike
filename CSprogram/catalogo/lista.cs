using System;
namespace catalogo
{
    public class lista
    {
        //metodo que mostra menu ao cliente
        private static string opcaoDoCliente()
        {
            Console.WriteLine("\n"+"---------CATALOGO MOUNTAIN BIKE----------" + "\n");
            Console.WriteLine("Escolha uma das opções" + "\n");
            Console.WriteLine("[1] Mostrar bike popular");
            Console.WriteLine("[2] Mostrar bike mais acessível");
            Console.WriteLine("[3] Catálogo Completo" + "\n");
            Console.WriteLine("[X] Sair!");

            //mostra opcção para usuário
            string opcaoCliente = Console.ReadLine();
            Console.WriteLine(); //pula uma linha
            return opcaoCliente;
        }

        static void Main(String[] args)
        {
            // chamo classe modelos e instanciando um arrey
            modelos[] modelo = new modelos[4];

            string opcaoCliente = opcaoDoCliente();// catalogo
            while (opcaoCliente.ToUpper() != "X"){//obs Toupper() != tipo de caixa digitado
                switch(opcaoCliente)
                {
                    case "1":
                    // mostra bike popular
                        modelos bike1 = new modelos();
                        bike1.nomeModelo = "Mountain baike, MTB0001";
                        bike1.cor = "Preto";
                        bike1.tm = 19;

                        Console.WriteLine("Mountain Bikes mais Populares" + "\n");
                        Console.Write("Nome Modelo: ");
                        Console.WriteLine(bike1.nomeModelo);
                        Console.Write("Cor: ");
                        Console.WriteLine(bike1.cor);
                        Console.Write("Tamanho: ");
                        Console.WriteLine(bike1.tm);

                        Console.WriteLine();
                        break;
                        case "2":
                        //mostra baike mais acessíveis
                        break;
                        case "3":
                        // catálogo completo
                        break;
                        default:
                        //dispara uma ecessao ate que a iformação seja igual "X", repete ate que o mesmo seja digitado, fechando o programa.
                        throw new ArgumentOutOfRangeException();
                }
                opcaoCliente = opcaoDoCliente();
            }

        }
    }
}