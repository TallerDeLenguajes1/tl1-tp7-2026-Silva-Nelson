using Sistema;

Empleado[] empleados = new Empleado[3];

string? entrada;
DateTime fechaConvertida;
int cargo, edad, antiguedad, jubilacion;
double sueldo = 0, salario, total = 0;

for (int i = 0; i < empleados.Length; i++)
{
    empleados[i] = new Empleado();

    Console.WriteLine("Ingrese un nombre:");
    entrada = Console.ReadLine();
    empleados[i].Nombre = entrada;
    

    Console.WriteLine("Ingrese su apellido:");
    entrada = Console.ReadLine();
    empleados[i].Apellido = entrada;

    Console.WriteLine("Ingrese su fecha de nacimiento:");
    entrada = Console.ReadLine();
    fechaConvertida = DateTime.Parse(entrada);
    empleados[i].Fnacimiento = fechaConvertida;

    Console.WriteLine("Ingrese su estado civil:");
    Console.WriteLine("A : Casado");
    Console.WriteLine("B : Viudo");
    Console.WriteLine("C : Divorsiado");
    Console.WriteLine("D : Soltero");
    entrada = Console.ReadLine();
    empleados[i].EstadoCivil = char.Parse(entrada);
        

    Console.WriteLine("Ingrese la fecha de ingreso a la empresa:");
    entrada = Console.ReadLine();
    fechaConvertida = DateTime.Parse(entrada);
    empleados[i].Fingreso = fechaConvertida;

    Console.WriteLine("Ingrese su sueldo basico");
    entrada = Console.ReadLine();
    double.TryParse(entrada, out sueldo);
    empleados[i].Sueldo = sueldo;

    Console.WriteLine("Ingrese su cargo:");
    Console.WriteLine("0_ Auxiliar");
    Console.WriteLine("1_ Administrativo");
    Console.WriteLine("2_ Ingeniero");
    Console.WriteLine("3_ Especialista");
    Console.WriteLine("4_ Investigador");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out cargo);
    empleados[i].Cseleccionado = (Cargo)cargo;
}

/*Metodos*/
for (int i = 0; i < empleados.Length; i++)
{
    edad = empleados[i].EdadEmpleado();
    antiguedad = empleados[i].AntiguedadEmpleado();
    jubilacion = empleados[i].Jubilacion(antiguedad);
    salario = empleados[i].Salario(antiguedad, empleados[i].Cseleccionado, empleados[i].EstadoCivil, empleados[i].Sueldo);
    
    if (antiguedad > 5)
    {
        Console.WriteLine($"Nombre del empleado : {empleados[i].Nombre}");
        Console.WriteLine($"Apellido del empleado : {empleados[i].Apellido}");
        Console.WriteLine($"Edad del empleado : {edad}");
        Console.WriteLine($"Fecha de nacimiento del empleado : {empleados[i].Fnacimiento}");
        Console.WriteLine($"Estado civil del empleado : {empleados[i].EstadoCivil}");
        Console.WriteLine($"Fecha de ingreso a la empresa : {empleados[i].Fingreso}");
        Console.WriteLine($"Sueldo del empleado : {empleados[i].Sueldo}");
        Console.WriteLine($"Cargo del empleado : {empleados[i].Cseleccionado}");
        Console.WriteLine($"Antiguedad del empleado : {antiguedad}");
        Console.WriteLine($"Años para la jubilacion : {jubilacion}");
        Console.WriteLine($"Salario del empleado : {salario}");
    }

    total += salario;
}
Console.WriteLine($"Total de dinero en salarios: {total}");