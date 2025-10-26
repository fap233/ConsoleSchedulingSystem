// See https://aka.ms/new-cons
Console.WriteLine("My Scheduling System");

// 1. Create List
List<Scheduling> schedulingList = new List<Scheduling>();

while (true)
{
    Console.WriteLine("\n--- Main Menu ---");
    Console.WriteLine("1. Add Scheduling");
    Console.WriteLine("2. Show All Scheduling");
    Console.WriteLine("3. Exit");
    Console.Write("Select an option: ");

    string option = Console.ReadLine();

    if (option == "1")
    {
        Console.Write("Enter Client Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Phone: ");
        string phone = Console.ReadLine();

        Console.Write("Scheduling date (ex: 14): ");
        int hour = Convert.ToInt32(Console.ReadLine());

        Scheduling userScheduling = new Scheduling();
        userScheduling.ClientName = name;
        userScheduling.Email = email;
        userScheduling.Phone = phone;
        userScheduling.Schedule = new DateTime(2025, 10, 31, hour, 0, 0);

        AddScheduling(schedulingList, userScheduling);
    }
    else if (option == "2")
    {
        Console.WriteLine("\n--- All Schedulings ---");
        ShowAllScheduling(schedulingList);
    }
    else if (option == "3")
    {
        Console.WriteLine("Exiting...");
        break;
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
}

//Print Data
Console.WriteLine("---Novo Agendamento Criado ---");
ShowAllScheduling(schedulingList);

// Add Scheduling with conflict verification
static void AddScheduling(List<Scheduling> list, Scheduling schedulingToAdd)
{
    // conflict verification
    bool dateAlreadyTaken = false;

    foreach (Scheduling item in list)
    {
        if (item.Schedule == schedulingToAdd.Schedule)
        {
            dateAlreadyTaken = true;
        }
    }

    // add decision (if flag is false)
    if (dateAlreadyTaken == false)
    {
        list.Add(schedulingToAdd);
        Console.WriteLine($"Agendamento para {schedulingToAdd.ClientName} adicionado!");
    }
    else
    {
        Console.WriteLine(
            $"Agendamento para {schedulingToAdd.ClientName} não pode ser adicionado, horário já existe!"
        );
    }
}

// Show all Scheduling
static void ShowAllScheduling(List<Scheduling> listToShow)
{
    foreach (Scheduling item in listToShow)
    {
        Console.WriteLine(
            $"Cliente: {item.ClientName}, Email: {item.Email}, Horário: {item.Schedule}"
        );
    }
}

//Class Definition
class Scheduling
{
    public int Id { get; set; }
    public string ClientName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime Schedule { get; set; }
}
