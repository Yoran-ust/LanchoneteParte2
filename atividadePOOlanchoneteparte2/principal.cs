using atividadePOOlanchoneteparte2;
using System;
using System.Reflection.Metadata;
using System.Security.AccessControl;

class principal
{
    static void Main(string[] args)
    {
        Organizacao organizacao = new Organizacao();

        int op = -1;
        while (op != 0)
        {
            organizacao.MenuGeral(op);
        }
    }

}