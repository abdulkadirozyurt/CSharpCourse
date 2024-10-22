using System;

namespace _14.InterfacesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager[] personManagers = new IPersonManager[]
            {
                new CustomerManager(),
                new EmployeeManager(),
            };

            foreach (var personManager in personManagers)
            {
                personManager.Add();
                personManager.Update();
            }

            Console.WriteLine();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
        }
    }


    interface IPersonManager
    {
        // unimplemented operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        // implemented operation
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}