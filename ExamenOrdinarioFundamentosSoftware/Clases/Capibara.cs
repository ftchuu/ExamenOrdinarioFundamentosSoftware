using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class Capibara:IMascota
    {
        private string _id;
        public string Id { get { return _id; } }
        private string _nombre;
        public string Nombre { get { return _nombre; } }
        public int Edad { get; set; }
        Temperamento Temperamento = "Amable"; //hay que esperar al enumerador
        Persona Dueño { get; set; }

        public int contadorCapibara = 0;
        public int edadMaxima = 11;

        void HacerRuido()
        {
            Console.WriteLine("cui cui");
        }

        void CambiarDueño(Persona nuevoDueño)
        {
            Console.WriteLine($"{Nombre} ha cambiado su dueño a {nuevoDueño.Name}");
            nuevoDueño = this.Dueño;
        }

        public Capibara(string nombre, int edad, string id, Temperamento temperamento, Persona dueño)
        {
            id = $"Capibara-{contadorCapibara++}";
            nombre = Nombre;
            if (edad > edadMaxima)
            {
                Console.WriteLine("El capibara no puede tener más de 11 años");
            }
            else
            {
                edad = Edad;
            }
            temperamento = this.Temperamento;
            dueño = this.Dueño;
        }
    }
}
