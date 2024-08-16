class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        string command = "";
        while (command != "exit")
        {
            System.Console.WriteLine("Buyruq kiriting (add, view, delete, exit):");
            command = Console.ReadLine()!;
            switch (command)
            {
                case "add":
                    AddStudent();
                    break;
                case "view":
                    ViewStudent();
                    break;
                case "delete":
                    DeleteStudent();
                    break;
                case "exit":
                    System.Console.WriteLine("Dasturdan chiqilmoqda...");
                    break;
                default:
                    System.Console.WriteLine("Noto'g'ri buyruq.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        System.Console.Write("Talabaning ismi: ");
        string name = Console.ReadLine()!;
        System.Console.Write("Talaba yoshi: ");
        int age = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Talabaning ID raqamini kiriting: ");
        int id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Talabaning passport raqamini kiriting: ");
        int passport = Convert.ToInt32(Console.ReadLine()!);
        System.Console.WriteLine("Gender kiriting: ");
        string gender = Console.ReadLine()!;

        students.Add(new Student(name, age, id, passport, gender));
        System.Console.WriteLine("Talaba qo'shildi.");
    }

    static void ViewStudent()
    {
        System.Console.WriteLine("Talabalar ro'yxati: ");
        for (int i = 0; i < students.Count; i++)
        {
            System.Console.WriteLine($"{i + 1}. Ismi: {students[i].Name}\n Yoshi: {students[i].Age}\n ID: {students[i].ID}\n Passport raqami: {students[i].Passport}\n Gender: {students[i].Gender}");
        }
    }

    static void DeleteStudent()
    {
        ViewStudent();
        System.Console.Write("O'chirish uchun talaba raqamini kiriting: ");
        int studentNumber = Convert.ToInt32(Console.ReadLine());
        if (studentNumber > 0 && studentNumber <= students.Count)
        {
            students.RemoveAt(studentNumber - 1);
            System.Console.WriteLine("Talaba o'chirildi.");
        }
        else
        {
            System.Console.WriteLine("Noto'g'ri raqam.");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
        public int Passport { get; set; }
        public string Gender { get; set; }

        public Student(string name, int age, int id, int passport, string gender)
        {
            Name = name;
            Age = age;
            ID = id;
            Passport = passport;
            Gender = gender;
        }
    }
}

