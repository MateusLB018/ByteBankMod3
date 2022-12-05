using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankMod3
{
   public  class Funcionario
    {
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
      
       

        public double GetBonificacao()
        {
            return Salario;
        }

        /*public Funcionario(int _tipo)
        {
            Tipo = _tipo;
        }
        
        public double GetBonificacao()
        {
            switch (Tipo)
            {
                case 1:
                    return Salario;
                    break;
                case 2:
                    return Salario * 0.10;
                    break;
                default:
                    return 0;
                    break;
            }
        }*/
    }
}
