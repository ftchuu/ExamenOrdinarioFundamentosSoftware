using System;

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
