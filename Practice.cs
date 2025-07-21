class PracticePrograms
{
    static void Main()
    {
        var students = new Dictionary<int, string>();
        while (true)
        {
            Console.WriteLine("1. Add  2. Delete  3. View  4. Update  5. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int id = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    students[id] = name;
                    break;

                case 2:
                    id = int.Parse(Console.ReadLine());
                    students.Remove(id);
                    break;

                case 3:
                    foreach (var s in students)
                        Console.WriteLine($"{s.Key}: {s.Value}");
                    break;

                case 4:
                    id = int.Parse(Console.ReadLine());
                    if (students.ContainsKey(id))
                        students[id] = Console.ReadLine();
                    break;

                case 5:
                    return;
    }
}}}
    