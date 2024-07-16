namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X {get; set; }
        public int Y {get; set;}

        public Matematica (int x, int y)
        {
            X = x;
            Y = y;
            
            Calculadora.EventoCalculadora += EventHandler; // Se eu comentar esse codigo, a calculadora deixara de ter inscrito
        }
        
        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        // Criando metodo que quero que se inscreva no meu evento
        public void EventHandler()
        {
            System.Console.WriteLine("Método executado");
        }
    }   
}