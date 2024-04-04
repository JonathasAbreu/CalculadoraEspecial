using Calculadora.Menus;
using Calculadora.OperacoesMatematicas.OperacoesQuantidade;
using Calculadora.ControleDeFluxo;

namespace Calculadora.OperacoesMatematicas
{
    public class Divisao
    {
        public static void Dividir()
        {
            try
            {
                MenuQuantidade.ExibirMenuQuantidade();
                
                Switch.SwitchDivisao();                
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas o número da opção. Aguarde essa mensagem sair para digitar novamente.");
                Thread.Sleep(4000);
                Dividir();
            }
        }
    }
}
