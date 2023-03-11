using KalikBank_ADM.CamadaSeguranca;

namespace KalikBank_ADM.Parceria
{
    public class ParceiroComercial : iAutenticavel
    {
        public string Senha { get; set; }
        public string CNPJ { get; set; }

        public ParceiroComercial(string senha, string cnpj)
        {
            Senha = senha;
            this.CNPJ = cnpj;
        }

        public bool Autenticar(string senha, string loginCNPJ)
        {
            return (Senha == senha && CNPJ == loginCNPJ);
        }
    }
}
