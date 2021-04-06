//Made by Emily Felicio


using System;

namespace R_C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido lista = new Pedido();

            string resposta = "s";
            do{
                ItemPedido itempedido = new ItemPedido();

                Console.WriteLine("Informe seu pedido");
                itempedido.descricao = Console.ReadLine();

                Console.WriteLine("Infome a quantidade");
                itempedido.quantidade = Int32.Parse(Console.ReadLine());


                Console.WriteLine("Informe o valor");
                itempedido.valor_unitario = double.Parse(Console.ReadLine());

                lista.adicionar(itempedido);

                Console.WriteLine("Deseja fazer mais algum pedido? (s/n)");
                resposta = Console.ReadLine();

                if(resposta == "n")
                {
                    Console.WriteLine("Total: "+lista.totalizar());
                }

            } while(resposta == "s");
        }
    }
}
