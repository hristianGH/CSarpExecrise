using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace _1.Stealer
{
    public class Spy
    {
        public Spy()
        {
            Answers = new StringBuilder();
        }
        public StringBuilder Answers { get; set; }
        public string StealFieldInfo(string className, params string[] fieldNames)
        {
            string namescs = typeof(Spy).Namespace;
            var type = Type.GetType($"{namescs}." + className);
            if (type != null)
            {
                Answers.AppendLine($"Class under investigation: {className}");
                foreach (var item in fieldNames)
                {
                    string name = type.GetField(item, BindingFlags.Public |
                                                      BindingFlags.NonPublic |
                                                      BindingFlags.Instance).Name;
                    object instance = Activator.CreateInstance(type);
                    string value = type.GetField(item, BindingFlags.Public |
                                                      BindingFlags.NonPublic |
                                                      BindingFlags.Instance).GetValue(instance).ToString();
                    Answers.AppendLine($"{name} = {value}");
                }
            }
            return Answers.ToString();
        }
        public string AnalyzeAcessModifiers(string className)
        {
            string namescs = typeof(Spy).Namespace;
            var type = Type.GetType($"{namescs}." + className);
            Answers = new StringBuilder();
            if (type != null)
            {
                FieldCheck(type);
                MethodCheck(type);
            }
            return Answers.ToString();
        }
        private void FieldCheck(Type type)
        {
            foreach (var item in type.GetFields())
            {
                if (item.Attributes.ToString().ToLower() != "private")
                {
                    Answers.AppendLine($"{item.Name} must be private!");
                }
            }
            //•	Fields private
            //must be private!
        }
        private void MethodCheck(Type type)
        {
            foreach (var item in type.GetMethods(BindingFlags.Public |
                                                 BindingFlags.NonPublic |
                                                 BindingFlags.Instance))
            {
                string[] name = item.Name.ToString().Split("_");
                string atributes = item.Attributes.ToString().Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];

                if (name[0] == "get" && atributes.ToLower() != "public")
                {
                    Answers.AppendLine($"{item.Name} have to be public!");
                }
                else if (name[0] == "set" && atributes.ToLower() != "private")
                {
                    Answers.AppendLine($"{item.Name} have to be private!");

                }
                //•	Getters public
                //•	Setters private
            }
        }

        public string RevealPrivateMethods(string className)
        {
            string namescs = typeof(Spy).Namespace;
            var type = Type.GetType($"{namescs}." + className);
            if (type != null)
            {

                Answers = new StringBuilder();
                Answers.AppendLine($"All Private Methods of Class: {className}");
                Answers.AppendLine($"Base Class: { type.BaseType.Name}");

                foreach (var item in type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    Answers.AppendLine(item.Name);
                }
                return Answers.ToString();
            }
            else
            {
                return null;
            }
            //All Private Methods of Class: {className}
            //Base Class: { baseClassName}


        }
        public string CollectGettersAndSetters(string className)
        {
            string namescs = typeof(Spy).Namespace;
            var type = Type.GetType($"{namescs}." + className);
            if (type == null)
            {

            }
            Answers = new StringBuilder();
            StringBuilder second = new StringBuilder();

            foreach (var item in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (item.Name.Split("_")[0].ToLower() == "get")
                {
                    Answers.AppendLine($"{item.Name} will return {item.ReturnType}");

                }
                else if (item.Name.Split("_")[0].ToLower() == "set")
                {
                    second.AppendLine($"{item.Name} will set field of {item.GetParameters()[0].ParameterType}");

                }
            }
            return $"{Answers}{second}";
        }
    }
}
