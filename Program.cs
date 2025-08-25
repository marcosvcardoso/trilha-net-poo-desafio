using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987654321", modelo: "Modelo A", imei: "01011020101", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("zap");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "66666666", modelo: "b", imei: "55555555555", memoria: 8);
iphone.Ligar();
nokia.InstalarAplicativo("insta");
