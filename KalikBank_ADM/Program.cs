using KalikBank_ADM.CamadaSeguranca;
using KalikBank_ADM.Funcionarios;
using KalikBank_ADM.Parceria;
using KalikBank_ADM.Utilitario;
using System.Collections.Generic;

SistemaInterno sistemaLogin = new SistemaInterno();
List<Funcionario> funcionario = new List<Funcionario>();
List<ParceiroComercial> parceiros = new List<ParceiroComercial>();

funcionario.Add(new Auxiliar("Eduardo", "321.432.432-50"));
funcionario.Add(new Designer("Hebert", "332.412.332-40"));
funcionario.Add(new Diretor("Felipe", "345.345.345-34","123"));
funcionario.Add(new GerenteDeContas("Gabriel", "234.213.984-01", "456"));
parceiros.Add(new ParceiroComercial("768", "324.432.543/0001-30"));

foreach (var i in funcionario)
{
    i.RegistrarBonificacao();
}

foreach (var i in funcionario)
{
    Console.WriteLine($"{i.Nome}: R$ {i.GetBonificacao():F2}");
}

Console.WriteLine();
sistemaLogin.Logar((IAutenticavel)funcionario[2], "123", "345.345.345-34");
sistemaLogin.Logar((IAutenticavel)funcionario[3], "123", "234.213.984-01");
sistemaLogin.Logar((IAutenticavel)parceiros[0], "768", "324.432.543/0001-30");

