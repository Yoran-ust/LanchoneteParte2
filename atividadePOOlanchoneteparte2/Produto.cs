using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadePOOlanchoneteparte2
{
    public class Produto
    {
        public string NomeProduto;
        public double Preco;
        public List<Produto> lista;
        public void PrintProduto()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"{NomeProduto} = R$ {Preco}");
        }

    }
}
