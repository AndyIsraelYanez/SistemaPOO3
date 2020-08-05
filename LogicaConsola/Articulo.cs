
namespace LogicaConsola
{
    public abstract class Articulo
    {
        
        public virtual string Encender()
        {
            return $"se encuentra encendido";

        }
        public virtual string Apagar()
        {
            return $"Apagado";

        }
        public virtual string ReproducirMusica()
        {
            return $"sistema de voz para  Reproducir música";
        }
        public virtual string PararMusica()
        {
            return $"sistema de voz para  parar música ";
        }
    }
}
