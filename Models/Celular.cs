namespace Celulares.Models
{
    public abstract class Celular
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        protected Celular(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine($"{Marca} {Modelo} está ligando...");
        }

        public void Desligar()
        {
            Console.WriteLine($"{Marca} {Modelo} está desligando...");
        }

        public abstract void EnviarMensagem(string mensagem);
    }
}
