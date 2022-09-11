using System;
using System.Collections.Generic;
using System.Text;

//makes properties (class) public and make fields (variables) in private to protect your code - encapsulation

namespace ClassesAndObjects
{
    class Car
    {
        //public string brand;
        private int price;
        private int horsePower;

        public string Brand
        {   
           get; set; //automatic property
        }

        public int Price // <- this is the property named "Price"
        {
            get { return price; }
            set 
            {
                if(value <= 0) //value, which represents the value we assign to the property
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }

        public int HorsePower
        {
            set 
            {
                if (value <= 0) //value, which represents the value we assign to the property
                {
                    horsePower = 0;
                }
                else
                {
                    horsePower = value;
                }
            }
            get { return horsePower; }
        }

        public int Speed
        {
            set; get;
        }

        public int DecreaseSpeed(int brake)
        {
            Speed = Speed - brake;
            return Speed;
        }


    }

    class Motor
    {
        private int horsePowerMotor; //cannot access in other class
        private string type;
        
        private int Speed;        

        public int HorsePowerMotor
        {
            //get { return horsePowerMotor; }
            //set { horsePowerMotor = value; }
            set; get;
        }

        public string Type
        {
            set { type = value; }
            get { return type; }
        }

    }
}
