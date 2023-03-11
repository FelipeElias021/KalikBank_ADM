using KalikBank_ADM.CamadaSeguranca;

namespace KalikBank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string nome, string cpf, string senha) : base(nome, cpf, senha, 4000)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
