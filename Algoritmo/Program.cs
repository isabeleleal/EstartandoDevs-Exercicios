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
int anoAtual =Convert.ToInt16(Console.ReadLine());

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
int largura = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite a altura:");
int altura = Convert.ToInt16(Console.ReadLine());

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