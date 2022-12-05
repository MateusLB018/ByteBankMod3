using ByteBankMod3.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankMod3
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Funcionario Carlos = new Funcionario();

            Carlos.Nome = "Carlos";
            Carlos.Cpf = "76357953768";
            Carlos.Salario = 7500.5;

            gerenciador.Registrar = (Carlos);

            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBonificacao());



            Console.WriteLine("aperte enter para finalizar : ");
            Console.ReadLine();
        }
    }
}
