using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_04
{
     internal class Creator : Building
    {

        private static Building _building;
        private static Hashtable _data = new Hashtable();

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


        private Creator ()

        {
            

        }

        public static void CreateBuild(Building building)

        {
            Building = building;

            Data.Add(building.ID, building);
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
