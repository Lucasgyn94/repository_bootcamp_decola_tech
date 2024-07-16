namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        // Declarando Delegate
        public delegate void DelegateCalculadora();
        // Declarar evento
        public static event DelegateCalculadora EventoCalculadora;
        
        // Metódo Somar
        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora(); // ele vai executar todos os métodos que foram inscritos no EventoCalculadora do static event
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }

    }
}