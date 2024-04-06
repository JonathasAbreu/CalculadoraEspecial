using Calculadora.ControleDeFluxo;

namespace CalculadoraEspecial
{
    public class OpcoesDeCalculo
    {
        public static decimal ComDoisNumeros(string mensagem)
        {
            Console.WriteLine(mensagem);
            return decimal.Parse(Console.ReadLine());            
        }
    }
    public class Valores
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
        public decimal Valor3 { get; set; }
        public decimal Valor4 { get; set; }
        public decimal Valor5 { get; set; }
    }
}

//     public static void ComTresNumeros()
//     {
//         try
//         {
//             Console.WriteLine("Primeiro valor:");
//             decimal valor1 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Segundo valor: ");
//             decimal valor2 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Terceiro valor: ");
//             decimal valor3 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Quarto valor: ");
//             decimal valor4 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Quinto valor: ");
//             decimal valor5 = decimal.Parse(Console.ReadLine());
//             decimal divisao = valor1 / valor2 / valor3 / valor4 / valor5;
//             Console.Clear();
//             Console.WriteLine($"O resultado da sua divisão foi: {divisao:F2}\n");
//             Thread.Sleep(2000);

//             Console.Clear();

//             SwitchEncerramento.Final();
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("\nDigite apenas valores numéricos. Voltando ao menu anterior.");
//             Thread.Sleep(2000);
//             Divisao.Dividir();
//         }
//     }

//     public static void ComQuatroNumeros()
//     {
//         try
//         {
//             Console.WriteLine("Primeiro valor:");
//             decimal valor1 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Segundo valor: ");
//             decimal valor2 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Terceiro valor: ");
//             decimal valor3 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Quarto valor: ");
//             decimal valor4 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Quinto valor: ");
//             decimal valor5 = decimal.Parse(Console.ReadLine());
//             decimal divisao = valor1 / valor2 / valor3 / valor4 / valor5;
//             Console.Clear();
//             Console.WriteLine($"O resultado da sua divisão foi: {divisao:F2}\n");
//             Thread.Sleep(2000);

//             Console.Clear();

//             SwitchEncerramento.Final();
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("\nDigite apenas valores numéricos. Voltando ao menu anterior.");
//             Thread.Sleep(2000);
//             Divisao.Dividir();
//         }
//     }

//     public static void ComCincoNumeros()
//     {
//         try
//         {
//             Console.WriteLine("Primeiro valor:");
//             decimal valor1 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Segundo valor: ");
//             decimal valor2 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Terceiro valor: ");
//             decimal valor3 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Quarto valor: ");
//             decimal valor4 = decimal.Parse(Console.ReadLine());
//             Console.Clear();
//             Console.WriteLine("Quinto valor: ");
//             decimal valor5 = decimal.Parse(Console.ReadLine());
//             decimal divisao = valor1 / valor2 / valor3 / valor4 / valor5;
//             Console.Clear();
//             Console.WriteLine($"O resultado da sua divisão foi: {divisao:F2}\n");
//             Thread.Sleep(2000);

//             Console.Clear();

//             SwitchEncerramento.Final();
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("\nDigite apenas valores numéricos. Voltando ao menu anterior.");
//             Thread.Sleep(2000);
//             Divisao.Dividir();
//         }
//     }
// }
// }