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
