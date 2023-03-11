using KalikBank_ADM.Funcionarios;

namespace KalikBank_ADM.CamadaSeguranca
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha, string loginCpf)
        {
            bool autenticacao = funcionario.Autenticar(senha, loginCpf);

            if (autenticacao)
            {
                Console.WriteLine("Entrando no sistema");
                return true;
            }

            Console.WriteLine("Senha Incorreta ou CPF incorretos!");
            return false;
        }

        internal void Logar(Funcionario funcionario, string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
