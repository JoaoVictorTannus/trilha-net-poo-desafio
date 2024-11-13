namespace DesafioPOO.Models
{
     // IMPLEMENTADO!
    public class Nokia : Smartphone
    {
        public string SistemaOperacional { get; set; }
        public Nokia(string numero, string modelo, string imei, int memoria, string sistemaOperacional)
            : base(numero, modelo, imei, memoria)
        {
            SistemaOperacional = sistemaOperacional;
        }
        public override void Exibicao()
        {
            Console.WriteLine("Aparelho Nokia: ");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
             Console.WriteLine($"Aplicativo instalado!");
        }
         // IMPLEMENTADO!
    }
}