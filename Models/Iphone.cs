namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Passa os parâmetros recebidos nessa classe para a classe pai
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }
    }
}