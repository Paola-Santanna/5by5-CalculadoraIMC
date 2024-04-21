//Faça um programa que leia o peso, a altura e o sexo de uma pessoa e calcule o seu IMC, informando a situação da pessoa: sobrepeso, .... assim vai

//Início
Console.WriteLine("--- Calculadora de IMC ---\n");

//Declaração de variáveis
float imc, peso, peso_aux, altura, altura_aux;

//Entrada de Dados e Operações
Console.WriteLine("Digite um valor POSITIVO e DIFERENTE DE ZERO\n");

do
{
    Console.Write("Peso, em kg: ");
    peso = float.Parse(Console.ReadLine());
    peso_aux = peso;

    if (peso_aux == 0 || peso_aux < 0)
        Console.WriteLine("\nNúmero Inválido\n");

} while (peso_aux == 0 || peso_aux < 0);

do
{
    Console.Write("Altura, em metros: ");
    altura = float.Parse(Console.ReadLine());
    altura_aux = altura;

    if (altura_aux == 0 || altura_aux < 0)
        Console.WriteLine("\nNúmero Inválido\n");

} while (altura_aux == 0 || altura_aux < 0);

//Final do Programa
Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();