
using System;

namespace SolucionAppLogica
{
    public abstract class ArticuloDeCocina:Articulo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public float Costo { get; set; }
        protected ArticuloDeCocina():base()
        {}
        public void VerListaCocina()
        {
            Console.WriteLine($"El modelo  es: {this.Modelo} su marca es: {this.Marca}  y tiene un costo de: {this.Costo} $ ");
        }
    }
}
