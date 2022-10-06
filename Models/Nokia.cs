namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Passa os parâmetros recebidos nessa classe para a classe pai
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
        }
    }
}