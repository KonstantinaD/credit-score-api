using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_10_ZooManagement
{
    abstract class Animal : IMover
    {
        protected string Description;

        public virtual string GetDescription()
        {
            return "Description is: " + Description;
        }

        public virtual void SetDescription(string description)
        {
            this.Description = description;
        }

        public abstract string Eat();

        public abstract string Move();
    }
}
