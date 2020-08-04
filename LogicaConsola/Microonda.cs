
using System;
using System.Globalization;

namespace LogicaConsola
{
    public class Microonda:ArticuloDeCocina
    {
        public float ConsumoElectrico{ get; set; }
        public string TipodeCalentado { get; set; }
        public string TipoDeIluminacion { get; set; }

        public Microonda():base()
        {}
        public Microonda(string modelo, string marca, string color, float costo)
        {
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Costo = costo;
        }
        public new string Encender()
        {
            return $" {this.Modelo} {this.Marca} {base.Encender()} ";
        }
        public new string Apagar()
        {
            return $"{this.Modelo} {base.Apagar()} ";
        }
        public string AbrirMicroonda()
        {
            var luz = "Led";

            TipoDeIluminacion = luz;

            return $"Al momento de Abrir el microondas de marca: {this.Marca} tiene una iluminación: {TipoDeIluminacion}";
        }
        public string Describir()
        {

            return $" El microondas de marca  {this.Marca}   es muy recomendado $ ";
        }

    }
}
