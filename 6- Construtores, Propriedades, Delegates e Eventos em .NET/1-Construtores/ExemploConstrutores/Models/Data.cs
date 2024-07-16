namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }
        
        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }
        // 2- Maneira mais fácil de trabalhar com propriedades
        // Propriedade (prop) com validação
        public int Mes
        {
            get 
            {
                return this.mes;
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }

        // Propriedade (prop)
        // public int Mes {get; set;}

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mês inválido");
            }
        }
    }
}