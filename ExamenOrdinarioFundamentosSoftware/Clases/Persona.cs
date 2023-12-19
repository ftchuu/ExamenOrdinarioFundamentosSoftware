using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenOrdinarioFundamentosSoftware.Interfaces;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class Persona
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("El nombre no puede estar en blanco");
                }
                else
                {
                    _name = value;
                }
            }
        }
        private int contadorPersona = 0;
         
        public List<IMascota> mascotas;
        public Persona (string nombre, int id)
        {
            nombre = Name;
            id = contadorPersona++;
            id = this.Id;
        }
        public List<IMascota> ObtenerMascotas()
        {
            return mascotas;
        }

        public IMascota ObtenerMascotaPorId (string id)
        {
            foreach(var mascota in mascotas)
            {
                if (mascota.Id == id) return mascota;
            }

            return null;
            
        }

        public void AgregarMascota(IMascota mascota)
        {
            mascotas.Add(mascota);
            Console.WriteLine($"{Name} agrega a {mascota.Nombre} a sus mascotas");
            mascota.HacerRuido();
        }
        public void AcariciarMascota(IAcariciable mascotaAcariciable)
        {
            IMascota mascota = mascotaAcariciable as IMascota;
            Console.WriteLine($"{Name} acaricia a {mascota.Nombre}");

        }
        public void AcariciarMascotas()
        {
            foreach (var mascota in Mascotas)
            {
                if (mascota is IAcariciable acariciable)
                {
                    Console.WriteLine($"{Name} acaricia a {acariciable.Nombre}");
                    acariciable.SerAcariciado(); // Llamada al método SerAcariciado
                }
                else
                {
                    Console.WriteLine($"{Name} intenta acariciar a {mascota.Nombre}, pero no es posible");
                }
            }
        }
    }
}
