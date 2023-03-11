using KalikBank_ADM.Funcionarios;

namespace KalikBank_ADM.CamadaSeguranca
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha, string loginCpf);
    }
}
