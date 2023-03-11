using KalikBank_ADM.Utilitario;


namespace KalikBank_ADM.Funcionarios
{
    public abstract class Funcionario : IBonificacao
    {
        public static int totalFuncionarios { get; set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public double TotalBonificacao { get; set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Id = totalFuncionarios++;
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }


        public abstract void AumentarSalario();

        public abstract void RegistrarBonificacao();

        public double GetBonificacao() {
            return TotalBonificacao;
        }
    }
}
