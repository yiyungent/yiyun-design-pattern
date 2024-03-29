﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_浅复制
{
    class Resume : ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private string _timeArea;
        private string _company;

        public Resume(string name)
        {
            this._name = name;
        }

        public void SetPersonInfor(string sex, string age)
        {
            this._sex = sex;
            this._age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            this._timeArea = timeArea;
            this._company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", this._name, this._sex, this._age);
            Console.WriteLine("{0} {1}", this._timeArea, this._company);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
