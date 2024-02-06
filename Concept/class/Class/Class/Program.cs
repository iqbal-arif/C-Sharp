internal class Program
{

    public class Person
    {
        public string Name;

        public void Introduce (string to)
        {
            Console.WriteLine("Hi {0}, Iam {1}",to, Name );
        }

        //Static Method
        public static   Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
     static void Main(string[] args)
    {
        Console.WriteLine("Class!\n");

        //Instance of Class Person
        var person = new Person();
        person.Name = "Arif Iqbal";
        person.Introduce("John");

        //Static Method of Class Person
        var person2 = Person.Parse("Mosh");
        person2.Introduce("ArifIqbal");
    }
}