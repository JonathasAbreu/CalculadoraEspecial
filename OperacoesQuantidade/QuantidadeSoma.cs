using Calculadora.Menus;
using Calculadora.ControleDeFluxo;

namespace Calculadora.OperacoesMatematicas.OperacoesQuantidade
{
    public class QuantidadeSoma
    {
        public static decimal LerValorDecimal()
        {
            Console.WriteLine("Digite o valor: ");
            return decimal.Parse(Console.ReadLine());
        }

        public static decimal SomarSequencial(params decimal[] valores)
        {
            decimal resultado = valores[0];
            for (int i = 1; i < valores.Length; i++)
            {
                resultado += valores[i];
            }
            return resultado;
        }

        public static void DoisNumeros()
        {
            try
            {
                decimal valor1 = LerValorDecimal();
                Console.Clear();
                decimal valor2 = LerValorDecimal();

                decimal divisao = SomarSequencial(valor1, valor2);

                Console.Clear();
                Console.WriteLine($"O resultado da sua Soma foi: {divisao:F2}\n");
                Console.WriteLine("Aperte qualquer tecla para avançar.");
                Console.ReadLine();

                Console.Clear();

                SwitchEncerramento.Final();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas valores numéricos. Voltando ao menu anterior.");
                Thread.Sleep(2000);
                Divisao.Dividir();
            }
        }

        public static void TresNumeros()
        {
            try
            {
                decimal valor1 = LerValorDecimal();
                Console.Clear();
                decimal valor2 = LerValorDecimal();
                Console.Clear();
                decimal valor3 = LerValorDecimal();

                decimal divisao = SomarSequencial(valor1, valor2, valor3);

                Console.Clear();
                Console.WriteLine($"O resultado da sua Soma foi: {divisao:F2}\n");
                Console.WriteLine("Aperte qualquer tecla para avançar.");
                Console.ReadLine();

                Console.Clear();

                SwitchEncerramento.Final();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas valores numéricos. Voltando ao menu anterior.");
                Thread.Sleep(2000);
                Divisao.Dividir();
            }
        }

        public static void QuatroNumeros()
        {
            try
            {
                decimal valor1 = LerValorDecimal();
                Console.Clear();
                decimal valor2 = LerValorDecimal();
                Console.Clear();
                decimal valor3 = LerValorDecimal();
                Console.Clear();
                decimal valor4 = LerValorDecimal();

                decimal divisao = SomarSequencial(valor1, valor2);

                Console.Clear();
                Console.WriteLine($"O resultado da sua Soma foi: {divisao:F2}\n");
                Console.WriteLine("Aperte qualquer tecla para avançar.");
                Console.ReadLine();

                Console.Clear();

                SwitchEncerramento.Final();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas valores numéricos. Voltando ao menu anterior.");
                Thread.Sleep(2000);
                Divisao.Dividir();
            }
        }

        public static void CincoNumeros()
        {
            try
            {
                decimal valor1 = LerValorDecimal();
                Console.Clear();
                decimal valor2 = LerValorDecimal();
                Console.Clear();
                decimal valor3 = LerValorDecimal();
                Console.Clear();
                decimal valor4 = LerValorDecimal();
                Console.Clear();
                decimal valor5 = LerValorDecimal();

                decimal divisao = SomarSequencial(valor1, valor2, valor3);

                Console.Clear();
                Console.WriteLine($"O resultado da sua Soma foi: {divisao:F2}\n");
                Console.WriteLine("Aperte qualquer tecla para avançar.");
                Console.ReadLine();

                Console.Clear();

                SwitchEncerramento.Final();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas valores numéricos. Voltando ao menu anterior.");
                Thread.Sleep(2000);
                Divisao.Dividir();
            }
        }

        public static void VoltarMenuAnterior()
        {
            MenuPrincipal.MenuInicial();
        }
    }
}
