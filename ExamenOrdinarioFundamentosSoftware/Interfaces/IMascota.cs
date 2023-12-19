using ExamenOrdinarioFundamentosSoftware.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenOrdinarioFundamentosSoftware.Clases;

public interface IMascota
{
    string Id { get; }
    string Nombre { get; }
    int Edad { get; }
    Temperamento Temperamento { get; }
    Especie Especie { get; }
    Persona Dueño { get; }

    void HacerRuido();
    void CambiarDueño(Persona nuevoDueño);
    void SerAcariciado;
}
