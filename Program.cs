using DesafioPOO.Models;
using DesafioPOO;

Console.WriteLine("SmartPhone Nokia:");
Smartphone nokia = new Nokia(numero: "147589", modelo: "Nokia AA", imei: "01020301", memoria: 120);

nokia.Apresentar();
nokia.Ligar();
nokia.InstalarAplicativo("Google");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone:");
Smartphone iphone = new Iphone(numero: "1474789", modelo: "Iphone ZY", imei: "01020301", memoria: 120);

iphone.Apresentar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Java");




