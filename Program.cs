using DesafioPOO.Models;

Console.WriteLine("Teste Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTeste Smartphone Iphone:");
Smartphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");