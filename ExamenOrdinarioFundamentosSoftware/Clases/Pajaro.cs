using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class Pajaro : IMascota
    {
        private string _id;
        public string Id { get { return _id; } }
        private string _nombre;
        public string Nombre { get { return _nombre; } }
        public int Edad { get; set; }
        public Temperamento Temperamento { get; }
        public Persona Dueño { get; set; }
        private int EdadMaxima = 8;
        private int contadorPajaro = 0;

        public void HacerRuido()
        {
            Console.WriteLine("pio pio");
        }
        public void CambiarDueño(Persona nuevoDueño)
        {
            Console.WriteLine($"{Nombre} ha cambiado su dueño a {nuevoDueño.Name}");
            nuevoDueño = Dueño;
        }
        public void Aletear()
        {
            Console.WriteLine($"{Nombre} está aleteando");
        }

        //agregar comportamiento de baile -> comportamiento o interfaz?

        public Pajaro(string nombre, int edad, string id, Temperamento temperamento, Persona dueño)
        {
            nombre = Nombre;
            if (edad > EdadMaxima)
            {
                Console.WriteLine("El pájaro no puede tener más de 8 años");
            }
            else
            {
                edad = Edad;
            }
            temperamento = Temperamento;
            dueño = Dueño;
        }

    }
}
