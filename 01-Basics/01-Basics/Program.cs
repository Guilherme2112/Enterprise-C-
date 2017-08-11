using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface CalculaInvestimento
    {
    String CalculaInvestimento();
        
    }
    abstract class Conta
    {

        public int agencia { get; set; }
        public DateTime dataAbertura { get; set; }
        public int numero { get; set; }
        public decimal saldo { get; set; }

        void depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine("Sucesso!");
        }
         public virtual String sacar(decimal valor)
        {
            return "Saca";
        }

    }
    enum TipoConta
    {
        Comum,
        Especial,
        Premium  
    }
    sealed class ContaCorrente :Conta
    {
    TipoConta tipo { get; set; }
    public override String sacar(decimal valor)
    {
        if (this.tipo == TipoConta.Comum && 
            valor > saldo)
        {
            throw new Exception("Algo errado não está certo.");
        }
        else
        {
            saldo -= valor;
            return "Sucesso!";
        }
    }
    }

class ContaPoupanca : Conta, CalculaInvestimento
{
        decimal Taxa;
        readonly decimal _rendimento;

    public string CalculaInvestimento()
    {
        throw new NotImplementedException();
    }
        ContaPoupanca(decimal rendimento)
        {
            this._rendimento = rendimento;
        }

}
}

    