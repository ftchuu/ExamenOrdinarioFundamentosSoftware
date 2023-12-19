using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class Persona
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        private string _name;
        public string Name { get { return _name; }set { _name = value; } }//falta verificacion para que el nombre no este en blanco
        public List<IMascota> mascotas;
        public List<IMascota> ObtenerMascotas()
        {
            return mascotas;
        }

        public IMascota ObtenerMascotaPorId (string id)
        {
            //ni idea de como hacer este
            
        }

        public void AgregarMascota(IMascota mascota)
        {
            mascotas.Add(mascota);
            Console.WriteLine($"{Name} agrega a {mascota.Nombre} a sus mascotas");
            mascota.HacerRuido();
        }
        public void AcariciarMascota(IAcariciable mascotaAcariciable)
        {
            Console.WriteLine($"{Name} acaricia a {mascotaAcariciable.Nombre}");
        }
        public void AcariciarMascotas()
        {
            foreach(var mascota in mascotas)
            {
                if (mascota != IAcariciable)
                {
                    Console.WriteLine($"{Name} intenta acariciar a {mascota.Nombre}, pero no es posible");
                }
                else
                {
                    AcariciarMascota(mascota);
                }
            }
        }
    }
}
