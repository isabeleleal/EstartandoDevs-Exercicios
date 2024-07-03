// Exercicio 1 

/* double ObterSalario( ){
  Console.WriteLine("Escreva o salário");
  double salario = Convert.ToDouble(Console.ReadLine());

  double porcentagem = salario * 0.25;

  double novoSalario = salario + porcentagem;

  return  novoSalario ;
}

Console.WriteLine(ObterSalario()); */

// Exercicio 2

/* Console.WriteLine("Escreva o salário:");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o porcentual desse funcionário:");
double novoPorcentual = Convert.ToDouble(Console.ReadLine());

var porcentagem =  salario * novoPorcentual;


var novoSalario = salario + porcentagem;

Console.WriteLine(novoSalario); */

// Exercicio 3

/* 
Console.WriteLine("Informe o ano atual:");
int anoAtual =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o ano que você nasceu:");
int anoNascimento = Convert.ToInt16(Console.ReadLine());


int idade = anoAtual - anoNascimento;
int meses = idade*12;
double dias = idade * 365;
double semanas = idade*365/7;

Console.WriteLine("Você tem " + idade + " anos, " +  meses + " meses, " + dias + " dias e " + semanas + " semanas"); */
/* Console.WriteLine(idade); */

// Exercicio 4

/* Console.WriteLine("Informe o peso do saco de ração em quilos:");
double pesoSacoQuilo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a quantidade diariamente de ração dos gatos:");
int quantidadeDiariaGatos = Convert.ToInt32(Console.ReadLine());

double pesoSacoGramas = pesoSacoQuilo*1000;

int quantidadeTotalFornecida = quantidadeDiariaGatos*2*5;
double racaoRestante = pesoSacoGramas - quantidadeTotalFornecida;

double racaoRestanteEmQuilo = racaoRestante/1000;

Console.WriteLine("Após cinco dias, restarão " + racaoRestanteEmQuilo + " gramas de ração no saco") ; */

// Exercicio 5

/* Console.WriteLine("Informe o valor da variável A:");
int varA = Convert.ToInt32(Console.ReadLine());;

Console.WriteLine("Informe o valor da variável B:");
int varB =Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" O valor da variável A é " + varB + " e da variável B é " + varA ); */

// Exercicio 6

/* Console.WriteLine("Calcule o valor do volume de uma caixa retangular:");

Console.WriteLine("Digite o comprimento:");
int comprimento = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite a largura:");
int largura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a altura:");
int altura = Convert.ToInt32(Console.ReadLine());

int volume = comprimento*largura*altura;
Console.WriteLine("O volume do retangulo é " + volume); */

// Exercicio 7

/* Console.WriteLine("Informe o valor da variável A:");
int varA = Convert.ToInt32(Console.ReadLine());;

Console.WriteLine("Informe o valor da variável B:");
int varB =Convert.ToInt32(Console.ReadLine());

int quadradoVarA = varA*varA;

int diferenca = quadradoVarA - varB;

Console.WriteLine($"A diferença entre os valores é: {diferenca} ");  */

// Exercicio 8

/*  Console.WriteLine("Qual a cotação do dolar atual?");
 decimal valorCotacao = decimal.Parse(Console.ReadLine());

 Console.WriteLine("Qual o valor em dolar que você quer converter em real?");
 decimal valorEmDolar = decimal.Parse(Console.ReadLine());

 decimal valorConvertido = valorEmDolar*valorCotacao;
 Console.WriteLine($"O valor da conversão em real é   {valorConvertido:F2} ");
*/

// Exercicio 9

/*   Console.WriteLine("Digite o primeiro número:");
  int varA = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Digite o segundo número:");
  int varB = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Digite o primeiro número:");
  int varC = Convert.ToInt32(Console.ReadLine());

  int somaDosValores = varA+varB+varC;

  int valorFinal = somaDosValores*somaDosValores;

  Console.WriteLine($"O valor do quadrado da soma dos três valores lidos é {valorFinal}"); */

// Exercicio 10

/* using System.Runtime.InteropServices;

Console.WriteLine("Digite o primeiro número:");
int varA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int varB = Convert.ToInt32(Console.ReadLine());

int soma = varA+varB;
int subtracao = varA-varB;
int divisao = varA/varB;
int multiplicacao = varA*varB;

Console.WriteLine($"A Soma de {varA} e {varB} é {soma} ");
Console.WriteLine($"A Subtração de {varA} e {varB} é {subtracao} ");
Console.WriteLine($"A Divisão de {varA} e {varB} é {divisao} ");
Console.WriteLine($"A Multiplicação de {varA} e {varB} é {multiplicacao} "); */

// Exercicio 11

/* Console.WriteLine("Digite o raio da esfera:");
double raio = Convert.ToDouble(Console.ReadLine());

double pi = 3.14159;
double volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3);

Console.WriteLine($"O volume da esfera com raio {raio} é:  {volume}"); */

// Exercicio 12 

/* using System.Reflection;

Console.WriteLine("Digite um valor inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());   

int sucessor = numero + 1;
int antecessor = numero - 1;
Console.WriteLine($"O sucessor de {numero} é {sucessor} e o antecessor do mesmo é {antecessor}"); */

// Exercicio 13

// parte a

/* double a = 2;
double b = 3;
double c = 4;
double dif = -5;

double soma = a+b+c-dif;


dif = Math.Pow(soma, 2);

soma = Math.Sqrt(dif);

a = c;
b = -3;

Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");
Console.WriteLine($"c: {c}");
Console.WriteLine($"soma: {soma}" );
Console.WriteLine($"dif: {dif} "); */

// parte b

/* double x  = 25;
double y = 52;
double resto = y % x;
double quociente = y/ x;

x = resto;
y = quociente;

Console.WriteLine($"{x} e {y}");

resto = x%y;
quociente = x/y;



Console.WriteLine($"Resto é: {resto}");
Console.WriteLine($"Quociente é: {quociente}"); */