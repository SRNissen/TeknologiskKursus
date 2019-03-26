using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();


            Console.WriteLine("\n--------------------Ten people 'A'");
            var A = r.Get10People();
            foreach (var item in A)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n--------------------'A' sorted by name");
            A = A.OrderBy(i => i.Name).ToList();
            foreach (var item in A)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("\n--------------------Ten people 'B'");
            var B = r.Get10People();
            foreach (var item in B)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n--------------------'B' sorted by Gender, then by Name");
            B = B.OrderBy(i => i.Gender).ThenBy(i => i.Name).ToList();
            foreach (var item in B)
            {
                Console.WriteLine($"{item.Name} is {item.Gender}");
            }


            Console.WriteLine("\n--------------------100 people 'C' filtered by height>170 and isHealthy==true");
            var C = r.GetPeople(100).Where(i => i.Height > 170 && i.IsHealthy == true);
            foreach (var item in C)
            {
                Console.WriteLine($"{item.Name} is {item.Height} and it is {item.IsHealthy} that they are healthy");
            }


            Console.WriteLine("\n--------------------20 people 'D' Ordered by gender");
            var D = r.GetPeople(20).GroupBy(i => i.Gender);
            foreach (var Group in D)
            {
                foreach (var person in Group)
                {
                    Console.WriteLine($"{person.Name} is {person.Gender}");
                }
            }

            Console.WriteLine("\n--------------------20 people 'E' Ordered by name in anonymous objects");
            var E = r.GetPeople(20);
            var Ea = E.OrderBy(i => i.Name).Select(i => new { i.Name, i.Height });
            foreach (var person in Ea)
            {
                Console.WriteLine($"{person.Name} is {person.Height} cm");
            }


            Console.WriteLine("\n--------------------20 people 'F' Ordered grouped by 10 cm height increases");
            int[] range = { 150, 160, 170, 180, 190, 200, 210, 220 };
            var F = r.GetPeople(20);
            var Fo = F.OrderBy(i => i.Height).GroupBy(i => { return range.FirstOrDefault(x => x > i.Height) - 10; });
            foreach (var group in Fo)
            {
                Console.WriteLine($"Group: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"{person.Name} is {person.Height} cm");
                }
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
