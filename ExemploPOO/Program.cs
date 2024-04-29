using ExemploPOO.Models;
using ExemploPOO.obj;

Aluno a1 = new Aluno();
a1.Nome = "Carlos";
a1.Idade = 15;
a1.Nota = 10;
a1.Apresentar();

Professor prof1 = new Professor();
prof1.Nome = "Julio";
prof1.Idade = 29;
prof1.Salario = 3010M;
prof1.Apresentar();

System.Console.WriteLine("\n\n\n\n");




ContaCorrente cc = new ContaCorrente(1,100);

cc.ExibirSaldo();
cc.SacarValor(150);
cc.ExibirSaldo();






// Pessoa p1 = new Pessoa();
// p1.Nome="João";
// p1.Idade=31;
// p1.Apresentar();

