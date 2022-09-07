/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("AVISO: O produto -4 * a * c tem que ser menor que o valor b na fórmula de delta, caso o contrário retornará o resultado NaN");
      
      Console.WriteLine("Digite o valor a: ");
      double valorA = double.Parse(Console.ReadLine());
      
      Console.WriteLine("Digite o valor b: ");
      double valorB = double.Parse(Console.ReadLine());
      
      Console.WriteLine("Digite o valor c: ");
      double valorC = double.Parse(Console.ReadLine());
      
      double delta = valorB * valorB - 4 * valorA * valorC;
      
      double a1 = -valorB + Math.Sqrt(delta) / 2 * valorA;
      double a2 = -valorB - Math.Sqrt(delta) / 2 * valorA;
      
      Console.WriteLine("O valor a1 vale " + a1 + ". O valor a2 vale " + a2);
  }
}


