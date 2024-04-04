using Calculadora.Menus;
using Calculadora.ControleDeFluxo;

namespace Calculadora.OperacoesMatematicas.OperacoesQuantidade
{
    public class QuantidadeMultiplicacao
    {
        public static void DoisNumeros()
        {
            try
            {
                Console.WriteLine("Primeiro valor:");
                decimal valor1 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Segundo valor: ");
                decimal valor2 = decimal.Parse(Console.ReadLine());
                decimal multiplicacao = valor1 * valor2;
                Console.Clear();
                Console.WriteLine($"O resultado da sua multiplicação foi: {multiplicacao:F2}\n");
                Thread.Sleep(2000);

                Console.Clear();

                Switch.EscolhaFinal();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas valores numéricos. Vontando ao menu anterior.");
                Thread.Sleep(2000);
                Multiplicacao.Multiplicar();
            }
        }

        public static void TresNumeros()
        {
            try
            {
                Console.WriteLine("Primeiro valor:");
                decimal valor1 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Segundo valor: ");
                decimal valor2 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Terceiro valor: ");
                decimal valor3 = decimal.Parse(Console.ReadLine());
                decimal multiplicacao = valor1 * valor2 * valor3;
                Console.Clear();
                Console.WriteLine($"O resultado da sua multiplicação foi: {multiplicacao:F2}\n");
                Thread.Sleep(2000);

                Console.Clear();

                Switch.EscolhaFinal();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas valores numéricos. Vontando ao menu anterior.");
                Thread.Sleep(2000);
                Multiplicacao.Multiplicar();
            }
        }

        public static void QuatroNumeros()
        {
            try
            {
                Console.WriteLine("Primeiro valor:");
                decimal valor1 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Segundo valor: ");
                decimal valor2 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Terceiro valor: ");
                decimal valor3 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Quarto valor: ");
                decimal valor4 = decimal.Parse(Console.ReadLine());
                decimal multiplicacao = valor1 * valor2 * valor3 * valor4;
                Console.Clear();
                Console.WriteLine($"O resultado da sua multiplicação foi: {multiplicacao:F2}\n");
                Thread.Sleep(2000);

                Console.Clear();

                Switch.EscolhaFinal();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas valores numéricos. Vontando ao menu anterior.");
                Thread.Sleep(2000);
                Multiplicacao.Multiplicar();
            }
        }

        public static void CincoNumeros()
        {
            try
            {
                Console.WriteLine("Primeiro valor:");
                decimal valor1 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Segundo valor: ");
                decimal valor2 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Terceiro valor: ");
                decimal valor3 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Quarto valor: ");
                decimal valor4 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Quinto valor: ");
                decimal valor5 = decimal.Parse(Console.ReadLine());
                decimal multiplicacao = valor1 * valor2 * valor3 * valor4 * valor5;
                Console.Clear();
                Console.WriteLine($"O resultado da sua multiplicação foi: {multiplicacao:F2}\n");
                Thread.Sleep(2000);

                Console.Clear();

                Switch.EscolhaFinal();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas valores numéricos. Vontando ao menu anterior.");
                Thread.Sleep(2000);
                Multiplicacao.Multiplicar();
            }
        }

        public static void Sair()
        {            
            MenuPrincipal.MenuInicial();
        }
    }
}