using KalikBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalikBank_ADM.Utilitario
{
    public interface IBonificacao
    {
        public double TotalBonificacao { get; set; }

        public void RegistrarBonificacao();

        public double GetBonificacao();
    }
}

