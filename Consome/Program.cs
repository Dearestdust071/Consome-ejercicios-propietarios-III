using System.Numerics;

public interface IEmpleado
{
    public void CalcularSalario();
    public void MostrarInformacion();
}

public abstract class Empleado : IEmpleado
{
    protected int id;
    protected string nombre;
    protected double salarioBase;

    public Empleado(int Id, string Nombre, double SalarioBase)
    {
        id = Id;
        nombre = Nombre;
        salarioBase = SalarioBase;
    }

    public abstract void CalcularSalario();

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre del empleado es: {nombre}\nEl id del empleado es {id}");
    }
}

public class EmpleadoTiempoCompleto : Empleado
{
    public double bono;

    public EmpleadoTiempoCompleto(double Bono, int Id, string Nombre, double SalarioBase)
        : base(Id, Nombre, SalarioBase)
    {
        bono = Bono;
    }

    public override void CalcularSalario()
    {
        Console.WriteLine($"El salario del empleado (a tiempo completo) es de: ${(salarioBase + bono).ToString("N2")}");
        // Ya copie como hacer lo de los separadores de miles de una pagina 
    }
}

public class EmpleadoMedioTiempo : Empleado
{
    public int horasTrabajadas;

    private const double tarifaPorHora = 80.33;

    public EmpleadoMedioTiempo(int HorasTrabajadas, int Id, string Nombre, double SalarioBase)
        : base(Id, Nombre, SalarioBase)
    {
        horasTrabajadas = HorasTrabajadas;
    }

    public override void CalcularSalario()
    {
        Console.WriteLine(
            $"El salario del empleado  (a tiempo parcial) es de: ${(horasTrabajadas * tarifaPorHora).ToString("N2")}"
        );
    }
}

public class main
{
    static void Main(string[] args)
    {
        List<IEmpleado> empleados = new List<IEmpleado>
        {
            new EmpleadoMedioTiempo(12, 1, "Jose", 3130.22),
            new EmpleadoTiempoCompleto(200.22, 2, "Maria", 2200.10),
        };

        // Aqui va una impresion importante
        Console.WriteLine("****************************************************************");
        Console.WriteLine("Tengo que salir el fin de semana asi que la tarea la hice HOY");
        Console.WriteLine("****************************************************************");

// Agh como le hizo para imprimir con los separadores de miles su numero

        foreach (IEmpleado empleado in empleados)
        {
            Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
            empleado.MostrarInformacion();
            empleado.CalcularSalario();
        }
    }
}
