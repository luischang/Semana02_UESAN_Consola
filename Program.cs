// See https://aka.ms/new-console-template for more information
using Semana02_UESAN_Consola;

Console.WriteLine("Hello, World!");

string nombreCurso = "Desarrollo de aplicaciones web 2022-01";
int edad = 22;
double monto = 12.5;

var nombreAlumno = "Luis";
var peso = 60;

//List<Persona> listado = new List<Persona>();
var listado = new List<Persona>();


var persona = new Persona();
persona.dni = "12345678";
persona.nombreCompleto = "Luis";
persona.telefono = 99488484;

var persona2 = new Persona("22993300", "Juan", 99488421);

var persona3 = new Persona()
{
    dni = "66778899",
    nombreCompleto = "Pedro",
    telefono = 99488400
};

listado.Add(persona);
listado.Add(persona2);
listado.Add(persona3);

//Print listado personas
foreach (var item in listado)
{
    Console.WriteLine(item.dni + " - " + item.nombreCompleto + " - " + item.telefono);
}

var busqueda = listado.Find(search => search.dni == "66778899");
//Validar si es null
if (busqueda != null)
    Console.WriteLine(busqueda.dni + " - " + busqueda.nombreCompleto + " - " + busqueda.telefono);
else
    Console.WriteLine("No se encontro el registro");

Console.Write("Fin");