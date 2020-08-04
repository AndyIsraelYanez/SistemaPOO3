using System;


namespace LogicaConsola
{
    public  class GeneradorId
    {
        private readonly Random generador = new Random();
        public  int Id { get; set; }

        protected GeneradorId()
        {
            this.Id = generador.Next();
        }
        protected GeneradorId(int id)
        {
           this.Id = id;
        }
    }
}
