using ExemploExplorando.Models;
using System.Globalization;

Pessoa p1 = new Pessoa("Jorge","Silva");

Pessoa p2 = new Pessoa("Fernanda","Queiroz");

Curso asam = new Curso();
asam.Nome = "Empregabilidade";
asam.Alunos = new List<Pessoa>();

asam.AdicionarAluno(p1);
asam.AdicionarAluno(p2);
asam.Listar();

//Formatando valores monetarios

/*
    Para formatar TODO seu sistema para outra cultura

    using System.Globalization;
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
*/

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal money = 1000.50M;

Console.WriteLine($"\n\nNumero:\n{money:C}"); //Ao colocar um numero depois do C, é definido a quantidade de casas decimais e o N retira a moeda e formata apenas as casas decimais
Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

//Definir uma porcentagem

double porc = .5576;
Console.WriteLine(porc.ToString("P"));

//Personalizar a saida

int num = 123456;
Console.WriteLine(num.ToString("##-##-##"));

/*
    Definir data e hora

    DateTime data = DateTime.Now;
*/

DateTime data = DateTime.Now;

Console.WriteLine($"\n\nDATA\n{data}");
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Formatar a data e a hora

//Definir uma data especifica

string dt = "12-05-2013";
Console.WriteLine(DateOnly.Parse(dt));


