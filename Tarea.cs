namespace Tarea;
public class Tarea
{
    private int tareaId;
    private string descripcion;
    private int duracion;

    public Tarea(int id, string desc, int duracion){
        tareaId=id;
        descripcion=desc;
        this.duracion=duracion;
    }
    public string Descrip => descripcion;
    public int Durac=> duracion;
    public int Ide => tareaId;
}