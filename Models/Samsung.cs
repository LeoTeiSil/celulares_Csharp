namespace Celulares.Models
{
    public class Samsung : Celular
    {
        public Samsung(string modelo) : base("Samsung", modelo) { }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Samsung {Modelo} envia a mensagem: {mensagem}");
        }

        public void GalaxyFeature()
        {
            Console.WriteLine($"{Marca} {Modelo} ativou recurso exclusivo Galaxy!");
        }
    }
}
