using KalikBank_ADM.CamadaSeguranca;
using KalikBank_ADM.Funcionarios;
using KalikBank_ADM.Utilitario;
using System.Collections.Generic;

GerenciadorBonificacao ger = new GerenciadorBonificacao();
SistemaInterno sistemaLogin = new SistemaInterno();
List<Funcionario> funcionario = new List<Funcionario>();

funcionario.Add(new Auxiliar("Eduardo", "321.432.432-50"));
funcionario.Add(new Designer("Hebert", "332.412.332-40"));
funcionario.Add(new Diretor("Felipe", "345.345.345-34","123"));
funcionario.Add(new GerenteDeContas("Gabriel", "234.213.984-01", "456"));

foreach (var i in funcionario)
{
    ger.Registrar(i);
}

Console.WriteLine($"Total de bonificação: R$ {ger.GetBonificacao()}");


sistemaLogin.Logar((iAutenticavel)funcionario[2], "123", "345.315.345-34");
sistemaLogin.Logar((iAutenticavel)funcionario[3], "123", "234.213.984-01");
sistemaLogin.Logar((iAutenticavel)funcionario[1], "123", "234.213.984-01");

