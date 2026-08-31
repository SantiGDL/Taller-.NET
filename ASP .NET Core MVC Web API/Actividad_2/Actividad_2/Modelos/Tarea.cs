using System.ComponentModel.DataAnnotations;

namespace Actividad_2.Modelos;

public class Tarea
{
    public int Id { get; set; }
    [Required]
    public string? Nombre { get; set; }
    [Required]
    public string? Desc { get; set; }
    [Range (1, 100)]
    public int DuracionHoras { get; set; }
    [Required]
    public string? Responsable { get; set; }
    [Required]
    public DateOnly Fecha { get; set;}

    //Constructor por parametros
    public Tarea(int id, string nombre, string desc, int duracionHoras, string responsable, DateOnly fecha)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Desc = desc;
        this.DuracionHoras = duracionHoras;
        this.Responsable = responsable;
        this.Fecha = fecha;
    }
    
    //Constructor vacío

    public Tarea()
    {
        
    }
    
}




/*
<-- Diferentes formas de escribir setters y getters -->

//<--Forma 1-->
//Setter y Getter de id como en java:

public void SetId(int value)
{
    this.id = value;
}

public int GetId()
{
    return this.id;
}

//<--Forma 2-->
//Setter y Getter de nombre como en C# opcion 1:
public string Nombre
{
    set { nombre = value; }
    get { return nombre; }
}

//<--Forma 3-->
//Setter y Getter de desc como en C# opcion 2:

public string desc { get; set; }

//no lo hace publico al atributo como tal, es equivalente a escribir la opcion 1 pero abreviada

*/

