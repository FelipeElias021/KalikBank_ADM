using KalikBank_ADM.CamadaSeguranca;

namespace KalikBank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf, string senha) : base(nome, cpf, senha, 5000)
        {
        }

        public override void RegistrarBonificacao()
        {
            TotalBonificacao += Salario * 0.50;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
