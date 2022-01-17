// classe orientada a objeto
using System;
public class MostraMTB//inicio a classe como pública e declaro as propriedades da mesma forma
{
    public string nome = ""; 
    public string cor = "";
    public int tamanho;
    public float preco;
}
public class lista//e esta utilizo  para objeto
{
    static void Main(String[] args)//método
    {//aqui chamo a classe onde declarei as propriedades, adiciono um novo nome, uso o operador NEW e istanciei um novo objeto da classe jogador.   
       //OBS.: operador NEW -> reserva um espaço na memória para o objeto. o bjeto fica independente um do outro
        MostraMTB baike1=new MostraMTB();
        MostraMTB baike2=new MostraMTB();
        MostraMTB baike3=new MostraMTB();

     // aqui acesso as propriedades e posso altera-las para o objeto criado independentemente. 
        baike1.nome = "MTB001";
        baike1.cor = "Preto";
        baike1.tamanho = 19; 
        baike1.preco = 1950.00f;
     
        Console.WriteLine("------------------CATÁLOGO-----------------\n");
        Console.Write("Mountain bike 1 | nome/modelo: ");
        Console.Write(baike1.nome);

    }
} 