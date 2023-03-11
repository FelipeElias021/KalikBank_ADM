using KalikBank_ADM.CamadaSeguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalikBank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        protected FuncionarioAutenticavel(string nome, string cpf, string senha, double salario) : base(nome, cpf, salario)
        {
            Senha = senha;
        }

        public  bool Autenticar(string senha, string login)
        {
            return (Senha == senha && Cpf == login);
        }
    }
}
