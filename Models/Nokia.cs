namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Passa os parâmetros recebidos nessa classe para a classe pai
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            if(VerificarAplicativo(nomeApp))
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
            }
        }

        // Método selado, ele não pode ser sobrescrito nas classes filhas
        public sealed override void ExibirConfiguracoes()
        {
            Console.WriteLine($"As configurações do Nokia {Modelo} são: {Memoria} gigas de armazenamento e IMEI: {IMEI}");
        }
    }
}