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
if(salario > 0 && antiguo >= 0 && monto > 0 && fiador == "s" || fiador == "n" && historial >= 1 && historial <= 4)
{
    switch (usuario)
    {
        case 1:
            if(salario > 2000 || antiguo > 6 || historial < 4)
            {
                Console.WriteLine("Prestamo aprovado");
            }else if(fiador == "s" && monto < 8000)
            {
                Console.WriteLine("Prestamo valido con condiciones, pagar en plazo de 1 año");
            }else
            {
                Console.WriteLine("Prestamo denegado, salario por debajo de 2000, menos de 6 mese trabajando \n" +
                    "historial deficiente, sin fiador o prestamo mul alto");
            }break;
        case 2:
            if (salario > 3500 || antiguo > 3 || historial < 3)
            {
                Console.WriteLine("Prestamo aprovado");
            }
            else if (fiador == "s" && monto < 5000)
            {
                Console.WriteLine("Prestamo valido con condiciones, pagar en plazo de 7 meses");
            }
            else
            {
                Console.WriteLine("Prestamo denegado, salario por debajo de 3500, menos de 3 mese trabajando \n" +
                    "historial deficiente, sin fiador o prestamo muy alto");
            }
            break;
        case 3:
            if (salario > 3000 || historial < 3 && monto < 5000)
            {
                Console.WriteLine("Prestamo aprovado");
            }
            else if (fiador == "s" && monto < 7000)
            {
                Console.WriteLine("Prestamo valido con condiciones, pagar en plazo de 6 meses");
            }
            else
            {
                Console.WriteLine("Prestamo denegado, salario por debajo de 3000 \n" +
                    "historial deficiente, sin fiador o prestamo muy alto");
            }
            break;
        case 4:
            if (salario > 500 || historial < 4 && monto < 5000)
            {
                Console.WriteLine("Prestamo aprovado");
            }
            else if (fiador == "s" && monto < 6000)
            {
                Console.WriteLine("Prestamo valido con condiciones, pagar en plazo de 1 año");
            }
            else
            {
                Console.WriteLine("Prestamo denegado, salario por debajo de 500 \n" +
                    "historial deficiente, sin fiador, prestamo muy alto");
            }
            break;
        default: Console.WriteLine("Opcion invalida"); break;
    }
}else
{
    Console.WriteLine("Verifique los valores ingresados en Salario, Meses de antigüedad, historial crediticio, monto o fiador");
}
