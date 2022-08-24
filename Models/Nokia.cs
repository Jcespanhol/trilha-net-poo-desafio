using DesafioPOO.Models;

namespace DesafioPOO.Models

{
   
    public class Nokia : Smartphone

    {        
        public  Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
      
        public override void Apresentar()
        {
            Console.WriteLine($"O celular do numero {Numero}, e modelo {Modelo} de memoria {Memoria} está ativo com o imei {Imei}");
        }
     

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}");
        }
    }
}