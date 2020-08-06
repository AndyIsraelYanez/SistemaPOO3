
using System;
using System.Globalization;

namespace LogicaConsola
{
    public class Microonda:ArticuloDeCocina
    {
        public float ConsumoElectrico{ get; set; }
        public string TipodeCalentado { get; set; }
        public string TamañoPorDentro { get; set; }
        
        public Microonda() : base() 
        {
        }
        public Microonda(string modelo, string marca, string color, float costo)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Color = color;
            this.Costo = costo;
        }
        public new string On()
        {
            return $" {Modelo} {Marca} {base.On()} ";
        }
        public new string Off()
        {
            return $"{Modelo} {base.Off()} ";
        }
       
        public string Detallar()
        {

            return $" El microondas de marca  {Marca}   es muy recomendado $ ";
        }
        public string AbrirMicroonda()
        {
            var tamañoDentro = "pequeño";

            TamañoPorDentro = tamañoDentro;

            return $"Al momento de Abrir el microondas por dentro es {TamañoPorDentro}";
        }

    }
}
