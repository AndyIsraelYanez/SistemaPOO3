using System;

namespace LogicaConsola
{
    public  class Cliente:Persona
    {
        public Cliente():base()
        {}
        Laptop laptop;
        public Laptop LaptopComprada
        {
            get
            {
                return laptop;
            }

            set
            {
                laptop = value;
            }
        }
        Smartphone smartphone;
        public Smartphone SmartphoneComprada
        {
            get
            {
                return smartphone;
            }

            set
            {
                smartphone = value;
            }
        }
        Batidora batidora;

        public Batidora BatidoraComprada
        {
            get
            {
                return batidora;
            }

            set
            {
                batidora = value;
            }
        }

        Licuadora licuadora;

        public Licuadora LicuadoraComprada
        {
            get
            {
                return licuadora;
            }

            set
            {
                licuadora = value;
            }
        }

        Microonda microonda;

        public Microonda MicroondaComprada
        {
            get
            {
                return microonda;
            }

            set
            {
                microonda = value;
            }
        }

        Tablet tablet;

        public Tablet TabletComprada
        {
            get
            {
                return tablet;
            }

            set
            {
                tablet = value;
            }
        }   
        
    }
}