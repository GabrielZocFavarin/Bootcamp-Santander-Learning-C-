// See https://aka.ms/new-console-template for more information
using Bootcamp_Santander_Learning_C_.Models;

Console.WriteLine("Hello, World!");

//Relembrando declarar Variáveis

string favaGabriel = "Fava do Gabriel";
Console.WriteLine(favaGabriel);
int quantidade = 10;

while (quantidade > 0)
{
    Console.WriteLine(quantidade);
    quantidade--;
}

DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Data Atual: {dataAtual}");


// Diferenças entre Parse e Convert, a principal diferença é o tratamento de valores nulos. Em Parse não há uma abertura para o valor ser nulo, gerando assim um fim do fluxo, e uma exceção.

string numeroString = "15";
int UsoConvert = Convert.ToInt32(numeroString);
int UsoParse = int.Parse(numeroString);
Console.WriteLine($"Número Convertido: {UsoConvert}");
Console.WriteLine($"Número Parseado: {UsoParse}");

//

string b = 5;
string a = 5.ToString();
Console.WriteLine(b);
Console.WriteLine(a);

// Vai dar erro porque está esperando uma String e vem um Int, ou seja, precisarei realizar a conversão, como demonstrado embaixo.

// usar convert.tostring é redundante, o correto é apenas a utilização ToString().

// Console.WriteLine(" O começo de tudo! O recomeço... ");

// Console.WriteLine(" A vida é feita de ciclos. ");

// Console.WriteLine(" Sempre haverá um novo amanhecer. ");

// Pessoa p = new Pessoa("Gabriel");

// Pessoa p1 = new Pessoa("Ana Maria");

// Pessoa p2 = new Pessoa("João do TEF");

// p2.Idade = 25;

// p.Apresentar();
// p1.Apresentar();
// p2.Apresentar();



