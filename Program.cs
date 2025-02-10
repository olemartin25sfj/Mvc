namespace Mvc;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model("John Doe", 47);
        View view = new View();

        Controller controller = new Controller(model, view);

        controller.ShowModel();

        controller.UpdateName();

        controller.UpdateAge();

        controller.ShowModel();

        Console.ReadLine();

    }
}
