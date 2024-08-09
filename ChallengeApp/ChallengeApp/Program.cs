using ChallengeApp;

Employee user1 = new Employee("Marcin", "Bujnowski", 33);
Employee user2 = new Employee("Marta", "Wojtczak", 26);
Employee user3 = new Employee("Irena", "Karpiuk", 56);



user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(7);
user1.AddScore(4);
user1.AddScore(9);

user2.AddScore(6);
user2.AddScore(3);
user2.AddScore(9);
user2.AddScore(1);
user2.AddScore(5);

user3.AddScore(1);
user3.AddScore(6);
user3.AddScore(8);
user3.AddScore(3);
user3.AddScore(2);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = 0;
Employee userWithMaxResult = null;
foreach (var employee in users)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        userWithMaxResult = employee;
    }
}

Console.WriteLine(userWithMaxResult.Name);
Console.WriteLine(userWithMaxResult.Surname);
Console.WriteLine("Wiek:  " + userWithMaxResult.Age);
Console.WriteLine("Wynik:  " +userWithMaxResult.Result);