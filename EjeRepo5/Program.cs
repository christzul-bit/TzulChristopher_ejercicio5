//Ejercicio con repositorio 5
Console.WriteLine("Seleccione el tipo de solicitante \n" +
    "1)Empleado fijo \n" +
    "2)Empleado temporal \n" +
    "3)Empleado Independiente \n" +
    "4)Estudiante_");
int usuario = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su ingreso mensual_");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su antigüedad laborar en meses_");
int antiguo = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto del prestamo_");
double monto = double.Parse(Console.ReadLine());
Console.WriteLine("Como ha estado su historial crediticio? \n" +
    "1)Excelente \n" +
    "2)Bueno \n" +
    "3)Regular \n" +
    "4)Malo_");
int historial = int.Parse(Console.ReadLine());
Console.WriteLine("TIene un fiador? (s/n)_");
string fiador = Console.ReadLine();

