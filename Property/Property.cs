namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;
        
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get => birthday;
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    internal class Property
    {
        
        static void MainProperty(string[] args)
        {
            BirthdayInfo birth = new();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine($"{birth.Name}");
            Console.WriteLine(birth.Birthday.ToShortTimeString());
            Console.WriteLine(birth.Age);
        }
    }
}
