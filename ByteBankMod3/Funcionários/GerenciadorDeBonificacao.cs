using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankMod3.Funcionários
{
   public class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {

           _totalBonificacao+= funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {

            _totalBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
