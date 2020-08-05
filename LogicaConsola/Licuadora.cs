﻿
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
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Costo = costo;
        }

        public string Licuar(string licuado)
        {
            return $" la Licuadora esta licuando {licuado}";
        }

        public new string Encender()
        {
            return $"  {this.Marca} {base.Encender()} ";
        }
        public new string Apagar()
        {
            return $" {this.Modelo} {base.Apagar()}";
        }      
        
        public virtual string Detallar()
        {

            return $" la licuadora  de Modelo:  {this.Modelo} y marca: {this.Marca} " +
                $"son muy Rapidas y resistentes ante cualquier caida  $ ";
        }
    }
}
