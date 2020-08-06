
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
            this.Modelo = modelo;
            this.Color = color;
            this.Marca = marca;
            this.Almacenamiento = almacenamiento;
            this.MemoriaRam = memoriaRam;
            this.Costo = costo;
        }
     

        public virtual string Detallar()
        {
            return $" El dispositivo es de  de marca:  {Marca}  " +
                $" tine  un almacenamiento de:  {Almacenamiento} y una memoria Ram  de: {MemoriaRam} con un costo de: {Costo} $ ";
        }
        public virtual string Resistencia(string resistent)
        {
            return $" su tablet : {resistent}  ";
        }

        public new string ReproducirMusica()
        {
            return $" La tablet de modelo {Modelo} {Marca} tiene un {base.ReproducirMusica()} ";
        }
        public new string PararMusica()
        {
            return $" el modelo {Modelo}  de la misma  manera tiene un  {base.PararMusica()}";
        }
    }
    
}