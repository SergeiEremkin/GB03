using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_04
{
    class Building
    {
    
        private int _id;
        private int _height;
        private int _floor;
        private int _apartment;
        private int _front;
        private static int _idCounter = 1;


        public int ID

        {
            get

            {
                return _id;
            }

            set

            {
                _id = value;
            }
             
        }

        public int Height

        {
            get

            {
                return _height;
            }

            set

            {
                _height = value;
            }
        }

        public int Floor

        {
            get

            {
                return _floor;
            }

            set

            {
                _floor = value;
            }
        }


        public int Apartment

        {
            get

            {
                return _apartment;
            }

            set

            {
                _apartment = value;
            }
        }


        public int Front

        {
            get

            {
                return _front;
            }

            set

            {
                _front = value;
            }

        }
        

        public Building() : this (1)

        {

        }

        public Building(int hight) : this (1 , 1000)

        {
            
        }

        public Building (int hight, int floor) : this (1, 3000, 5 )

        {
            
        }

        public Building(int hight, int floor, int apartment) : this (0, 3000, 5, 20)

        {

        }

        public Building (int hight, int floor, int apartment, int front)

        {
            idCounter();
            Height = hight;
            Floor = floor;
            Apartment = apartment;
            Front = front;
        }


        // Cделал на выход интовые значения. Может в дальшейщем понадобятся данные значения.

        public int HeightStage()

        {
            Console.WriteLine($"Высота этажа: {Apartment / Front}");

            return Apartment / Front;
        }

        public int ApartmentsOnFront()

        {
            Console.WriteLine($"Колличество квартир в парадной: {Apartment / Front}");

            return Apartment / Front;

        }

        public int ApartmentsOnStage()

        {
            Console.WriteLine($"Колличество квартир на этаже: {Apartment / Front}");

            return Apartment / Front;
        }


        private void idCounter()

        {
            
            ID = _idCounter++;

        }



    }
}

