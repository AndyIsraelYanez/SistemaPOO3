
namespace SolucionAppLogica
{
    public class Persona:GeneradorId
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public Persona():base()
        {}
    }
}
