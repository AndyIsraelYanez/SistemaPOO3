
using System.Runtime.CompilerServices;

namespace LogicaConsola
{
    public class Tablet:ArticuloDeEstudio
    {
        public string Almacenamiento { get; set; }
        public string MemoriaRam { get; set; }

        public Tablet() : base()
        {
        }
        public Tablet(string modelo, string color, string marca,string
            almacenamiento,string memoria,float costo )
        {
            this.Modelo = modelo;
            this.Color = color;
            this.Marca = marca;
            this.Almacenamiento = almacenamiento;
            this.MemoriaRam = memoria;
            this.Costo = costo;
        }
        public new string ReproducirMusica()
        {
            return $" La tablet de modelo {Modelo} tiene un {base.ReproducirMusica()} ";
        }
        public new string PararMusica()
        {
            return $" y la tablet de la msima manera tiene un  {base.PararMusica()}";
        }
        
        public virtual string Detallar()
        {
            return $" El dispositivo es de  de marca:  {Marca}  " +
                $" tiene  un almacenamiento de:  {Almacenamiento} y una memoria Ram  de: {MemoriaRam}" +
                $" con un costo de: {Costo} dolares ";
        }
        public virtual string Resistencia(string resistent)
        {
            return $" su tablet : {resistent} . ";
        }
    }
}
