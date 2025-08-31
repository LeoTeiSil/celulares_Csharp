namespace Celulares.Models
{
    public class Apple : Celular
    {
        public Apple(string modelo) : base("Apple", modelo) { }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Apple {Modelo} envia a mensagem via iMessage: {mensagem}");
        }

        public void FaceID()
        {
            Console.WriteLine($"{Marca} {Modelo} reconheceu o rosto do usuário!");
        }
    }
}
