
using System;
using System.Globalization;

namespace SolucionAppLogica
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
            Random consumo = new Random();

            int numGastoEnergia = consumo.Next(5, 10);

            ConsumoElectrico = numGastoEnergia;

            var luz = "LED";

            TipoDeIluminacion = luz;

            return $" El microondas de marca  {this.Marca}   consume la electricidad  de {this.ConsumoElectrico} kWh , tiene un costo de {this.Costo} $ ";
        }

    }
}
