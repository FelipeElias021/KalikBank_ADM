# KalikBank
Aplicativo para a parte de RH de um banco, utlizando organização lógica, classes abstratas, heranças e interfaces.

O sistema é composto com uma classe base de funcionário que se deriva em Auxiliar, Design, Gerente de Contas e Diretor, onde recebem aumento e uma interface para bonificações.
Apenas o Gerente e o Diretor podem logar no sistema, por isso é criado uma interface para autenticar os 2, além de um parceiro comercial que pode apenas logar, mas não pode realizar as operações de outros funcionários.