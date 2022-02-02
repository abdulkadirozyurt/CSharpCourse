using System;

namespace InterfacesDemo

{
    class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()

            };

            foreach (var worker in workers)
            {
                worker.Work();
                
            }

            Console.WriteLine("-------------");

            IEat[] eaters= new IEat[]
            {
                new Worker(),
                new Manager(),
                
            };

            foreach (var eater in eaters)
            {
                eater.Eat();
            }

            Console.WriteLine("-----------");

            IGetSalary[] getSalaries = new IGetSalary[]
            {
                new Manager(),
                new Worker()
            };

            foreach (var salary in getSalaries)
            {
                salary.GetSalary();
            }



        }
    }





    // ibrden fazla interface tanımlayabiliriz. 
    // Yönetici ve işçi çalışır yer maaş alır ama robot; çalışır,yemez, maaş almaz bu yüzden interface'lere ayırdık kodumuzu.



    interface IWorker
    {
        void Work();
       
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }


    class Manager : IWorker , IEat, IGetSalary
    {
        public void Work()
        {
            Console.WriteLine("Manager Worked");
        }
        public void Eat()
        {
            Console.WriteLine("Manager Ate");
        }
        public void GetSalary()
        {
            Console.WriteLine("Manager Got Salary");
        }
    }


    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker ate");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Got Salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker Worked");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Worked");
        }
       
    }







}