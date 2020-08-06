

namespace LogicaConsola
{
    public class Laptop:ArticuloDeEstudio

    {
        public string Generacion { get; set; }
        public string Almacenamiento { get; set; }
        public Laptop() : base()
        {
        }

        public Laptop(string modelo, string color, string marca, 
            
            string almacenamiento, string generacion, float costo)
        {
            this.Modelo = modelo;
            this.Color = color; 
            this.Marca = marca;
            this.Almacenamiento = almacenamiento;
            this.Generacion = generacion;
            this.Costo = costo;
        }
       
        public virtual string Descargas()
        {
            return " Los  archivos han sido descargados correctamente ";
        }
        public virtual string VideoConferencias()
        {
            return " El dispositivo se esta conectando a una videollamada.. ";
        }
        public virtual string Detallar()
        {
            return $" La Laptop de Modelo: {Modelo} {Marca}" +
                $"tiene un Almacenamiento de:  {Almacenamiento}  y es de una generacion de:" +
                $"  {this.Generacion} de memoria Ram, y tiene un costo de: {Costo} $ ";
        }
        public new string On()
        {
            return $" {Modelo} {Marca} {base.On()} ";
        }
        public new string Off()
        {
            return $" {Modelo} {base.Off()} ";
        }
    }
}
