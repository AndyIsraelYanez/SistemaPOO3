
using System;
using System.Globalization;

namespace LogicaConsola
{
    public class Microonda:ArticuloDeCocina
    {
        public float ConsumoElectrico{ get; set; }
        public string TipodeCalentado { get; set; }
        public string TamañoPorDentro { get; set; }
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
       
        public string Detallar()
        {

            return $" El microondas de marca  {this.Marca}   es muy recomendado $ ";
        }
        public string AbrirMicroonda()
        {
            var tamañoDentro = "pequeño";

            TamañoPorDentro = tamañoDentro;

            return $"Al momento de Abrir el microondas por dentro es {TamañoPorDentro}";
        }

    }
}
