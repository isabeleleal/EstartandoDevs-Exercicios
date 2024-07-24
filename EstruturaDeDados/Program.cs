// nível 2 - Exercício Estrutura Condicional

//***** Exercício 11 *******

/* Console.WriteLine("Digite o número da variável A:");
var varA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número da variável B:");
var varB = int.Parse(Console.ReadLine()); 

Console.WriteLine($"Valor da variável A é: {varB}");
Console.WriteLine($"Valor da variável B é: {varA}");     */



//***** Exercício 12 *******

/* Console.WriteLine("Digite um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

if( numero >= 0) */

//***** Exercício 13 *******

/* Console.Write("Digite o primeiro número inteiro: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número inteiro: ");
int numero2 = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número inteiro: ");
int numero3 = int.Parse(Console.ReadLine());

int maior, medio, menor;

if (numero1 >= numero2 && numero1 >= numero3)
{
    maior = numero1;
    if (numero2 >= numero3)
    {
        medio = numero2;
        menor = numero3;
    }
    else
    {
        medio = numero3;
        menor = numero2;
    }
}
else if (numero2 >= numero1 && numero2 >= numero3)
{
    maior = numero2;
    if (numero1 >= numero3)
    {
        medio = numero1;
        menor = numero3;
    }
    else
    {
        medio = numero3;
        menor = numero1;
    }
}
else
{
    maior = numero3;
    if (numero1 >= numero2)
    {
        medio = numero1;
        menor = numero2;
    }
    else
    {
        medio = numero2;
        menor = numero1;
    }
}

Console.WriteLine($"Esses são os números em ordem decrescente: \r\n {maior} \r\n {medio} \r\n {menor}");
 */


//***** Exercício 14 *******

/* Console.WriteLine("Digite o primeiro número:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int numero2 = int.Parse(Console.ReadLine());

int maior, menor;

if (numero1 >= numero2){
    maior = numero1;
    menor = numero2;
}else{
    maior = numero2;
    menor = numero1;
}

int diferenca = maior - menor;
Console.WriteLine($" A diferença entre {maior} e {menor} é {diferenca}"); */

// ******** Exercicio 15 ****
/* Console.WriteLine("Informe a primeira nota de Lucas:");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota de Lucas:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a terceira nota de Lucas:");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quarta nota de Lucas:");
int nota4 = int.Parse(Console.ReadLine());

int notaFinal = (nota1 + nota2 + nota3 + nota4)/4;

double notaMedia = 0;
int notaRecuperacao = 0;

if (notaFinal >= 7){
    Console.WriteLine($"Você foi aprovado com a nota final {notaFinal}");
    
}else if ( notaFinal < 7){
    Console.Write("Informe a nota de recuperação:");
    notaRecuperacao = int.Parse(Console.ReadLine());
    notaMedia = (notaFinal + notaRecuperacao)/2 ;

    if(notaMedia >= 7){
         Console.WriteLine($"Você foi aprovado na recuperação com a nota final {notaMedia}.");
    }
     
}else{
    Console.Write($"Você não foi aprovado e sua nota final é: {notaFinal}");
} */

// ******** Exercicio 16 ****

/* Console.WriteLine("Digite um número:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número:");
int numero2 = int.Parse(Console.ReadLine());

int maior, menor;


if(numero1 > numero2){
    maior = numero1;
    menor = numero2;

    Console.WriteLine($"O maior número é {maior}.");
    Console.WriteLine($"O menor número é {menor}.");
    
} else if(numero1 == numero2){
     Console.WriteLine($"Os número {numero1} e {numero2} são iguais.");
}else {
    maior = numero2;
    menor = numero1;

     Console.WriteLine($"O maior número é {maior}.");
    Console.WriteLine($"O menor número é {menor}.");
} */

// ******** Exercicio 17 ****

/* Console.WriteLine("Informe um número inteiro:");
int numeroInt = int.Parse(Console.ReadLine());

if(numeroInt >=0 && numeroInt<=9 ){
    Console.WriteLine($"O valor {numeroInt} é válido!");
}else{
    Console.WriteLine($"O valor {numeroInt} não é válido!");
}
 */

 // ******** Exercicio 18 ****

/* Console.WriteLine("Informe o código:");
int codigo = int.Parse(Console.ReadLine());

switch(codigo){
    case 1:
    Console.WriteLine($"Código {codigo} válido!");
    break;

    case 2:
    Console.WriteLine($"Código {codigo} válido!");
    break;

    case 3:
    Console.WriteLine($"Código {codigo} válido!");
    break;

    default:
    Console.WriteLine($"O código {codigo} é inválido!");
    break ;
} */

// ******** Exercicio 19 ****


/* Console.WriteLine("Digite o primeiro lado do triângulo:");
int varA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado do triângulo:");
int varB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado do triângulo:");
int varC = int.Parse(Console.ReadLine());



if( varA <  varB + varC && varB < varA+varC && varC< varA+varB){
    if(varA == varB && varB == varC){
        Console.WriteLine("O triângulo é equilátero!");
    } else if(varA==varB || varA==varC || varB == varC){
        Console.WriteLine("O triângulo é isósceles!");
    }else{
        Console.WriteLine("O triângulo é escaleno!");
    }
}else{
    Console.WriteLine("Os lados fornecidos não formam um triângulo.");
} */

// ******** Exercicio 20 ****   

/* int varA = 0;
int  varB = 0;
int  varC = 0;
while (varA <= 0 )
{

    Console.WriteLine("Digite o primeiro número:");
    varA = int.Parse(Console.ReadLine());

    if(varA <=0){
        Console.WriteLine("Número inválido, digite novamente:");
    }
}

while (varB <= 0 )
{

    Console.WriteLine("Digite o segundo número:");
    varB = int.Parse(Console.ReadLine());

    if(varB <=0){
        Console.WriteLine("Número inválido, digite novamente:");
    }
}
while (varC <= 0 )
{

    Console.WriteLine("Digite o terceiro número:");
    varC = int.Parse(Console.ReadLine());

    if(varC <=0){
        Console.WriteLine("Número inválido, digite novamente:");
    }
}

int maior = varA;
int menor = varA;
if(varB > maior){
    maior = varB;
}

if(varC > maior){
    maior =varC;
}

if (varB < menor){
    menor = varB;
}

if(varC < menor){
    menor = varC;
}

int valor = menor*maior;
int valor2= maior/menor;

Console.WriteLine($"O menor valor múltiplicado pelo maior valor é: {valor}");
Console.WriteLine($"O maior valor dividido pelo menor valor é: {valor2}"); */


/* for (int i = 0; i < 100; i++)
{
   if(numero[i] > maior){
    maior = numero[i]
   }
    if(numero[i] < menor){
    menor = numero[i] 
    }
} */




// ******** Exercicio 21 ****  ATENÇÃO
/* Console.WriteLine("Informe um número:");
int numero = int.Parse(Console.ReadLine());   


if( numero > 0 ){
    Console.WriteLine( $"{numero} é positivo!" );
}else if(numero <= 0 ){
    Console.WriteLine( $"{numero} é negativo" );
}else{
    Console.WriteLine( "Execução concluída" );
}
 */


// ******** Exercicio 22  ****  
/* int varA;
int varB;

Console.WriteLine("Informe um número:");
int numero = int.Parse(Console.ReadLine());



if (numero >= 0){
    varA = numero;
    Console.WriteLine($"{varA} é um número positivo!");
}else{
    varB = numero;
    Console.WriteLine($"{varB} é um número negativo!");
} */


// ******** Exercicio 23 ****

/* Console.WriteLine("Esolha uma opção:\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n");
int opcao = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um número:");
int numero5 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número:");
int numero6 = int.Parse(Console.ReadLine());

switch (opcao){
    case 1: 
        int adicao = numero1 + numero2;

        Console.WriteLine($"A adição de {numero1} e {numero2} é {adicao}");

        break;

    case 2:
        int subtracao = numero1 - numero2;

        Console.WriteLine($"A subtração de {numero1} e {numero2} é {subtracao}");

        break;    
    case 3:
       

        int multiplicacao =numero1 * numero2;

        Console.WriteLine($"A multiplicação de {numero1} e {numero2} é {multiplicacao}");

        break;

    case 4:
       
        int divisao = numero1 / numero2;

        Console.WriteLine($"A divisão de {numero1} e {numero2} é {divisao}");

        break;
} */

// ******** Exercicio 24 ****

/* Console.WriteLine("Escolha uma opção:");
Console.WriteLine("1- Verificar se um dos números lidos é ou não múltiplo do outro");
Console.WriteLine("2- Verificar se os dois números lidos são pares ");
Console.WriteLine("3- Verificar se a média dos dois números é maior ou igual a 7");
Console.WriteLine("4- Sair");
Console.WriteLine("Opção");
int  opcao = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um número:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número:");
int numero2 = int.Parse(Console.ReadLine());

switch (opcao){
    case 1: 

        int divisao = numero1 % numero2;
        if (divisao == 0){
            Console.WriteLine($"O número é múltiplos!");
        }else{
            Console.WriteLine($"O número não é múltiplos!");
        }
        break;
    case 2:
        if (numero1%2 == 0 && numero2%2 == 0){
            Console.WriteLine("Ambos os números são pares.");
        }else{
            Console.WriteLine("Pelo menos um dos números não é par.");
        }
        break;

    case 4:
        Console.WriteLine("");
        break;
}  */

// ******** Exercicio 25 ****

/* Console.WriteLine("Informe sua altura:");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe seu sexo: ");
Console.WriteLine("1 - Homem");
Console.WriteLine("2 - Mulher");
Console.WriteLine("sexo:");
int sexo = int.Parse(Console.ReadLine());


switch (sexo){
    case 1 :
        double pesoIdealHomem = (72.7*altura)-58;
        Console.WriteLine($"Seu peso ideal é {pesoIdealHomem}");
        break;

    case 2 :
        double pesoIdealMulher = (62.1*altura)-44.7;
        Console.WriteLine($"Seu peso ideal é {pesoIdealMulher}");
        break;
} */


// ******** Exercicio 26 ****

/* for (int i = 100; i > 0; i--) // valor inicial, condição de continuidade , incrimento/ decremento ( qual modificação quero fazer)
{
    Console.WriteLine(i);
} */

// ******** Exercicio 27 ****   ATENÇÃO

/* Console.WriteLine("Informe a quantidade de números que deseja processar:");
int quantidade = int.Parse(Console.ReadLine());

while(quantidade){

} */
 



// ******** Exercicio 28 ****

/* for (int i = 100; i < 200; i++){
    
    if(i%2 == 1){
        Console.WriteLine($"{i}");
    }
    
        
} */

// ******** Exercicio 29 ****

/* for (int i = 0; i < 2000; i++){
    
   
    Console.WriteLine(i+1);
        
} */

// ******** Exercicio 30 ****

/* Console.WriteLine("Informe um número para imprimir a tabuada dele: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine(numero*1);
Console.WriteLine(numero*2);
Console.WriteLine(numero*3);
Console.WriteLine(numero*4);
Console.WriteLine(numero*5);
Console.WriteLine(numero*6);
Console.WriteLine(numero*7);
Console.WriteLine(numero*8);
Console.WriteLine(numero*9);
Console.WriteLine(numero*10); */

// ******** Exercicio 31 ****

/* int somaPar = 0;
int somaImpar = 0;
int numero ;

Console.WriteLine("Digite uma sequência de números positivos(digite um número negativo para parar):");

while(true){
    Console.WriteLine("Digite um número:");
    numero = int.Parse(Console.ReadLine());

    if (numero < 0){
        break;
    }

    if (numero % 2 == 0 ){
        somaPar += numero;
        Console.WriteLine($"{numero} é PAR.");
    }
    
    else{
        somaImpar += numero;
        Console.WriteLine($"{numero} é ÍMPAR.");
    }

}
Console.WriteLine($"Soma dos números pares: {somaPar}");
Console.WriteLine($"Soma dos números ímpares: {somaImpar}"); */

// ******** Exercicio 32 ****

/* Console.WriteLine("Informe um número inteiro menor que 10 e maior que zero:");
int numero = int.Parse(Console.ReadLine());

if (numero <= 0 || numero >= 10){
    Console.WriteLine("Número inválido. O número deve ser menor que 10 e maior que zero.");
   
}

int contador = 0;
int somaQuadrado = 0; 

int numeroAtual = numero;

while(contador < 20){
    if(numeroAtual % 2 != 0 ){
        somaQuadrado += numeroAtual*numeroAtual;
        contador++;
    }
    numeroAtual++;
}

Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares a partir de {numero} é: {somaQuadrado}"); */

// ******** Exercicio 33 ****

/* int contadorAlunos = 0;
double somaNotas = 0.0;
string continuar;

Console.WriteLine("Digite o número de matrícula do aluno:");
string matricula  = Console.ReadLine(); 

Console.WriteLine("Digite a nota do aluno:");
double nota = double.Parse(Console.ReadLine());

while( nota < 0 || nota > 10){
    Console.WriteLine("Por favor, digite uma nota válida entre 0 e 10.");
    Console.Write("Digite a nota do aluno: ");
}

somaNotas += nota;
contadorAlunos++;

Console.WriteLine("Deseja inserir a nota de outro aluno? (s/n):");
continuar = Console.ReadLine();
Console.WriteLine();

while( continuar.ToLower()== "s");

if ( contadorAlunos > 0){
    double media = somaNotas/contadorAlunos;

    Console.WriteLine($"A média das notas dos {contadorAlunos} alunos é: {media:F2}");
}
else{
    Console.WriteLine("Nenhum aluno foi inserido. Não é possível calcular a média.");
} */

// ******** Exercicio 34 ****

/* int maior = 0;
int menor = 0;
int numero;
string continuar;

Console.WriteLine("Digite um conjunto de números positivos (digite um número negativo para parar):");

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());


if(numero >= 0){
    if(numero < menor){
        menor = numero;
    }
    if(numero > maior){
        maior = numero;
    }
    else{
        Console.WriteLine("Número negativo encontrado. Finalizando entrada de dados.");
    }
}else{
    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
}

while(numero>=0){
    Console.WriteLine($"O menor número digitado é: {menor}");
    Console.WriteLine($"O maior número digitado é: {maior}");

    break;
    
} */

// ******** Exercicio 35 ****

/* for(int i=1; i <= 100 ; i++){
    if(i % 10 == 0){
        Console.WriteLine($"{i} - Múltiplo de 10");
    }else{
        Console.WriteLine(i);
    }

} */

// ******** Exercicio 36 ****

/* const int quantidadeValores = 10; 

int maiorValor = 0;
int menorValor = 0;
int somaValores = 0;
int numero;

for(int contador = 1; contador <= quantidadeValores; contador++){
    Console.WriteLine($"Digite o {contador}º valor positivo:");
    numero = int.Parse(Console.ReadLine());

    while(numero<=0){
        Console.WriteLine("Valor inválido. Digite um número inteiro positivo.");
        Console.Write($"Digite o {contador}º valor positivo: ");
    }

    if (numero > maiorValor){
        maiorValor = numero;
     }
    if (numero < menorValor){
        menorValor = numero;
    }

    somaValores += numero ;
}

double media = (double)somaValores / quantidadeValores;

Console.WriteLine($"O maior valor digitado é: {maiorValor}");
Console.WriteLine($"O menor valor digitado é: {menorValor}");
Console.WriteLine($"A média dos valores digitados é: {media:F2}"); */

// ******** Exercicio 37 ****
/* string continuar;
do{

Console.WriteLine("Escolha uma das opções abaixo:");
Console.WriteLine("1-Adição");
Console.WriteLine("2-Subtração");
Console.WriteLine("3-Múltiplicação");
Console.WriteLine("4-Divisão");
Console.WriteLine("Opção:");
int opcao = int.Parse(Console.ReadLine());

if( opcao < 1 || opcao > 4){
    Console.WriteLine("Escolha uma opção válida de 1 a 4.");
    continuar = "s";
    continue;
}

Console.WriteLine("Digite o primeiro número:");
int primeiroNumero = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int segundoNumero = int.Parse(Console.ReadLine());


switch(opcao){
    case 1:
        int adicao = primeiroNumero + segundoNumero;
        Console.WriteLine($"A opção escolhida foi {opcao} e o resultado dela é {adicao}");
        break;  

    case 2:
        int subtracao = primeiroNumero - segundoNumero;
        Console.WriteLine($"A opção escolhida foi {opcao} e o resultado dela é {subtracao}");
        break;

    case 3:
        int multiplicacao = primeiroNumero * segundoNumero;
        Console.WriteLine($"A opção escolhida foi {opcao} e o resultado dela é {multiplicacao}");
        break;

    case 4:
         if (segundoNumero != 0) {
            double divisao = (double)primeiroNumero / segundoNumero;
            Console.WriteLine($"A opção escolhida foi {opcao} e o resultado dela é {divisao}");
        }else{
            Console.WriteLine("Erro: divisão por zero!");
        }
        break;
}   

Console.WriteLine("Deseja voltar ao menu inicial? (Digite S ou s para sim e n para não)):");
continuar = Console.ReadLine();
}while( continuar.ToLower() == "s" ); */


// ******** Exercicio 38 ****       

/* string continuar;
do{

Console.WriteLine("Informe o código do operário:");
string codOperario = Console.ReadLine();

Console.WriteLine("Informe o número de horas trabalhadas por ele:");
int horasTrabalhadas = int.Parse(Console.ReadLine());

double salario = horasTrabalhadas*10;

double horasExtra = 0;

if(horasTrabalhadas >50){
    int horasExtrasTrab = horasTrabalhadas-50;
    horasExtra = horasExtrasTrab*20;
}

double salarioFinal = salario + horasExtra;

Console.WriteLine($"Salário Total: R$ {salarioFinal}");
Console.WriteLine($"Salário com as horas extras: R$ {horasExtra}");

Console.WriteLine("Deseja encerrar o programa? (s/n):");
continuar = Console.ReadLine();

}while( continuar.ToLower() == "n" ); */


// ******** Exercicio 39 ****       

/* string continuar;
do{

    Console.WriteLine("Informe um número inteiro:");
    int numeroInt = int.Parse(Console.ReadLine());

    if (numeroInt % 2 == 0 ){
            Console.WriteLine($"{numeroInt} é PAR.");
    }else{
            Console.WriteLine($"{numeroInt} é ÍMPAR.");
    }

    if(numeroInt > 0){
        Console.WriteLine($"é positivo");
    }else if( numeroInt < 0){
        Console.WriteLine($"é negativo");
    }else{
        Console.WriteLine($"é Zero");
    }
    Console.WriteLine("Deseja encerrar o programa? (s/n):");
    continuar = Console.ReadLine();
}while( continuar.ToLower() == "n" ); */

// ******** Exercicio 40 **** 


/* string continuar;
do{

    Console.WriteLine("Informe o índice de poluição medido:");
    double indicePoluicao = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o índice de poluição medido:");
    double indicePoluicao = double.Parse(Console.ReadLine());

    if (indicePoluicao <= 0.5){
        Console.WriteLine($"Todos os grupos devem ser notificados para paralisar suas atividades.");
    } 
    else if( indicePoluicao >= 0.4){
        Console.WriteLine($"O 1º e 2º grupos de indústrias são intimados a suspender atividades.");
                
    }
    else if(indicePoluicao >= 0.3){
        Console.WriteLine($"O 1º grupo de indústrias é intimado a suspender atividades.");
                
    }
    else if(indicePoluicao >= 0.25){
        Console.WriteLine("Índice de poluição elevado, mas dentro do limite aceitável.");
    }
    else if( indicePoluicao >= 0.05){
        Console.WriteLine($"Índice de poluição normal.");
                 
    }else{
            Console.WriteLine($"Abaixo do aceitável.");
    }
  
    Console.WriteLine("Deseja encerrar o programa? (s/n):");
    continuar = Console.ReadLine();
}while( continuar.ToLower() == "n" ); */

// ******** Exercicio 41 ****

/* Console.WriteLine("Informe sua idade:");
int idade = int.Parse(Console.ReadLine());

while( idade >= 0 ){
   
    if ( idade >= 5 && idade <= 7){
        Console.WriteLine("Infantil A: 5 a 7 anos");
    break;
    }
    if ( idade >= 8 && idade <= 11){
        Console.WriteLine("Infantil B: 8 a 11 anos");
        break;
    }
    if ( idade >= 12 && idade <= 13){
        Console.WriteLine("Juvenil A: 12 a 13 anos");
        break;
    }
    if ( idade >= 14 && idade <= 17){
        Console.WriteLine("Juvenil B: 14 a 17 anos");
        break;
    }
    if ( idade >= 18 ){
        Console.WriteLine("Maiores de 18 anos");
        break;
    }

} */

// ******** Exercicio 42 ****
/* string continuar;

do{

    Console.WriteLine("Informe um número:");
    int numero = int.Parse(Console.ReadLine());

    if( numero == 0){
        Console.WriteLine($"Encerrado");
    }   
    else if (numero >= 1){
        Console.WriteLine($"é maior");
    }
    else if(numero < 1){
        Console.WriteLine($"é menor");
    }
    
    Console.WriteLine("Deseja digitar outro número? (s/n)");
    continuar = Console.ReadLine();
}while(continuar.ToLower() == "s"); */

// ******** Exercicio 43 ****  DUVIDA 

/* int quadrados = 64;
int graos = 0;

for (int i = 0; i < quadrados; i++){
    int graosNoQuadrado = 2*i;
    graos+=graosNoQuadrado;
}    
Console.WriteLine($"Total de grãos: {graos}");   */ 

// ******** Exercicio 44 ****  

/* string continuar;

do{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1-Conversão de Graus Celsius em Graus Fahrenheit");
    Console.WriteLine("2-Conversão de Graus Fahrenheit em Graus Celsius");
    Console.WriteLine("3-Peso ideal do homem");
    Console.WriteLine("4-Peso ideal da mulher");
    int opcao = int.Parse(Console.ReadLine());

    switch(opcao){
        case 1:
            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            double grauscelsius = double.Parse(Console.ReadLine());

            double grausfahrenheit = (grauscelsius * 9 / 5) + 32;

            Console.WriteLine($"{grauscelsius} graus Celsius equivalem a {grausfahrenheit} graus Fahrenheit.");

            break;

        case 2:

            Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{fahrenheit} graus Fahrenheit equivalem a {celsius} graus Celsius.");

            break;

        case 3:
            Console.WriteLine("Informe sua altura:");
            double alturaHomem = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu peso?");
            double pesoHomem = double.Parse(Console.ReadLine());

            double pesoIdealHomem = (72.7*alturaHomem)-58;

            if (pesoHomem < pesoIdealHomem){
                Console.WriteLine("Você está no peso ideal");
            }else{
                Console.WriteLine("Você está acima do peso ideal");
            }

            Console.WriteLine($"Seu peso ideal é {pesoIdealHomem}");
            break;

        case 4:
            Console.WriteLine("Informe sua altura:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu peso?");
            double pesoMulher = double.Parse(Console.ReadLine());


            double pesoIdealMulher = (62.1*altura)-44.7;

            if (pesoMulher < pesoIdealMulher){
                Console.WriteLine("Você está no peso ideal");
            }else{
                Console.WriteLine("Você está acima do peso ideal");
            }

            Console.WriteLine($"Seu peso ideal é {pesoIdealMulher}");
            break;


    }

    Console.WriteLine("Deseja encerrar o programa? (s/n)");
    continuar = Console.ReadLine();
}while(continuar.ToLower() == "n");  */


// ******** Exercicio 45 ****

/* var array = new Stack<int>();

array.Push(0);
array.Push(1);
array.Push(2);
array.Push(3);

foreach (var item in array){
    Console.WriteLine(item);    
}
 */




    

    
   

