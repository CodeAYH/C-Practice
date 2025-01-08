using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _16장
{
    class Profile
    {
        private string name;
        private string phone;
        public Profile()
        {
            name = ""; phone = "";
        }

        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"{name} : {phone}");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
    internal class DynamicInstance
    {
        static void MainDynamicInstance()
        {
            Type type = Type.GetType("DynimicInstance.Porfile");
            MethodInfo methodInfo = type.GetMethod("Print");
            PropertyInfo nameProperty = type.GetProperty("Name");
            PropertyInfo phoneProperty = type.GetProperty("Phone");

            object profile = Activator.CreateInstance(type, "박상현", "512-1234");
            methodInfo.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            nameProperty.SetValue(profile, "박찬호", null);
            phoneProperty.SetValue(profile, "999-12111", null);



        }
    }
}
