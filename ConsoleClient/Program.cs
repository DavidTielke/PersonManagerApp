namespace ConsoleClient
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

        public Person()
        {
            
        }
        public Person(string name, int age, int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = File
                .ReadAllLines("data.csv")
                .Select(l => l.Split(","))
                .Select(p => new Person
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    Age = int.Parse(p[2])
                })
                .ToList();

            var adults = persons.Where(p => p.Age >= 18).ToList();
            Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
            adults.ForEach(a => Console.WriteLine($"{a.Id}: {a.Name}, {a.Age} Jahre"));
            
            var children = persons.Where(p => p.Age < 18).ToList();
            Console.WriteLine($"### Kinder ({children.Count}) ###");
            children.ForEach(c => Console.WriteLine($"{c.Id}: {c.Name}, {c.Age} Jahre"));
        }
    }
}
