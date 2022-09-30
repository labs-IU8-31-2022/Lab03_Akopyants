using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Cars_Catalog
    {
        public Cars_Catalog()
        {

            Cars = new List<Car>();
        }

        public Cars_Catalog(Car obj)
        {
            Cars = new List<Car>();
            Cars.Add(obj);
        }

        public string this[int index]
        {
            get 
            {
                return Cars[index].Name + " " + Cars[index].Engine; 
            }
        }
   
        public void Add(Car item)
        {
            Cars.Add(item);
        }
        public List<Car> Cars;

    }










}    
    

