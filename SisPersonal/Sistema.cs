namespace Sistema
{
    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado
    {
        const int EDAD_JUBILACION = 65;
        private string nombre;//tambien se las puede definir como _nombre
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargo cargoSeleccionado;

        
        public string Nombre//se puede poner el mismo nombre pero siempre con mayusculas las propiedades de los campos
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public DateTime Fnacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public char EstadoCivil
        {
            get => estadoCivil;
            set => estadoCivil = value;
        }
        public DateTime Fingreso
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }
        public double Sueldo
        {
            get => sueldoBasico;
            set => sueldoBasico = value;
        }
        public Cargo Cseleccionado
        {
            get => cargoSeleccionado;
            set => cargoSeleccionado = value;
        }

          
        public int AntiguedadEmpleado()
        {
            DateTime hoy = DateTime.Now;
            int antiguedad = hoy.Year - fechaIngreso.Year;
            return(antiguedad);
        }
        public int EdadEmpleado()
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - fechaNacimiento.Year;
            return(edad);
        }
           
        public int Jubilacion(int antiguedad)
        {
            return(EDAD_JUBILACION - antiguedad);
        }
        public double Salario(int antiguedad, Cargo cargo, char estado, double sueldoBasico)
        {
            double salario = 0, adicional = 0;

            if (antiguedad <= 20)
            {
                adicional += antiguedad * 0.01;
            }else
            {
                adicional += 0.25;
            }
            if (cargo == Cargo.Ingeniero || cargo == Cargo.Especialista)
            {
                adicional += 0.50;
            }
            if (estado == 'A')
            {
                adicional += 0.50;
            }
            adicional = adicional * sueldoBasico;
            salario = sueldoBasico + adicional;
            return salario;
        }
    }
}