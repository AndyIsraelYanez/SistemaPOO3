using System;

namespace LogicaConsola
{
   public  class Batidora:ArticuloDeCocina
    {
       
        public Batidora(string modelo, string marca,string color, float costo)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Color = color;
            this.Costo = costo;
        }
        public Batidora() : base()
        {
        }

        public new string On()
        {
            return $" {Modelo} {Marca} {base.On()} ";
        }
        public new string Off()
        {
            return $"{Modelo} {base.Off()} ";
        }
       
        public  string Batir(string tipoBatida)
        {
            return $"La Batidora mezcla:  {tipoBatida}";
        }
        public virtual string Detallar()
        {
            return $" La  Batidora es de  marca es : {Marca}  y tiene un costo de: {Costo} $ ";
        }
    }
}
