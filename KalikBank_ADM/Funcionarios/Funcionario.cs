using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalikBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public static int totalFuncionarios { get; set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Id = totalFuncionarios++;
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}
