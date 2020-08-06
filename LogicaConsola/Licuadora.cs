
using System;
using System.Buffers.Text;
using System.Runtime.CompilerServices;

namespace LogicaConsola
{
   public  class Licuadora : ArticuloDeCocina
    {
        public float CantidadDeBatida { get; set; }
        public string TipoDeLicuado { get; set; }
        public float ConsumoElectrico { get; set; }
        public Licuadora() : base()
        {
        }
        public Licuadora(string modelo,string marca, string color, float costo)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Color = color;
            this.Costo = costo;
        }

        public string Licuar(string licuado)
        {
            return $" la Licuadora esta licuando {licuado}";
        }

        public new string On()
        {
            return $"  {Marca} {base.On()} ";
        }
        public new string Off()
        {
            return $" {Modelo} {base.Off()}";
        }      
        
        public virtual string Detallar()
        {

            return $" la licuadora  de Modelo:  {Modelo} y marca: {Marca} " +
                $"son muy Rapidas y resistentes ante cualquier caida  $ ";
        }
    }
}
