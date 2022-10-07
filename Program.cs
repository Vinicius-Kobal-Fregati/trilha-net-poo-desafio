using DesafioPOO.Models;

for (int contador = 0; contador < 2; contador++)
{
    Console.Clear();
    Console.WriteLine("Smartphone Nokia:");
    Smartphone nokia = new Nokia(numero: "99800-1234", modelo: "NK025", imei: "341256-87-312564-9", memoria: 64);
    Console.WriteLine(nokia.Ligar("Ronaldo"));
    nokia.InstalarAplicativo("Whatsapp");
    nokia.ExibirConfiguracoes();

    Console.Write("\n");

    Console.WriteLine("Smartphone iPhone:");
    Smartphone iphone = new Iphone(numero: "654321", modelo: "13", imei: "222222222", memoria: 128);
    iphone.ReceberLigacao();
    Console.WriteLine(iphone.Ligar());
    iphone.InstalarAplicativo("Telegram");
    iphone.ExibirConfiguracoes();

    TorreTelefonia.AlternarSinal();
    Console.WriteLine("Agora, os processos serão repetidos " + (TorreTelefonia.VerificarSinal() ? "com " : "sem ") +
                      "sinal, por favor, tecle enter para continuar");
    Console.ReadLine();
}