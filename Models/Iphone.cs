namespace DesafioPOO.Models
{
    // IMPLEMENTADO!
    public class Iphone : Smartphone
    {
          public string SistemaOperacional { get; set; }
           public Iphone(string numero, string modelo, string imei, int memoria, string sistemaOperacional)
            : base(numero, modelo, imei, memoria)
        {
            SistemaOperacional = sistemaOperacional;
        }
        public override void Exibicao()
        {
            Console.WriteLine("Aparelho Iphone: ");
        }
    public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
             Console.WriteLine($"Aplicativo instalado!");
        }
        // IMPLEMENTADO !
    }
}