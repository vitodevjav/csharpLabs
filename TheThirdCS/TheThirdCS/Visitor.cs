using System;
using System.Collections.Generic;
using System.Text;

namespace TheThirdCS
{
    class Visitor
    {
        private int age;
        private String  name;

        public Visitor(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public String getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public void EventHandler()
        { 
            Console.WriteLine(name + "has been recognized about event!\n");
        }

    }
}
