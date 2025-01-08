using System.Reflection;

namespace _16장
{
    internal class GetType
    {
        static void PrintInterfaces(Type type)
        {
            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance
                );

            foreach(FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";

                Console.WriteLine($"{accessLevel} : {field.FieldType.Name} : {field.Name}");
            }
            Console.WriteLine();
        }

        static void PrintMethods(Type type)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.Write($"Type: {method.ReturnType.Name} : Parameter : {method.Name}");
                ParameterInfo[] args = method.GetParameters();

                for (int i = 0; i < args.Length; i++)
                {
                       Console.Write($"{args[i].ParameterType.Name}");
                       if (i < args.Length - 1)
                           Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        static void PrintProperties(Type type)
        {
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"Type: {property.PropertyType.Name} : Name : {property.Name}");
            }
            Console.WriteLine();
        }
        static void MaiGetTypen(string[] args)
        {
            int a = 0;
            Type type = a.GetType();
            PrintInterfaces(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMethods(type);
        }
    }
}
