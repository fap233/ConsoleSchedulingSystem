// See https://aka.ms/new-cons
Console.WriteLine("My Scheduling System");

// 1. Create List
List<Scheduling> schedulingList = new List<Scheduling>();

// Create and Add "Ana Silva"
Scheduling newScheduling1 = new Scheduling();
newScheduling1.ClientName = "Ana Silva";
newScheduling1.Email = "anasilva@email.com";
newScheduling1.Phone = "40123456789";
newScheduling1.Schedule = new DateTime(2025, 10, 31, 14, 0, 0);

schedulingList.Add(newScheduling1);

//Create and Add "José Silva"
Scheduling newScheduling2 = new Scheduling();
newScheduling2.ClientName = "José silva";
newScheduling2.Email = "josesilva@email.com";
newScheduling2.Phone = "50123456789";
newScheduling2.Schedule = new DateTime(2025, 10, 31, 14, 0, 0);

// schedulingList.Add(newScheduling2);

bool horarioJaExiste = false;

foreach (Scheduling item in schedulingList)
{
    if (item.Schedule == newScheduling2.Schedule)
    {
        horarioJaExiste = true;
    }
}
if (horarioJaExiste == false)
{
  schedulingList.Add(newScheduling2);
  Console.WriteLine($"Agendamento para {newScheduling2.ClientName} adicionado!");
}
else
{
  Console.WriteLine($"Agendamento para {newScheduling2.ClientName} não pode ser adicionado, horário já existe!");
}

//Print Data
Console.WriteLine("---Novo Agendamento Criado ---");
ShowAllScheduling(schedulingList);

static void ShowAllScheduling(List<Scheduling> listToShow)
{
  foreach (Scheduling item in listToShow)
  {
    Console.WriteLine($"Cliente: {item.ClientName}, Email: {item.Email}, Horário: {item.Schedule}");
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
