﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Person
    {
        private string _name;

        public Person()
        { }

        public Person(string name)
        {
            this._name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装饰的是:{0}", this._name);
        }
    }
}
