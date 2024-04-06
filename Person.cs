using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class_Extention
{
    public  class Person
    {
        private static int _id=0;
        public  int Id { get; }
        public string FullName { get; set; }
        public double Cash { get; set; }
        
        public sbyte Age
        {
            get
            {
                return Age;
            }
            set
            {
                if(value>0 && value < 125)
                {
                    Age = value;
                }
            }
        }
        public Person(string fullName,double cash,sbyte age)
        {
           
            Id == _id++;
            FullName = fullName;
            Cash = cash;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id:{_id},FullName:{FullName},Cash:{Cash},Age:{Age}";
        }
    }
}
