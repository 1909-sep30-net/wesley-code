﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DogApplication
{
    internal class Dog
    {
        //access modifiers
        //public - everyone can see
        //internal - everyone in the same assembly/project can see
        //protected - everyone who is a subclass of Dog can see (even if it is in another project)
        //private - only this class can see
        //protected internal
        //private protected

        //for class members, private is default
        //for classes, internal is default - only public and internal are even possible

        //constructor
        //there is always at least one constructor
        // if you dont write one, you get a default one like "Dog(){ }" (zero param, zero extra behavior)
        public Dog(string name, int age)
        {
            //within a class, "this" is a way to refer to the current instance of the class
            SetName(name);
            this.name = name;
            if(age < 0)
            {
                throw new ArgumentOutOfRangeException();
                //an exception is how we represent and handle "errors" during runtime
            }
            Age = age;
        }

        //fields
        private string name;
        private int age;

        //property
        //public int Age { get; set; ) // an auto property has a hidden backing field
        public int Age
        {
            get
            {
                return age; //the "backing field" of the property
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentNullException("name");
                }
                age = value;
            }
        }

        // ^ this is an "auto-property"


        //better than public fields, is getter and setter methods like java
        //but better than that (at least to use and look at) is properties

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            //validation goes here - this is public, field is private
            // all the "consumers" of this class dont have to worry about validating their
            //changes to the fields
            if (name == null)
            {

            }
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
