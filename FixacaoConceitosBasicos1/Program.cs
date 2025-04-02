
using System;
using FixacaoConceitosBasicos1.Model;



bool saida = true; 
while (saida)
{
    try
    {
        Console.WriteLine("""
            Menu:
            [0] - Sair
            [1] - Somar dois números
            [2] - Converter metros para milímetros
            
            """
            );

        Console.WriteLine("Escolha uma das opções: ");
        int opcao = int.Parse(Console.ReadLine());
        switch(opcao){
            case 0:
                saida = false;
                break;
            case 1:
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nInforme o primeiro valor: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nInforme o segundo valor: ");
                        int num2 = int.Parse(Console.ReadLine());
                        SomaDoisNumeros somador = new SomaDoisNumeros();
                        Console.WriteLine($"\nA soma dos valores é: {somador.Somar(num1, num2)}");
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nPor favor informe um valor válido\n");
                    }
                }
                break;
            case 2:
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Informe o valor em metros: ");
                        double metros = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor convertido para milimetros é: {MetrosMilimetros.Converter(metros)}\n");
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nPor favor informe um valor válido\n");
                    }
                }
                break;

        }

            
    }
    catch (Exception)
    {
        Console.WriteLine("\nPor favor informe um valor válido");
    }
}
