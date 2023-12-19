using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioFundamentosSoftware.Clases
{
    public class AdministracionPersona
    {
        public List<Persona> personasRegistradas;
        public AdministracionPersona()
        {
            personasRegistradas = new List<Persona>();
        }
        public void MostrarPersonasRegistradas()
        {
            foreach(var persona in personasRegistradas)
            {
                Console.WriteLine($"{persona.Id} - {persona.Name}");
            }
        }

        public void RegistraPersonaNueva()
        {
            Console.WriteLine("¿Cómo se llama la persona que quiere registrar?");
            string nombrePersona = Console.ReadLine();
            //Persona nuevaPersona = new Persona(nombrePersona);
            //personasRegistradas.Add(nuevaPersona);
        }

        public void BuscarPersonaPorNombre()
        {
            Console.WriteLine("¿Cómo se llama la persona a buscar?");
            string nombrePersona = Console.ReadLine();
            foreach(var persona in personasRegistradas)
            {
                if(persona.Name.Contains(nombrePersona))
                {
                    Console.WriteLine($"{persona.Id} - {persona.Name}");
                }
                
            }
        }

        public void ExaminarPersona()
        {
            Console.WriteLine("¿Cuál es el id de la persona a examinar?");
            int idExaminado = int.Parse(Console.ReadLine());
            foreach (var persona in personasRegistradas)
            {
                if(persona.Id == idExaminado)
                {
                    Console.WriteLine($"{persona.Id} - {persona.Name}");
                    if (persona.mascotas.Count == 0)
                    {
                        Console.WriteLine("Esta persona no posee mascotas");
                    }
                    else
                    {
                        foreach (var mascota in persona.mascotas)
                        {
                            Console.WriteLine($"{mascota.Id} - {mascota.Nombre} - {mascota.Especie}");
                        }
                    }
                }
                else
                {
                    bool buscar = true;
                    while (true)
                    {
                        Console.WriteLine("¿Desea realizar una búsqueda por nombre?");
                        Console.WriteLine("1)Si 2)No");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "1")
                        {
                            Console.WriteLine("¿Cómo se llama la persona a buscar?");
                            string nombrePersona = Console.ReadLine();
                            foreach (var _persona in personasRegistradas)
                            {
                                if (_persona.Name.Contains(nombrePersona))
                                {
                                    Console.WriteLine($"{_persona.Id} - {_persona.Name}");
                                    if (persona.mascotas.Count == 0)
                                    {
                                        Console.WriteLine("Esta persona no posee mascotas");
                                    }
                                    else
                                    {
                                        foreach (var mascota in persona.mascotas)
                                        {
                                            Console.WriteLine($"{mascota.Id} - {mascota.Nombre} - {mascota.Especie}");
                                        }
                                    }
                                   
                                }
                                else
                                {
                                    Console.WriteLine("No se ha encontrado a la persona por ese nombre");
                                    Console.WriteLine("¿Quiere intentarlo de nuevo?");
                                    Console.WriteLine("1)Si 2)No");
                                    string seleccion = Console.ReadLine();
                                    if (seleccion == "1")
                                    {
                                        buscar = true;
                                    }
                                    else if (seleccion == "2")
                                    {
                                        buscar = false;
                                        break;
                                    }
                                }

                            }
                        }
                    }
                    
                }
            }

        }
    }
}
