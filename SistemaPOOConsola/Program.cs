using System;
using System.Collections.Generic;
using LogicaConsola;

namespace SistemaPOOConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instancias de Tablet
            Tablet tablet1 = new Tablet("Mini 5", "rojo", "iPad ", "64GB", "8GB", 699);
            Tablet tablet2 = new Tablet("Tab A ", "verde", "Galaxy", "84GB", "16GB", 899);
            Tablet tablet3 = new Tablet("MediaPad T3 10 ", "Negra", "84GB", "64GB", "8GB", 1690);
            Tablet tablet4 = new Tablet("Tab E ", "Blanco", "Galaxy", "84GB", "16GB", 980);

            //Instancias de Laptop
            Laptop laptop1 = new Laptop("Zbook 17", "Negra", "HP ", "2TB", "10th", 1023);
            Laptop laptop2 = new Laptop("Omen", "Azul", "HP", "2TB", "6th", 1200);
            Laptop laptop3 = new Laptop("XPS 15 17", "Negra", "Dell ", "2TB", "10th", 1103);
            Laptop laptop4 = new Laptop("Zbook 17", "Azul", "HP", "2TB", "6th", 1700);

            //Instancias de Smartphone
            Smartphone smartphone1 = new Smartphone("S6 ", "Blanco", "Xiaomi", "64GB", "8GB", 800);
            Smartphone smartphone2 = new Smartphone("s10 plus", "Negro", "Samsung", "120GB", "12GB", 900);
            Smartphone smartphone3 = new Smartphone("y9 ", "Blanco", "Huawei", "32GB", "12GB", 786);
            Smartphone smartphone4 = new Smartphone("y7 plus", "Negro", "Huawei", "64GB", "16GB", 1203);

            //Instancias de Licuadora
            Licuadora licuadora1 = new Licuadora("AE 3532 ", "Clatronic ", "Gris", 63);
            Licuadora licuadora2 = new Licuadora("JU200045 ", "Moulinex Vitae", "Plomo", 48);
            Licuadora licuadora3 = new Licuadora("Po1542 ", "Oster ", "Blanco", 300);
            Licuadora licuadora4 = new Licuadora("RI5463 ", "Oster Pro", "Negro", 500);

            //Instancias de Microonda
            Microonda microonda1 = new Microonda("mg 203", "Samsung.", "Plomo", 350);
            Microonda microonda2 = new Microonda("lix 93", "Whirlpool", "Plateado", 120);
            Microonda microonda3 = new Microonda("Daewoo", " KOG-837RS.", "Negro", 350);
            Microonda microonda4 = new Microonda("CMXG25DCS", "Candy ", "Gris", 120);

            //Instancias de Batidora
            Batidora batidora1 = new Batidora("HDP408WH", "Kenwood ", "Blanco", 88);
            Batidora batidora2 = new Batidora("5KSM150PSEMS", "Kitchen", "Verde", 100);
            Batidora batidora3 = new Batidora("KM 398 CB", "Bomann  ", "Negra", 130);
            Batidora batidora4 = new Batidora("5KPM5EER", "KitchenAid ", "Roja", 98);

            Cliente recomendacionPersona1 = new Cliente
            {
                Nombre = "Andy de la Cruz",
                TabletComprada = tablet1,
                MicroondaComprada = microonda2,
                BatidoraComprada = batidora2
            };
            Cliente recomendacionPersona2 = new Cliente
            {
                Nombre = "Jhordan Yanez",
                BatidoraComprada = batidora2,
                LicuadoraComprada = licuadora2,
                SmartphoneComprada = smartphone1
            };
            Cliente recomendacionPersona3 = new Cliente
            {
                Nombre = "Catalina Mercedes",
                LaptopComprada = laptop1,
                BatidoraComprada = batidora1,
                MicroondaComprada = microonda2
            };

            Cliente recomendacionPersona4 = new Cliente
            {
                Nombre = "Nelson Cabrera",
                LaptopComprada = laptop1,
                BatidoraComprada = batidora4,
                MicroondaComprada = microonda3
            };

            Cliente recomendacionPersona5 = new Cliente
            {
                Nombre = "Maria  Diaz",
                LicuadoraComprada = licuadora4,
                BatidoraComprada = batidora4,
                MicroondaComprada = microonda3
            };

            Cliente recomendacionPersona6 = new Cliente
            {
                Nombre = "Guido Cabrera",
                LaptopComprada = laptop4,
                BatidoraComprada = batidora3,
                SmartphoneComprada = smartphone4
            };


            List<ArticuloDeEstudio> ListaDeArticulosEstudio = new List<ArticuloDeEstudio>();
            //Tablet
            ListaDeArticulosEstudio.Add(tablet1);
            ListaDeArticulosEstudio.Add(tablet2);
            ListaDeArticulosEstudio.Add(tablet3);
            ListaDeArticulosEstudio.Add(tablet4);
            //Laptop
            ListaDeArticulosEstudio.Add(laptop1);
            ListaDeArticulosEstudio.Add(laptop2);
            ListaDeArticulosEstudio.Add(laptop3);
            ListaDeArticulosEstudio.Add(laptop4);
            //SmartPhone
            ListaDeArticulosEstudio.Add(smartphone1);
            ListaDeArticulosEstudio.Add(smartphone2);
            ListaDeArticulosEstudio.Add(smartphone3);
            ListaDeArticulosEstudio.Add(smartphone4);

            List<ArticuloDeCocina> ListaDeArticuloCocina = new List<ArticuloDeCocina>();
            //Licuadora
            ListaDeArticuloCocina.Add(licuadora1);
            ListaDeArticuloCocina.Add(licuadora2);
            ListaDeArticuloCocina.Add(licuadora3);
            ListaDeArticuloCocina.Add(licuadora4);
            //Microonda
            ListaDeArticuloCocina.Add(microonda1);
            ListaDeArticuloCocina.Add(microonda2);
            ListaDeArticuloCocina.Add(microonda3);
            ListaDeArticuloCocina.Add(microonda4);
            //Batidora
            ListaDeArticuloCocina.Add(batidora1);
            ListaDeArticuloCocina.Add(batidora2);
            ListaDeArticuloCocina.Add(batidora3);
            ListaDeArticuloCocina.Add(batidora4);

            Console.WriteLine($"-----------------------------------------------------");
            Console.WriteLine($"\t Hola Bienvenidos  a una simulacion de compra de productos. ");
            Console.WriteLine($"-----------------------------------------------------");
            Console.WriteLine($"\t Encuentra  Artículos de Cocina  tanto como Artículos de Estudio");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine("Ingrese su nombre");
            var nombreCliente = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido");
            var apellidoCliente = Console.ReadLine();

            Console.WriteLine($"-----------------------------------------------------");
            Console.WriteLine($"*Bienvenido {nombreCliente}  {apellidoCliente}");


            //Respuestas

                Console.WriteLine($"-----------------------------------------------------");
                Console.WriteLine("Acontinuacion se mostrara la lista de los productos y sus Acciones ");
            Console.BackgroundColor = ConsoleColor.Red;
           

            Console.WriteLine($"Felicidades usted   ha comprado una tablet modelo: {tablet1.Modelo}  de marca: {tablet1.Marca}");
                        Console.WriteLine($"{tablet1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{tablet1.ReproducirMusica()}");
                        Console.WriteLine($"{tablet1.PararMusica()}");
                        Console.WriteLine($"{tablet1.Resistencia("No es resistente agua")}");
                      
                        Console.WriteLine($"Felicidades usted   ha comprado una tablet modelo: {tablet2.Modelo}  de marca: {tablet2.Marca}");
                        Console.WriteLine($"{tablet2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{tablet2.ReproducirMusica()}");
                        Console.WriteLine($"{tablet2.PararMusica()}");
                        Console.WriteLine($"{tablet2.Resistencia(" No es resistente agua ")}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado una tablet modelo: {tablet3.Modelo}  de marca: {tablet3.Marca}");
                        Console.WriteLine($"{tablet3.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{tablet3.ReproducirMusica()}");
                        Console.WriteLine($"{tablet3.PararMusica()}");
                        Console.WriteLine($"{tablet3.Resistencia(" No es resistente agua ")}");
                    
                        Console.WriteLine($"Felicidades usted   ha comprado una tablet modelo: {tablet4.Modelo} de marca: {tablet4.Marca}");
                        Console.WriteLine($"{tablet4.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{tablet4.ReproducirMusica()}");
                        Console.WriteLine($"{tablet4.PararMusica()}");
                        Console.WriteLine($"{tablet4.Resistencia(" No es resistente agua ")}");
                        
                    //Laptop
                    
                        Console.WriteLine($"Felicidades usted   ha comprado una laptop modelo: {laptop1.Modelo} de marca: {laptop1.Marca}");
                        Console.WriteLine($"{laptop1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{laptop1.Encender()}");
                        Console.WriteLine($"{laptop1.Descargas()}");
                        Console.WriteLine($"{laptop1.VideoConferencias()}");
                        Console.WriteLine($"{laptop1.Apagar()}");
                      
                   
                        Console.WriteLine($"Felicidades usted   ha comprado una laptop modelo: {laptop2.Modelo} de marca: {laptop2.Marca}");
                        Console.WriteLine($"{laptop2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{laptop2.Encender()}");
                        Console.WriteLine($"{laptop2.Descargas()}");
                        Console.WriteLine($"{laptop2.VideoConferencias()}");
                        Console.WriteLine($"{laptop2.Apagar()}");
                      
                        Console.WriteLine($"Felicidades usted   ha comprado una laptop modelo: {laptop3.Modelo} de marca: {laptop3.Marca}");
                        Console.WriteLine($"{laptop3.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{laptop3.Encender()}");
                        Console.WriteLine($"{laptop3.Descargas()}");
                        Console.WriteLine($"{laptop3.VideoConferencias()}");
                        Console.WriteLine($"{laptop3.Apagar()}");
                      
                        Console.WriteLine($"Felicidades usted   ha comprado una laptop modelo: {laptop4.Modelo} de marca: {laptop4.Marca}");
                        Console.WriteLine($"{laptop4.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{laptop4.Encender()}");
                        Console.WriteLine($"{laptop4.Descargas()}");
                        Console.WriteLine($"{laptop4.VideoConferencias()}");
                        Console.WriteLine($"{laptop4.Apagar()}");
                       
                    //Smartphone
                    
                        Console.WriteLine($"Felicidades usted   ha comprado una tablet modelo: {smartphone1.Modelo}  de marca: {smartphone1.Marca}");
                        Console.WriteLine($"{smartphone1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{smartphone1.ReproducirMusica()}");
                        Console.WriteLine($"{smartphone1.PararMusica()}");
                        Console.WriteLine($"{smartphone1.Resistencia(" No es resistente agua ")}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado un smartphone modelo: {smartphone2.Modelo}  de marca: {smartphone2.Marca}");
                        Console.WriteLine($"{smartphone2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{smartphone2.ReproducirMusica()}");
                        Console.WriteLine($"{smartphone2.PararMusica()}");
                        Console.WriteLine($"{smartphone2.Resistencia(" No es resistente agua ")}");
                      
                        Console.WriteLine($"Felicidades usted   ha comprado un smartphone modelo: {smartphone3.Modelo}  de marca: {smartphone3.Marca}");
                        Console.WriteLine($"{smartphone3.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{smartphone3.ReproducirMusica()}");
                        Console.WriteLine($"{smartphone3.PararMusica()}");
                        Console.WriteLine($"{smartphone3.Resistencia(" No es resistente agua ")}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado un smartphone modelo: {smartphone4.Modelo}  de marca: {smartphone4.Marca}");
                        Console.WriteLine($"{smartphone4.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{smartphone4.ReproducirMusica()}");
                        Console.WriteLine($"{smartphone4.PararMusica()}");
                        Console.WriteLine($"{smartphone4.Resistencia(" No es resistente agua ")}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($" {nombreCliente}  {apellidoCliente} Presiona enter para continuar");
            
            Console.ReadLine();
           


            //Licuadora
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Felicidades usted   ha comprado una licuadora modelo: {licuadora1.Modelo} de marca: {licuadora1.Marca}");
                        Console.WriteLine($"{licuadora1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{licuadora1.Encender()}");
                        Console.WriteLine($"{licuadora1.Licuar(" Rápido ")}");
                        Console.WriteLine($"{licuadora1.Apagar()}");
                  
                        Console.WriteLine($"Felicidades usted   ha comprado una licuadora modelo: {licuadora2.Modelo}de marca: {licuadora2.Marca}");
                        Console.WriteLine($"{licuadora2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{licuadora2.Encender()}");
                        Console.WriteLine($"{licuadora2.Licuar(" Rápido ")}");
                        Console.WriteLine($"{licuadora2.Apagar()}");
                      
                        Console.WriteLine($"Felicidades usted   ha comprado una licuadora modelo: {licuadora3.Modelo} de marca: {licuadora3.Marca}");
                        Console.WriteLine($"{licuadora3.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{licuadora3.Encender()}");
                        Console.WriteLine($"{licuadora3.Licuar(" Rápido ")}");
                        Console.WriteLine($"{licuadora3.Apagar()}");
                    
                        Console.WriteLine($"Felicidades usted   ha comprado una licuadora modelo: {licuadora4.Modelo} de marca: {licuadora4.Marca}");
                        Console.WriteLine($"{licuadora4.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{licuadora4.Encender()}");
                        Console.WriteLine($"{licuadora4.Licuar(" Lento ")}");
                        Console.WriteLine($"{licuadora4.Apagar()}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado un microondas modelo: {microonda1.Modelo} de marca: {microonda1.Marca}");
                        Console.WriteLine($"{microonda1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{microonda1.Encender()}");
                        Console.WriteLine($"{microonda1.AbrirMicroonda()}");
                        Console.WriteLine($"{microonda1.Apagar()}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado un microondas modelo: {microonda2.Marca} de marca: {microonda2}");
                        Console.WriteLine($"{microonda2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{microonda2.Encender()}");
                        Console.WriteLine($"{microonda2.AbrirMicroonda()}");
                        Console.WriteLine($"{microonda2.Apagar()}");
                    
                        Console.WriteLine($"Felicidades usted   ha comprado un microondas modelo: {microonda3.Modelo} de marca: {microonda3.Marca}");
                        Console.WriteLine($"{microonda3.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{microonda3.Encender()}");
                        Console.WriteLine($"{microonda3.AbrirMicroonda()}");
                        Console.WriteLine($"{microonda3.Apagar()}");
                   
                        Console.WriteLine($"Felicidades usted   ha comprado un microondas modelo: {microonda4.Marca} de marca: {microonda4}");
                        Console.WriteLine($"{microonda4.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{microonda4.Encender()}");
                        Console.WriteLine($"{microonda4.AbrirMicroonda()}");
                        Console.WriteLine($"{microonda4.Apagar()}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado una Batidora modelo: {batidora1.Modelo} de marca: {batidora1.Marca}");
                        Console.WriteLine($"{batidora1.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{batidora1.Encender()}");
                        Console.WriteLine($"{batidora1.Batir(" Normal ")}");
                        Console.WriteLine($"{batidora1.Apagar()}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado una Batidora modelo: {batidora2.Modelo} de marca: {batidora2.Marca}");
                        Console.WriteLine($"{batidora2.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{batidora2.Encender()}");
                        Console.WriteLine($"{batidora1.Batir(" Lento ")}");
                        Console.WriteLine($"{batidora2.Apagar()}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado una Batidora modelo: {batidora3.Modelo} de marca: {batidora3.Marca}");
                        Console.WriteLine($"{batidora3.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{batidora3.Encender()}");
                        Console.WriteLine($"{batidora1.Batir(" Rápido ")}");
                        Console.WriteLine($"{batidora3.Apagar()}");
                     
                        Console.WriteLine($"Felicidades usted   ha comprado una Batidora modelo:{batidora4.Modelo} de marca: {batidora4.Marca}");
                        Console.WriteLine($"{batidora4.Describir()}");
                        Console.WriteLine($"Funcionalidades:");
                        Console.WriteLine($"{batidora4.Encender()}");
                        Console.WriteLine($"{batidora1.Batir(" Lento ")}");
                        Console.WriteLine($"{batidora4.Apagar()}");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine("Acontinuación se mostrará  a las persona  que  compraron  los productos, ya que contamos con una excelente calidad de artículos ");
            Console.ReadLine();
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"{recomendacionPersona1.Nombre} Obtuvo  una compra de tablet modelo: {recomendacionPersona1.TabletComprada.Modelo} con la marca:  {recomendacionPersona1.TabletComprada.Marca}," +
                $" un microonda  de modelo: {recomendacionPersona1.MicroondaComprada.Modelo} con la marca {recomendacionPersona1.MicroondaComprada.Marca}  y una batidora  de modelo  {recomendacionPersona1.BatidoraComprada.Modelo} con la marca,{recomendacionPersona1.BatidoraComprada.Marca}");
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"{recomendacionPersona2.Nombre} Obtuvo  una compra de batidora modelo: {recomendacionPersona2.BatidoraComprada.Modelo} con la marca:{recomendacionPersona2.BatidoraComprada.Marca}," +
                $" una licuadora de modelo: {recomendacionPersona2.LicuadoraComprada.Modelo} {recomendacionPersona2.LicuadoraComprada.Marca} y un Smartphone: {recomendacionPersona2.SmartphoneComprada.Modelo}con la marca {recomendacionPersona2.SmartphoneComprada.Marca}");
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"{recomendacionPersona3.Nombre} Obtuvo  una compra de laptop modelo: {recomendacionPersona3.LaptopComprada.Modelo}con la marca: {recomendacionPersona3.LaptopComprada.Marca}," +
                $" una  batidora  de modelo:{recomendacionPersona3.BatidoraComprada.Modelo} {recomendacionPersona3.BatidoraComprada.Marca} y un microonda: {recomendacionPersona3.MicroondaComprada.Modelo}con la marca {recomendacionPersona3.MicroondaComprada.Marca}");
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"{recomendacionPersona4.Nombre} Obtuvo  una compra de laptop modelo: {recomendacionPersona4.LaptopComprada.Modelo}con la marca: {recomendacionPersona4.LaptopComprada.Marca}," +
              $" una  batidora de modelo: {recomendacionPersona4.BatidoraComprada.Modelo} {recomendacionPersona4.BatidoraComprada.Marca} y un microonda: {recomendacionPersona4.MicroondaComprada.Modelo}con la marca {recomendacionPersona4.MicroondaComprada.Marca}");
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"{recomendacionPersona5.Nombre} Obtuvo  una compra de licuadora modelo: {recomendacionPersona5.LicuadoraComprada.Modelo} con la marca:{recomendacionPersona5.LicuadoraComprada.Marca}," +
              $" una  batidora de modelo: {recomendacionPersona5.BatidoraComprada.Modelo} {recomendacionPersona5.BatidoraComprada.Marca} y un microonda: {recomendacionPersona5.MicroondaComprada.Modelo} con la marca{recomendacionPersona5.MicroondaComprada.Marca}");
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"{recomendacionPersona6.Nombre} Obtuvo  una compra de laptop modelo: {recomendacionPersona6.LaptopComprada.Modelo}con la marca: {recomendacionPersona6.LaptopComprada.Marca}," +
              $" una  batidora de modelo: {recomendacionPersona6.BatidoraComprada.Modelo} {recomendacionPersona6.BatidoraComprada.Marca} y un Smartphone: {recomendacionPersona6.SmartphoneComprada.Modelo}con la marca {recomendacionPersona6.SmartphoneComprada.Marca}");
            Console.WriteLine($"------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadKey();
        }
    }
}
