

using System;

namespace LogicaConsola
{
    public abstract class ArticuloDeEstudio : Articulo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float Costo { get; set; }
        public string Color { get; set; }
        protected ArticuloDeEstudio() : base()
        { }
        public void VerListaEstudio()
        {
            Console.WriteLine($" El modelo es : {this.Modelo} y  tiene un costo de: {this.Costo} $ ");
        }

    }
}
