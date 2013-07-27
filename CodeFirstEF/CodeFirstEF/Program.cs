using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
/*
 * My implementation of the tutorial http://msdn.microsoft.com/en-us/data/jj193542
 */
namespace CodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SandboxContext())
            {
                Console.Write("Enter a name for a new toy: ");
                var name = Console.ReadLine();

                var toy = new Toy { Name = name };
                db.Toys.Add(toy);
                db.SaveChanges();

                var toys = db.Toys.Select(x => x.Name).ToList();
                foreach (string t in toys)
                    Console.WriteLine(t);

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Sandbox
    {
        public int SandboxID { get; set; }
        public string Name { get; set; }
        public bool IsFun { get; set; }

        public virtual List<Toy> Toys { get; set; } 
    }

    public class Toy
    {
        public int ToyID { get; set; }
        public string Name { get; set; }
    }

    public class SandboxContext : DbContext
    {
        public DbSet<Sandbox> Sandboxes { get; set; }
        public DbSet<Toy> Toys { get; set; } 
    }
}
