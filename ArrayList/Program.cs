using System;
using System.Collections;
namespace ArrayLists
{
    public class ArrayList1
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            int t = Convert.ToInt32(Console.ReadLine()) ;
            for (int i = 0; i < t; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                list.Add(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public override string ToString()
            {
                return Name + " - " + Age;
            }
        }
    }
}
