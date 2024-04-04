using Calculadora.ControleDeFluxo;

namespace Calculadora.OperacoesMatematicas
{
    public class Soma
    {
        public static void Somar()
        {
            try
            {
                Switch.SwitchSoma();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas o número da opção. Aguarde essa mensagem sair para digitar novamente.");
                Thread.Sleep(4000);
                Somar();
            }
        }
    }
}