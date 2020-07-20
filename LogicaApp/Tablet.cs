
using System.Runtime.CompilerServices;

namespace SolucionAppLogica
{
    public class Tablet:ArticuloDeEstudio
    {
        public string Almacenamiento { get; set; }
        public string MemoriaRam { get; set; }
        public Tablet():base()
        {

        }
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
            return $" La tablet de modelo {this.Modelo} {this.Marca} tiene un {base.ReproducirMusica()} ";
        }
        public new string PararMusica()
        {
            return $" el modelo {this.Modelo}  de la msima manera tiene un  {base.PararMusica()}";
        }
        
        public virtual string Describir()
        {
            return $" El dispositivo es de  de marca:  {this.Marca}  " +
                $" tiene  un almacenamiento de:  {this.Almacenamiento} y una memoria Ram  de: {this.MemoriaRam} con un costo de: {this.Costo} $ ";
        }
        public virtual string Resistencia(string resistent)
        {
            return $" su tablet : {resistent}  ";
        }
    }
}
