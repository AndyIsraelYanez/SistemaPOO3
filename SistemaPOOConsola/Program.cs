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


            
            //Mostrar productos 
            Console.WriteLine($"-----------------------------------------------------");
            Console.WriteLine("Acontinuacion se mostrara la lista de los productos y sus Acciones ");
            Console.BackgroundColor = ConsoleColor.Red;


            Console.WriteLine($"Esta es  una tablet modelo: {tablet1.Modelo}  de marca: {tablet1.Marca}");
            Console.WriteLine($"{tablet1.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{tablet1.ReproducirMusica()}");
            Console.WriteLine($"{tablet1.PararMusica()}");
            Console.WriteLine($"{tablet1.Resistencia("No es resistente agua")}");

            Console.WriteLine($"Esta es  una tablet modelo: {tablet2.Modelo}  de marca: {tablet2.Marca}");
            Console.WriteLine($"{tablet2.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{tablet2.ReproducirMusica()}");
            Console.WriteLine($"{tablet2.PararMusica()}");
            Console.WriteLine($"{tablet2.Resistencia(" No es resistente agua ")}");

            Console.WriteLine($"Esta es  una tablet modelo: {tablet3.Modelo}  de marca: {tablet3.Marca}");
            Console.WriteLine($"{tablet3.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{tablet3.ReproducirMusica()}");
            Console.WriteLine($"{tablet3.PararMusica()}");
            Console.WriteLine($"{tablet3.Resistencia(" No es resistente agua ")}");

            Console.WriteLine($"Esta es una tablet modelo: {tablet4.Modelo} de marca: {tablet4.Marca}");
            Console.WriteLine($"{tablet4.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{tablet4.ReproducirMusica()}");
            Console.WriteLine($"{tablet4.PararMusica()}");
            Console.WriteLine($"{tablet4.Resistencia(" No es resistente agua ")}");

            //Laptop.2

            Console.WriteLine($"Esta es  una laptop modelo: {laptop1.Modelo} de marca: {laptop1.Marca}");
            Console.WriteLine($"{laptop1.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{laptop1.Encender()}");
            Console.WriteLine($"{laptop1.Descargas()}");
            Console.WriteLine($"{laptop1.VideoConferencias()}");
            Console.WriteLine($"{laptop1.Apagar()}");


            Console.WriteLine($"Esta es  una laptop modelo: {laptop2.Modelo} de marca: {laptop2.Marca}");
            Console.WriteLine($"{laptop2.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{laptop2.Encender()}");
            Console.WriteLine($"{laptop2.Descargas()}");
            Console.WriteLine($"{laptop2.VideoConferencias()}");
            Console.WriteLine($"{laptop2.Apagar()}");

            Console.WriteLine($"Esta es  una laptop modelo: {laptop3.Modelo} de marca: {laptop3.Marca}");
            Console.WriteLine($"{laptop3.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{laptop3.Encender()}");
            Console.WriteLine($"{laptop3.Descargas()}");
            Console.WriteLine($"{laptop3.VideoConferencias()}");
            Console.WriteLine($"{laptop3.Apagar()}");

            Console.WriteLine($"Esta es  una laptop modelo: {laptop4.Modelo} de marca: {laptop4.Marca}");
            Console.WriteLine($"{laptop4.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{laptop4.Encender()}");
            Console.WriteLine($"{laptop4.Descargas()}");
            Console.WriteLine($"{laptop4.VideoConferencias()}");
            Console.WriteLine($"{laptop4.Apagar()}");

            //Smartphone

            Console.WriteLine($"Esta es una tablet modelo: {smartphone1.Modelo}  de marca: {smartphone1.Marca}");
            Console.WriteLine($"{smartphone1.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{smartphone1.ReproducirMusica()}");
            Console.WriteLine($"{smartphone1.PararMusica()}");
            Console.WriteLine($"{smartphone1.Resistencia(" No es resistente agua ")}");

            Console.WriteLine($"Esta es  un smartphone modelo: {smartphone2.Modelo}  de marca: {smartphone2.Marca}");
            Console.WriteLine($"{smartphone2.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{smartphone2.ReproducirMusica()}");
            Console.WriteLine($"{smartphone2.PararMusica()}");
            Console.WriteLine($"{smartphone2.Resistencia(" No es resistente agua ")}");

            Console.WriteLine($"Esta es  un smartphone modelo: {smartphone3.Modelo}  de marca: {smartphone3.Marca}");
            Console.WriteLine($"{smartphone3.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{smartphone3.ReproducirMusica()}");
            Console.WriteLine($"{smartphone3.PararMusica()}");
            Console.WriteLine($"{smartphone3.Resistencia(" No es resistente agua ")}");

            Console.WriteLine($"Esta es  un smartphone modelo: {smartphone4.Modelo}  de marca: {smartphone4.Marca}");
            Console.WriteLine($"{smartphone4.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{smartphone4.ReproducirMusica()}");
            Console.WriteLine($"{smartphone4.PararMusica()}");
            Console.WriteLine($"{smartphone4.Resistencia(" No es resistente agua ")}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($" {nombreCliente}  {apellidoCliente} Presiona enter para continuar");

            Console.ReadLine();



            //Licuadora
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Esta es  una licuadora modelo: {licuadora1.Modelo} de marca: {licuadora1.Marca}");
            Console.WriteLine($"{licuadora1.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{licuadora1.Encender()}");
            Console.WriteLine($"{licuadora1.Licuar(" Rápido ")}");
            Console.WriteLine($"{licuadora1.Apagar()}");

            Console.WriteLine($"Esta es una licuadora modelo: {licuadora2.Modelo}de marca: {licuadora2.Marca}");
            Console.WriteLine($"{licuadora2.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{licuadora2.Encender()}");
            Console.WriteLine($"{licuadora2.Licuar(" Rápido ")}");
            Console.WriteLine($"{licuadora2.Apagar()}");

            Console.WriteLine($"Esta es  una licuadora modelo: {licuadora3.Modelo} de marca: {licuadora3.Marca}");
            Console.WriteLine($"{licuadora3.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{licuadora3.Encender()}");
            Console.WriteLine($"{licuadora3.Licuar(" Rápido ")}");
            Console.WriteLine($"{licuadora3.Apagar()}");

            Console.WriteLine($"Esta es una licuadora modelo: {licuadora4.Modelo} de marca: {licuadora4.Marca}");
            Console.WriteLine($"{licuadora4.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{licuadora4.Encender()}");
            Console.WriteLine($"{licuadora4.Licuar(" Lento ")}");
            Console.WriteLine($"{licuadora4.Apagar()}");

            Console.WriteLine($"Esta es  un microondas modelo: {microonda1.Modelo} de marca: {microonda1.Marca}");
            Console.WriteLine($"{microonda1.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{microonda1.Encender()}");
            Console.WriteLine($"{microonda1.AbrirMicroonda()}");
            Console.WriteLine($"{microonda1.Apagar()}");

            Console.WriteLine($"Esta es  un microondas modelo: {microonda2.Marca} de marca: {microonda2}");
            Console.WriteLine($"{microonda2.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{microonda2.Encender()}");
            Console.WriteLine($"{microonda2.AbrirMicroonda()}");
            Console.WriteLine($"{microonda2.Apagar()}");

            Console.WriteLine($"Esta es un microondas modelo: {microonda3.Modelo} de marca: {microonda3.Marca}");
            Console.WriteLine($"{microonda3.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{microonda3.Encender()}");
            Console.WriteLine($"{microonda3.AbrirMicroonda()}");
            Console.WriteLine($"{microonda3.Apagar()}");

            Console.WriteLine($"Esto es  un microondas modelo: {microonda4.Marca} de marca: {microonda4}");
            Console.WriteLine($"{microonda4.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{microonda4.Encender()}");
            Console.WriteLine($"{microonda4.AbrirMicroonda()}");
            Console.WriteLine($"{microonda4.Apagar()}");

            Console.WriteLine($"Esto es una Batidora modelo: {batidora1.Modelo} de marca: {batidora1.Marca}");
            Console.WriteLine($"{batidora1.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{batidora1.Encender()}");
            Console.WriteLine($"{batidora1.Batir(" Normal ")}");
            Console.WriteLine($"{batidora1.Apagar()}");

            Console.WriteLine($"Esto es una Batidora modelo: {batidora2.Modelo} de marca: {batidora2.Marca}");
            Console.WriteLine($"{batidora2.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{batidora2.Encender()}");
            Console.WriteLine($"{batidora1.Batir(" Lento ")}");
            Console.WriteLine($"{batidora2.Apagar()}");

            Console.WriteLine($"Esto es una Batidora modelo: {batidora3.Modelo} de marca: {batidora3.Marca}");
            Console.WriteLine($"{batidora3.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{batidora3.Encender()}");
            Console.WriteLine($"{batidora1.Batir(" Rápido ")}");
            Console.WriteLine($"{batidora3.Apagar()}");

            Console.WriteLine($"Esto es una Batidora modelo:{batidora4.Modelo} de marca: {batidora4.Marca}");
            Console.WriteLine($"{batidora4.Detallar()}");
            Console.WriteLine($"Funcionalidades:");
            Console.WriteLine($"{batidora4.Encender()}");
            Console.WriteLine($"{batidora1.Batir(" Lento ")}");
            Console.WriteLine($"{batidora4.Apagar()}");
            Console.BackgroundColor = ConsoleColor.Black;

           
            

            Console.ReadKey();
        }
    }
}
