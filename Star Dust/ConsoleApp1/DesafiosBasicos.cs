// 1 QUESTÃO - Você receberá dois valores inteiros. Faça a leitura e em seguida calcule o produto entre estes dois valores
// Atribua esta operação à variável PROD, mostrando esta de acordo com a mensagem de saída esperada (exemplo abaixo).

// Console.Write("Digite um número : ");
// nt a = Convert.ToInt16(Console.ReadLine());

// Console.Write("Digite um número : ");
// int b = Convert.ToInt16(Console.ReadLine());

// int PROD = a*b;

// Console.WriteLine($"Produto : {PROD}");

// ----------------------------------------------------------------------------------------------------------------------


// 2 QUESTÃO - A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000),representando a quantidade de números na lista de Pink.
// A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando os números da lista de Pink.

// Console.Write("Quantos numeros terá na lista: ");
// int qtd = Convert.ToInt16(Console.ReadLine());

// Console.Write("Escreva os números da lista : ");
// string nums = Console.ReadLine();
// string[] num = nums.Split(" ");

// if (num.Length != qtd){
//   Console.Write("A quantidade de números não correspondeu a quantidade fornecida");
// }
// else{
//     int multiplo2 = 0;
//     int multiplo3 = 0;
//     int multiplo4 = 0;
//     int multiplo5 = 0;

//     int[] listaCerta = new int[qtd];

//     for (int i=0;i<qtd;i++){
        
//         listaCerta[i] = Convert.ToInt16(num[i]);
//     }

//     foreach(int nume in listaCerta){
//         if(nume%2 == 0 )
//         {
//             multiplo2+=1;
//         }
//         if(nume%3 == 0 )
//         {
//             multiplo3+=1;
//         }
//         if(nume%4 == 0 )
//         {
//             multiplo4+=1;
//         }
//         if(nume%5 == 0 )
//         {
//             multiplo5+=1;
//         }
//     }
//         Console.WriteLine($"Multiplos de 2 : {multiplo2}");
//         Console.WriteLine($"Multiplos de 3 : {multiplo3}");
//         Console.WriteLine($"Multiplos de 4 : {multiplo4}");
//         Console.WriteLine($"Multiplos de 5 : {multiplo5}");

    
// }


// ----------------------------------------------------------------------------------------------------------------------


// 3 QUESTÃO - Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
// A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

// const double pi = 3.14159;

// Console.Write("Valor do raio : ");
// double raio = Convert.ToDouble(Console.ReadLine());

// double volume = 4/3.0*pi*Math.Pow(raio,3);
// double valorFinal = Math.Round(volume,3);

// Console.Write($"O volume é : {valorFinal}");
