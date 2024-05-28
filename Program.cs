using Tarea;
//creo listas de tareas 
List<Tarea> ListaTarea= new List<Tarea>;
List<Tarea> ListaTareaRealizadas= new List<Tarea>;
int option=0;
int opcion=0;
do
{
    Console.WriteLine("\n---------------Elija una opcion---------------\n");
    Console.WriteLine("1)Mover a lista de tareas realizadas");
    Console.WriteLine("2)Buscar tareas a pendientes");
    Console.WriteLine("3)Salir");
    option= Console.ReadLine();
    switch (opcion)
    {
        case 1:
        for (int i = 0; i < 5; i++)
        {
            ListaTareaRealizadas[i].Add(ListaTarea[i]);
        }
        break;
        case 2:
            int opcion1=0;
        do
        {
            Console.WriteLine("\n--------Buscar Tarea--------\n");
            console.WriteLine("1)Buscar");
            Console.WriteLine("\n2) Salir\n");
            switch (opcion1)
            {
                case 1:
                
                break;    
                default:
            }
        } while (opcion1 != 2); 
        break;
    }
} while (option != 3);