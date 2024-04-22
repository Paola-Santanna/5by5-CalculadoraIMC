Console.WriteLine("--- Calculadora de IMC ---\n");

float imc, peso, peso_aux, altura, altura_aux;
char sexo;
string opcao_sexo = " ";

//Entrada de Dados e Operações
Console.WriteLine("Digite a letra correspondente ao sexo escolhido:");
Console.WriteLine("f -> Feminino \nm -> Masculino \no -> Outro \np ->Prefiro não Informar");

do
{
    Console.Write("Sua resposta: ");
    sexo = char.Parse(Console.ReadLine());

    if (sexo == 'f' || sexo == 'F')
    {
        opcao_sexo = "Feminino";
    }
    else
    {
        if (sexo == 'm' || sexo == 'M')
        {
            opcao_sexo = "Masculino";
        }
        else
        {
            if (sexo == 'o' || sexo == 'O')
            {
                opcao_sexo = "Outro";
            }
            else
            {
                if (sexo == 'p' || sexo == 'P')
                {
                    opcao_sexo = "Prefiro não Informar";
                }
                else
                {
                    Console.WriteLine("\nOpção Inválida\n");
                }
            }
        }
    }

} while (sexo != 'f' && sexo != 'F' && sexo != 'm' && sexo != 'M' && sexo != 'o' && sexo != 'O' && sexo != 'p' && sexo != 'P');

Console.WriteLine("\nDigite um valor MAIOR que ZERO");
Console.WriteLine("Para números decimais, USE A VÍRGULA\n");

do
{
    Console.Write("Peso, em kg: ");
    peso = float.Parse(Console.ReadLine());
    peso_aux = peso;

    if (peso_aux <= 0)
        Console.WriteLine("\nNúmero Inválido\n");

} while (peso_aux <= 0);

do
{
    Console.Write("Altura, em metros: ");
    altura = float.Parse(Console.ReadLine());
    altura_aux = altura;

    if (altura_aux <= 0)
        Console.WriteLine("\nNúmero Inválido\n");

} while (altura_aux <= 0);

imc = peso_aux / (altura_aux * altura_aux);

if (imc <= 18.5)
{
    Console.WriteLine($"\nSexo: {opcao_sexo}");
    Console.WriteLine($"IMC: {imc:0.00}");
    Console.WriteLine("Magreza");
}
else
{
    if (imc >= 18.6 && imc <= 24.9)
    {
        Console.WriteLine($"\nSexo: {opcao_sexo}");
        Console.WriteLine($"IMC: {imc:0.00}");
        Console.WriteLine("Peso Normal");
    }
    else
    {
        if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine($"\nSexo: {opcao_sexo}");
            Console.WriteLine($"IMC: {imc:0.00}");
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine($"\nSexo: {opcao_sexo}");
                Console.WriteLine($"IMC: {imc:0.00}");
                Console.WriteLine("Obesidade de grau I");
            }
            else
            {
                if (imc >= 35 && imc <= 39.9)
                {
                    Console.WriteLine($"\nSexo: {opcao_sexo}");
                    Console.WriteLine($"IMC: {imc:0.00}");
                    Console.WriteLine("Obesidade de grau II");
                }
                else
                {
                    Console.WriteLine($"\nSexo: {opcao_sexo}");
                    Console.WriteLine($"IMC: {imc:0.00}");
                    Console.WriteLine("Obesidade de grau III");
                }
            }
        }
    }
}

//Final do Programa
Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();