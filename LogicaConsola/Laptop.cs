

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
            Modelo = modelo;
            Color = color; 
            Marca = marca;
            Almacenamiento = almacenamiento;
            Generacion = generacion;
            Costo = costo;
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
            return $" La Laptop de Modelo: {this.Modelo} {this.Marca}" +
                $"tiene un Almacenamiento de:  {this.Almacenamiento}  y es de una generacion de:" +
                $"  {this.Generacion} de memoria Ram, y tiene un costo de: {this.Costo} $ ";
        }
        public new string On()
        {
            return $" {this.Modelo} {this.Marca} {base.On()} ";
        }
        public new string Off()
        {
            return $" {this.Modelo} {base.Off()} ";
        }
    }
}
