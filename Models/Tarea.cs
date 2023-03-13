using System;
using System.Collections.Generic;

namespace Test_Dev_JR.Models;

public partial class Tarea
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime FechaTareaRegistro { get; set; }

    public bool TareaCompletada { get; set; }

    public DateTime? FechaTareaCompletada { get; set; }
}
