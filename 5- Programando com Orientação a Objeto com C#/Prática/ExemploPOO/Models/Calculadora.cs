using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        // Exemplo de polimorfismo em tempo de compilação
        public int Somar (int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Dividir(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}