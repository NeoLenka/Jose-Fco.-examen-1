public class Libro : ILibro
{
    public int Codigo { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public float Precio { get; set; }
    public bool Disponible { get; set; }

    public void Prestar()
    {
        if (Disponible)
        {
            Disponible = false;
        }
        else
        {
            Console.WriteLine("El libro no está disponible.");
        }
    }

    public void Devolver()
    {
        if (!Disponible)
        {
            Disponible = true;
        }
        else
        {
            Console.WriteLine("El libro no está prestado.");
        }
    }

    public Libro Consultar(int codigo)
    {
        return this;
    }

    public override string ToString()
    {
        return $"Código: {Codigo}, Título: {Titulo}, Autor: {Autor}, Fecha de publicación: {FechaPublicacion}, Precio: {Precio}, Disponible: {Disponible}";
    }
}

public interface ILibro
{
    void Prestar();
    void Devolver();
    Libro Consultar(int codigo);
}

public class Biblioteca
{
    private List<Libro> libros;

    public Biblioteca()
    {
        libros = new List<Libro>();
    }

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void EliminarLibro(int codigo)
    {
        Libro libro = libros.FirstOrDefault(l => l.Codigo == codigo);
        if (libro != null)
        {
            libros.Remove(libro);
        }
        else
        {
            Console.WriteLine("El libro no existe.");
        }
    }

    public void MostrarLibros()
    {
        foreach (Libro libro in libros)
        {
            Console.WriteLine(libro);
        }
    }

    public void BuscarLibros(string texto)
    {
        var librosEncontrados = libros.FindAll(l => l.Titulo.Contains(texto) || l.Autor.Contains(texto));
        foreach (Libro libro in librosEncontrados)
        {
            Console.WriteLine(libro);
        }
    }

    public void MostrarLibroConMayorPrecio()
    {
        Libro libroConMayorPrecio = libros[0];
        foreach (Libro libro in libros)
        {
            if (libro.Precio > libroConMayorPrecio.Precio)
            {
                libroConMayorPrecio = libro;
            }
        }
        Console.WriteLine(libroConMayorPrecio);
    }

    public void MostrarTresLibrosMasBaratos()
    {
        var librosOrdenados = libros.OrderBy(l => l.Precio).Take(3);
        foreach (Libro libro in librosOrdenados)
        {
            Console.WriteLine(libro);
        }
    }

    public void BuscarLibrosPorInicioDelNombreDelAutor(string texto)
    {
        var librosEncontrados = libros.FindAll(l => l.Autor.StartsWith(texto, StringComparison.OrdinalIgnoreCase));
        foreach (Libro libro in librosEncontrados)
        {
            Console.WriteLine(libro);
        }
    }
}
class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        int opcion;
        do
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Agregar un libro a la biblioteca");
            Console.WriteLine("2. Eliminar un libro de la biblioteca");
            Console.WriteLine("3. Mostrar todos los libros de la biblioteca");
            Console.WriteLine("4. Prestar un libro");
            Console.WriteLine("5. Devolver un libro");
            Console.WriteLine("6. Consultar información de un libro");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:

                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
            }

        } while (opcion != 7);
    }

}
