using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class Gato : IMascota, IAcariciable
    {
        private static int contadorGato = 1;
        private const int EdadMaxima = 18;

        public string Id { get; }
        public string Nombre { get; }
        public int Edad { get; set; }
        public Temperamento Temperamento { get; }
        public Persona Dueño { get; set; }

        public Gato(string nombre, int edad, Temperamento temperamento, Persona dueño)
        {
            Id = $"Gato-{contadorGato++}";
            Nombre = nombre;
            Edad = (edad > EdadMaxima) ? EdadMaxima : edad;
            Temperamento = temperamento;
            Dueño = dueño;
        }

        public void HacerRuido()
        {
            Console.WriteLine("Miau Miau");
        }

        public void CambiarDueño(Persona nuevoDueño)
        {
            Console.WriteLine($"{Nombre} ha cambiado su dueño a {nuevoDueño.Name}");
            Dueño = nuevoDueño;
        }

        public void SerAcariciado()
        {
            Console.WriteLine($"{Nombre} está siendo acariciado");
        }
    }
}
