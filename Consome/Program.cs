// See https://aka.ms/new-console-template for more information
using System.Text.Json;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Publicacion { get; set; }
}

public class main
{
    static void Main(string[] args)
    {
        var Libros = new List<Libro>
        {
            new Libro
            {
                Titulo = "Cien anios de soledad",
                Autor = "García Márquez",
                Publicacion = 1967,
            },
            new Libro
            {
                Titulo = "1984",
                Autor = "George Orwell",
                Publicacion = 1949,
            },
        };

        var serializedJson = JsonSerializer.Serialize(Libros);
        Console.WriteLine(serializedJson);
    }
}
