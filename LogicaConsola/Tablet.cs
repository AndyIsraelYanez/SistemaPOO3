
using System.Runtime.CompilerServices;

namespace LogicaConsola
{
    public class Tablet:ArticuloDeEstudio
    {
        public string Almacenamiento { get; set; }
        public string MemoriaRam { get; set; }
        public Tablet(string modelo, string color, string marca,string almacenamiento,string memoria,float costo )
        {
            Modelo = modelo;
            Color = color;
            Marca = marca;
            Almacenamiento = almacenamiento;
            MemoriaRam = memoria;
            Costo = costo;
        }
        public new string ReproducirMusica()
        {
            return $" La tablet de modelo {this.Modelo} tiene un {base.ReproducirMusica()} ";
        }
        public new string PararMusica()
        {
            return $" el modelo {this.Modelo}  de la msima manera tiene un  {base.PararMusica()}";
        }
        
        public virtual string Detallar()
        {
            return $" El dispositivo es de  de marca:  {this.Marca}  " +
                $" tiene  un almacenamiento de:  {this.Almacenamiento} y una memoria Ram  de: {this.MemoriaRam}" +
                $" con un costo de: {this.Costo} dolares ";
        }
        public virtual string Resistencia(string resistent)
        {
            return $" su tablet : {resistent} . ";
        }
    }
}
