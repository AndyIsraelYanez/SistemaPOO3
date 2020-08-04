
using System;
using System.Runtime.CompilerServices;

namespace LogicaConsola
{
    public class Smartphone : ArticuloDeEstudio
    {
        public string Almacenamiento { get; set; }
        public string MemoriaRam { get; set; }
        public Smartphone() : base()
        {

        }
        public Smartphone(string modelo, string color, string marca, string almacenamiento,string memoriaRam, float costo)
        {
            Modelo = modelo;
            Color = color;
            Marca = marca;
            Almacenamiento = almacenamiento;
            MemoriaRam = memoriaRam;
            Costo = costo;
        }
     

        public virtual string Describir()
        {
            return $" El dispositivo es de  de marca:  {this.Marca}  " +
                $" tine  un almacenamiento de:  {this.Almacenamiento} y una memoria Ram  de: {this.MemoriaRam} con un costo de: {this.Costo} $ ";
        }
        public virtual string Resistencia(string resistent)
        {
            return $" su tablet : {resistent}  ";
        }

        public new string ReproducirMusica()
        {
            return $" La tablet de modelo {this.Modelo} {this.Marca} tiene un {base.ReproducirMusica()} ";
        }
        public new string PararMusica()
        {
            return $" el modelo {this.Modelo}  de la misma  manera tiene un  {base.PararMusica()}";
        }
    }
    
}