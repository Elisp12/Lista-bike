namespace catalogo.models
{
    public class desc : pagInicial
    {
        private static string opcao()
        {
             //mostra início
            Console.WriteLine("\n\t\t\t----------- CATÁLOGO MTB ------------\n");
            Console.WriteLine($"\n\t\t'OPÇÕES' \n\n [1] Mais Populáres  \t\t [2] Preços acessíveis \t\t [3] Mostrar Catálogo \t\t\t [X] Sair");
            
            string opnar = Console.ReadLine();
            Console.WriteLine();
            return opnar; 
        }
        public override void mostrar()
        {
            string opnar = opcao();
            while(opnar.ToUpper() != "X")
            {
                switch(opnar)
                {
                    case "1":
                    // MTB mais populares
                    Console.WriteLine("\n MTB's mais Populares");
                    break;

                    case "2":
                    break;
                    
                    case "3":
                    break;
                    
                    default:
                    throw new AppDomainUnloadedException();
                    

                }
                opnar = opcao();
            }

        }
    }
}