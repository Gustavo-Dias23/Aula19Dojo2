namespace Aula19Dojo2
{
    public class IngressoVip : Ingresso
    {
        public float ValorAdicional { get; set; }

        public void ImprimirValorVip(){
            System.Console.WriteLine($"O valor do ingresso VIP é de R$ {Valor + ValorAdicional}.");
        }
        public void MostrarDiferença(){
            System.Console.WriteLine($"O valor da diferença entre os ingressos é de R$ {ValorAdicional}.");
        }
    }
}