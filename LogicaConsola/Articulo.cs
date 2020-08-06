
namespace LogicaConsola
{
    public abstract class Articulo
    {
        protected Articulo() : base()
        { }

        
        public virtual string ReproducirMusica()
        {
            return $"sistema de voz para  Reproducir música";
        }
        public virtual string PararMusica()
        {
            return $"sistema de voz para  parar música ";
        }
        public virtual string On()
        {
            return $"se encuentra en modo on";

        }
        public virtual string Off()
        {
            return $"se encuentra en modo off";

        }
    }
}
