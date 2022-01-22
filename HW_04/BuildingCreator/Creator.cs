using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_04
{
      public class Creator : Building
    {

        private static Building _building = new Building();
        private static Hashtable _data = new Hashtable();
        private static int _key = 1;

        public static Building Building

        {
            get

            {

                return _building;

            }

            set

            {
                _building = value;
            }
        }

        private static Hashtable Data

        {
            get

            {

                return _data;

            }

            set

            {
                _data = value;
            }
        }

        public static int Key

        {
            get

            {

                return _key;

            }

            set

            {
                _key = value;
            }
        }


        private Creator ()

        {
            

        }

        public static void CreateBuild(Building building)

        {

            Building = building;

            Building = new Building();

            Data.Add(Key, Building);

            Key++;

        }

        public static void CreateBuild(Building building, int hight)

        {

            Building = building;

            Building = new Building { Height = hight };

            Data.Add(Key, Building);

            Key++;

        }

        public static void CreateBuild(Building building, int hight, int floor )

        {

            Building = building;

            Building = new Building { Height = hight, Floor = floor };

            Data.Add(Key, Building);

            Key++;

        }

        public static void CreateBuild(Building building, int hight, int floor, int apartment)

        {

            Building = building;

            Building = new Building { Height = hight, Floor = floor, Apartment = apartment };

            Data.Add(Key, Building);

            Key++;

        }

        public static void CreateBuild(Building building, int hight, int floor, int apartment, int front)

        {

            Building = building;

            Building = new Building { Height = hight, Floor = floor, Apartment = apartment, Front = front};

            Data.Add(Key, Building);

            Key++;

        }


        public static void DataInfo()

        {

            foreach ( DictionaryEntry d in Data)

            {
                Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);

            }

        }

        public static void Delete(int key)

        {

            try

            {
                if (Data.ContainsKey(key))

                {
                    Data.Remove(key);

                }

            }

            catch

            {
                Exception exception = new Exception("Такого элемента нет ");

            }
               

        }
        

       
    }
}
