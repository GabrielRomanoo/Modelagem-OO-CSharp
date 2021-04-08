using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        /* public virtual double GetBonificacao() //virtual indica que esse metodo pode ser sobreescrito
        {
            return Salario * 0.10;
        } */

        public abstract double GetBonificacao(); //o abstract indica que esse metodo DEVE ser sobreescrito

        public abstract void AumentarSalario();
    }
}
