using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf) : base (5000,cpf)  //indica que deve chamar automaticamente o construtor da classe base (super) antes do construtor do diretor, passando o cpf pra frente
        {
            //A ordem de execução é sempre primeiro o construtor da classe base e depois o construtor da classe derivada.
        }
        public override double GetBonificacao()
        {
            //return base.Salario + base.GetBonificacao(); //base seria o super no java, pega o elemento da classe pai
            return base.Salario * 0.5; 
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
