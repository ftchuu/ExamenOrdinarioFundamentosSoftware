using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMascota
{
    string Id { get; }
    string Nombre { get; }
    int Edad { get; }
    Temperamento Temperamento { get; }
    Dueño Dueño { get; }

    void HacerRuido();
    void CambiarDueño(Dueño nuevoDueño);
}
