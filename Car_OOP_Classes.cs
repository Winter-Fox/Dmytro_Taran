using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Homework__variant_2_
{
    /** Basic class */
    abstract class Car
    {
        protected int HorsePower;
        public string ModelName;

        public abstract void StartEngine();
        protected virtual void InfuseFuel()
        {
            // Fuel infusion, Wrrrrrrrrrrrrr
        }
    }


    /** First branch of inheritance */
    abstract class ElectricCar : Car
    {
        public override void StartEngine() { }

        protected abstract void GivePower();
    }

    class Nissan : ElectricCar
    {
        public virtual void NissanGreetings() { }
        protected override void GivePower() { }
        private int DevelopmentIndex;
    }

    class NissanLeaf : Nissan
    {
        public override void NissanGreetings()
        {
            base.NissanGreetings();
            // Nissan Leaf additional greetings
        }
    }


    /** Second branch of inheritance */
    class MuscleCar : Car
    {
        public override void StartEngine() { }
        protected override void InfuseFuel()
        {
            base.InfuseFuel();
            // Infuse more fue here
        }
        private void MakeVroom() { } 
    }

    class Mustang : MuscleCar
    {
        // Does nothing. As any Mustang does.
    }
}
