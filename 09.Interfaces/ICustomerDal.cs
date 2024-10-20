﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");

        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");

        }

        public void Update()
        {
            Console.WriteLine("oracle updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
