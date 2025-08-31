using Celulares.Models;

class Program
{
    static void Main(string[] args)
    {
        Celular meuSamsung = new Samsung("Galaxy S23");
        Celular meuIphone = new Apple("iPhone 14");

        meuSamsung.Ligar();
        meuSamsung.EnviarMensagem("Olá, tudo bem?");
        meuSamsung.Desligar();

        Console.WriteLine();

        meuIphone.Ligar();
        meuIphone.EnviarMensagem("Oi, como vai?");
        meuIphone.Desligar();

        Console.WriteLine();

        ((Samsung)meuSamsung).GalaxyFeature();
        ((Apple)meuIphone).FaceID();
    }
}
