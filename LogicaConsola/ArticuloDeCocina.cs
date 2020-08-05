
using System;

namespace LogicaConsola
{
    public abstract class ArticuloDeCocina:Articulo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public float Costo { get; set; }
       
        public void VerListaCocina()
        {
            Console.WriteLine($"El modelo  es: {this.Modelo}  y tiene un costo de: {this.Costo} $ ");
        }
    }
}
