//Faça um programa que leia o peso, a altura e o sexo de uma pessoa e calcule o seu IMC, informando a situação da pessoa: sobrepeso, .... assim vai

//Início
Console.WriteLine("--- Calculadora de IMC ---\n");

//Declaração de variáveis
float imc, peso, peso_aux, altura, altura_aux;

//Entrada de Dados e Operações
Console.WriteLine("Digite um valor POSITIVO e DIFERENTE DE ZERO");
Console.WriteLine("Para números decimais, USE A VÍRGULA\n");

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

imc = peso_aux / (altura_aux * altura_aux);

if (imc <= 18.5)
{
    Console.WriteLine($"\nIMC: {imc}");
    Console.WriteLine("Magreza");
}
else
{
    if (imc >= 18.6 && imc <= 24.9)
    {
        Console.WriteLine($"\nIMC: {imc}");
        Console.WriteLine("Peso Normal");
    }
    else
    {
        if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine($"\nIMC: {imc}");
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine($"\nIMC: {imc}");
                Console.WriteLine("Obesidade de grau I");
            }
            else
            {
                if (imc >= 35 && imc <= 39.9)
                {
                    Console.WriteLine($"\nIMC: {imc}");
                    Console.WriteLine("Obesidade de grau II");
                }
                else
                {
                    Console.WriteLine($"\nIMC: {imc}");
                    Console.WriteLine("Obesidade de grau III");
                }
            }
        }
    }
}

//Final do Programa
Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();