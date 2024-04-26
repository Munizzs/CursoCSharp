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




//Tratando exeções

try
{
//Ler um arquivo

    string[] linha = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    Console.WriteLine("\n\nLEITURA DE ARQUIVOS");
    foreach(string show in linha)
    {
        Console.WriteLine(show);
    }
}catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo não encontrado. \n{ex.Message}"); //Exeção expecifica.
}catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exeção generica. \n{ex.Message}"); //Exeção generica.
}finally
{
    Console.WriteLine("Chegou aqui");//No Finally independente de ocorrer uma exeção, ele é execultado.
}





//Coleções Fila
Console.WriteLine("\n\nFILA");

Queue<int> fila = new Queue<int>();

//Adicionar a fila
fila.Enqueue(5);
fila.Enqueue(2);
fila.Enqueue(9);

//Proximo da fila
fila.Dequeue();

//Mostrar fila
foreach(int show in fila)
{
    Console.WriteLine(show);
}





//Coleções Pilha
Console.WriteLine("\n\nPILHA");

Stack<int> pilha = new Stack<int>();

//Adicionar a pilha
pilha.Push(3);
pilha.Push(10);
pilha.Push(8);

//Proximo da pilha
pilha.Pop();

//Mostrar pilha
foreach(int show in pilha)
{
    Console.WriteLine(show);
}





//Coleções Dictionary
Console.WriteLine("\n\nDICTIONARY");

Dictionary<string,string> estados = new Dictionary<string, string>();

//Adicionar a Dictionary
estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");

//PRemover do Dictionary
estados.Remove("BA");

//Alterar Dictionary
estados["SP"] = "Novo São Paulo";

//Acessar um valor Dictionary
Console.WriteLine(estados["SP"]);

//Se existe tal chave Dictionary
Console.WriteLine(estados.ContainsKey);

//Mostrar Dictionary
foreach(var show in estados)
{
    Console.WriteLine($"Chave {show.Key}, Valor {show.Value}");
}





//Tuplas
Console.WriteLine("\n\nTUPLA");
(int ID, string Nome, string) tupla = (1,"Matheus","Muniz"); //Unico que pode ser nomeado.
ValueTuple<int, string, string> tupla2 = (1,"Matheus","Muniz");
var tupla3 = Tuple.Create (1,"Matheus","Muniz");

Console.WriteLine($"ID {tupla.ID}");
Console.WriteLine($"Nome {tupla.Nome}");
Console.WriteLine($"Sobrenome {tupla.Item3}");

LeituraArquivo arq = new LeituraArquivo();

var (Sucesso,linhas,qtdLinhas) = arq.LerArquivo("arquivos/arquivoLeitura.txt");
//var (Sucesso,linhas,_) = arq.LerArquivo("arquivos/arquivoLeitura.txt"); O _ serve como descarte

if(Sucesso)
{
    Console.WriteLine("Quantidade de linhas: "+qtdLinhas);
    foreach(string ver in linhas)
    {
        Console.WriteLine(ver);
    }
}else
{
    System.Console.WriteLine("Não foi possivel ler o arquivo");
}

//(string nome, string sobrenome) = p2; chamando o desconstrutor



//IF ternario

int n = 12;
bool ehPar=false;

ehPar = n % 2 == 0;
Console.WriteLine($"\n\nO numero {n} é " +(ehPar ? "par" : "impar"));





