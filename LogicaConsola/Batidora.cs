using System;

namespace LogicaConsola
{
   public  class Batidora:ArticuloDeCocina
    {
       
        public Batidora(string modelo, string marca,string color, float costo)
        {
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Costo = costo;
        }
        public Batidora() : base()
        {
        }

        public new string On()
        {
            return $" {this.Modelo} {this.Marca} {base.On()} ";
        }
        public new string Off()
        {
            return $"{this.Modelo} {base.Off()} ";
        }
       
        public  string Batir(string tipoBatida)
        {
            return $"La Batidora mezcla:  {tipoBatida}";
        }
        public virtual string Detallar()
        {
            return $" La  Batidora es de  marca es : {this.Marca}  y tiene un costo de: {this.Costo} $ ";
        }
    }
}
