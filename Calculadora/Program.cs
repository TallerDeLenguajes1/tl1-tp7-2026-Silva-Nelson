using EspacioCalculadora;

Calculadora calcular = new Calculadora();

string? entrada1;
double num1, num2;
bool primeraOperacion = true;
do
{
    Console.WriteLine("Ingrese un numero para la operacion que desee realizar");
    Console.WriteLine("1_ Sumar numeros");
    Console.WriteLine("2_ Restar numeros");
    Console.WriteLine("3_ Multiplicar numeros");
    Console.WriteLine("4_ Dividir numeros");
    Console.WriteLine("5_ Limpiar");

    entrada1 = Console.ReadLine();
    if (double.TryParse(entrada1, out num1))
    {
        do
        {    
            Console.WriteLine("Ingrese un numero:");
            entrada1 = Console.ReadLine();
        } while (double.TryParse(entrada1, out num2) != true);
        
        if (primeraOperacion)//control para la primera operacion
        {
            calcular.Sumar(num2);
            primeraOperacion = false;
        }else
        {        
            switch (num1)
            {
                case 1: 
                    calcular.Sumar(num2);
                break;
                case 2:
                    calcular.Restar(num2);
                break;
                case 3:
                    calcular.Multiplicar(num2);
                break;
                case 4:
                    calcular.Dividir(num2);
                break;
                case 5:
                    calcular.Limpiar();
                break;
                default:
                    Console.WriteLine("Algo salio mal.");
                break;
            }
            Console.WriteLine($"El resultado es: {calcular.Resultado}");
        }
    }else
    {
        Console.WriteLine("El dato ingresado no es valido.");   
    }
    Console.WriteLine("Si desea continuar con las operaciones ingrese un numero cualquiera para continuar.Ingrese una letra de lo contrario");
    entrada1 = Console.ReadLine();
} while (double.TryParse(entrada1, out num1));