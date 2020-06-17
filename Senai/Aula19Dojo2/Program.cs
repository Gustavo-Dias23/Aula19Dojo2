using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVip bilhete = new IngressoVip();
            bilhete.Valor = 100f;
            bilhete.ValorAdicional = 95.75f;
            bilhete.ImprimirValor();
            bilhete.ImprimirValorVip();
            bilhete.MostrarDiferença();
        }
    }
}
