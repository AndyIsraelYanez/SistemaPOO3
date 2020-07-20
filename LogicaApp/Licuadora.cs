
using System;
using System.Buffers.Text;
using System.Runtime.CompilerServices;

namespace SolucionAppLogica
{
   public  class Licuadora : ArticuloDeCocina
    {
        public float CantidadDeBatida { get; set; }
        public string TipoDeLicuado { get; set; }
        public float ConsumoElectrico { get; set; }
        public Licuadora():base()
        {}
        public Licuadora(string modelo,string marca, string color, float costo)
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
            return $"{this.Modelo} {base.Apagar()} {base.Apagar()}";
        }
        public string Licuar(string licuado)
        {
            return $" la Licuadora esta licuando {licuado}";
        }

        
        public virtual string Describir()
        {
            Random consumo = new Random();

            int numeroGasto = consumo.Next(10, 15);

            int numCantidadDeBatida = consumo.Next(1, 3);

            ConsumoElectrico = numeroGasto;

            CantidadDeBatida = numCantidadDeBatida;

            return $" la licuadora  de Modelo:  {this.Modelo} y marca: {this.Marca} " +
                $"puede ingresar una cantidad  de agua de: {this.CantidadDeBatida} litros, su consumo de energia es de  {this.ConsumoElectrico} kWh y tiene un costo de: {this.Costo} $ ";
        }
    }
}
