using atividadePOOlanchoneteparte2;
using System;
using System.Reflection.Metadata;
using System.Security.AccessControl;

class principal 
{
    static void Main(string[] args)
    { 
        

        Produto produto = new Produto();
        produto.lista = new List<Produto>();

        Produto xsalada = new Produto();
        xsalada.NomeProduto = "1-X-salada";
        xsalada.Preco = 10;
        produto.lista.Add(xsalada);

        Produto xburguerMedio = new Produto();
        xburguerMedio.NomeProduto = "2-X-burguer Medio";
        xburguerMedio.Preco= 20;
        produto.lista.Add(xburguerMedio);

        Produto xburguerGrande = new Produto();
        xburguerGrande.NomeProduto = "3-X-burguer Grande";
        xburguerGrande.Preco = 30;
        produto.lista.Add (xburguerGrande);

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
    }
}