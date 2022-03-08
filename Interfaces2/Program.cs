using System;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interface'ler new'lenemez

                        
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
            projectManager.Update(new InternManager());

            



        }


        interface IPersonManager
        {
            //unimplemented operation
            void Add();
            void Update();
        }

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Müşteri Eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri Güncellendi");
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
                Console.WriteLine("Personel Güncellendi");
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
                Console.WriteLine("Stajyer Güncellendi");
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
                

            }

            public void Update(IPersonManager personManager)
            {
                personManager.Update();
            }


            
        }
    }
}
