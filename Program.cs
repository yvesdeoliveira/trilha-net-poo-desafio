using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "3310", imei: 01010101010, memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp Business");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123789", modelo: "Iphone 15 Pro Max Cabuloso", imei: 1010101010101010, memoria: 512 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp Business");