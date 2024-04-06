using CalculadoraEspecial.ControlesDeFluxo;

namespace Calculadora.OperacoesMatematicas
{
    public class Divisao
    {
        public static void Dividir()
        {
            try
            {   
                SwitchDivisao.Divisao();               
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
