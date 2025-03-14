using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadePOOlanchoneteparte2
{
    public class Organizacao
    {

        public int MenuGeral(int op)
        {

            Console.WriteLine("[1] - CARDAPIO");
            Console.WriteLine("[2] - CRIAR PEDIDO");
            Console.WriteLine("[3] - VISUALIZAR PEDIDOS");

            Console.WriteLine("digite uma opcao");
            op = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (op)
            {
                case 1:
                    MostrarMenu();
                    break;

                case 2:
                    break;

                case 0:
                    Console.WriteLine("flw");
                    Thread.Sleep(3000);
                    break;

                default:
                    break;
            }

            Console.Clear();
            return op;
        }

        public void MostrarMenu()
        { 
            Produto produto = new Produto();
            produto.lista = new List<Produto>();

            Produto xsalada = new Produto();
            xsalada.NomeProduto = "1-X-salada";
            xsalada.Preco = 10;
            produto.lista.Add(xsalada);

            Produto xburguerMedio = new Produto();
            xburguerMedio.NomeProduto = "2-X-burguer Medio";
            xburguerMedio.Preco = 20;
            produto.lista.Add(xburguerMedio);

            Produto xburguerGrande = new Produto();
            xburguerGrande.NomeProduto = "3-X-burguer Grande";
            xburguerGrande.Preco = 30;
            produto.lista.Add(xburguerGrande);

            Produto cocaCola = new Produto();
            cocaCola.NomeProduto = "4-Coca-Cola";
            cocaCola.Preco = 5;
            produto.lista.Add(cocaCola);

            Console.WriteLine("CARDAPIO\n ------------------------------");

            foreach (Produto item in produto.lista)
            {
                Console.WriteLine($"{item.NomeProduto.PadRight(20)}  R${item.Preco}");
            }
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();
        }
    }
}
