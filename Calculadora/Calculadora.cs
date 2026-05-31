namespace EspacioCalculadora
{
    public class Calculadora
    {
        double dato;//atributo o campo
        public void Sumar(double termino)//los metodos son estas funciones
        {
            dato += termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            dato *= termino;
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }else
            {
                dato = 0;
            }
        }

        public void Limpiar()
        {
            dato = 0;
        }

        public double Resultado//propiedad
        {
            get => dato;
        }
    }
}
