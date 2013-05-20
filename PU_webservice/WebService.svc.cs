using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PU_webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebService" in code, svc and config file together.
    public class WebService : IWebService
    {
        List<Places> list = null;
        PU_DatabaseEntities ent = new PU_DatabaseEntities();

        public WebService()
        {
            list = new List<Places>();
            /*Places c = new Places();
            c.Place_Id = 1;
            c.Longitude = 2.4490;
            c.Latitude = 4.8765;
            c.Name = "PUCIT";
            c.Description = "Its all about PUCIT";
            c.Category_Id = 1;
            //list.Add(c);


            Places c2 = new Places();
            c2.Place_Id = 2;
            c2.Longitude = 2.4490;
            c2.Latitude = 4.8765;
            c2.Name = "Arts";
            c2.Description = "Its all about Arts";
            c2.Category_Id = 3;
            //list.Add(c2);*/
        }
        public string GetData()
        {
            return "Hello World";
        }

        private Places getPlace(string id)
        {
            int id1 = Convert.ToInt32(id);
            var q = from s in ent.Places
                    where s.Id == id1
                    select s;

            Places c = new Places();

            foreach (var t in q)
            {
                c.Place_Id = t.Id;
                c.Longitude = Convert.ToDouble(t.Longitude);
                c.Latitude = Convert.ToDouble(t.Latitude);
                c.Name = t.Name;
                c.Description = t.Description;
                c.Category_Id = t.Category_id;
            }
            return c;

        }
        private List<Places> GetAllPlaces()
        {
            var q = from s in ent.Places
                    select s;

           

            foreach (var t in q)
            {
                Places c = new Places();
                c.Place_Id = t.Id;
                c.Longitude = Convert.ToDouble(t.Longitude);
                c.Latitude = Convert.ToDouble(t.Latitude);
                c.Name = t.Name;
                c.Description = t.Description;
                c.Category_Id = t.Category_id;

                list.Add(c);
            }
           
            return list;
        }

        
       /* public Car GetCarXml(string id)
        {
            return getCar(id);
        }*/
        
        public Places GetPlaceJSON(string id)
        {
            return getPlace(id);
        }

        public List<Places> GetAllPlacesJson()
        {
            return GetAllPlaces();
        }


     /*   public List<Car> GetAllCarsXml()
        {
            return GetAllCars();
        }

        public bool AddCar(Car c2) {

            Console.WriteLine("Car Added");
            Car newCar = new Car();
            newCar.Year = c2.Year;
            newCar.Make = c2.Make;
            list.Add(newCar);
            return true;
        
        }

        public string DeleteCar(string id)
        {
            //
            string text = "The car with Id  = " + id + " will be deleted from the system";
            return text;
        }

        public string UpdateCar(string id, Car c)
        {
            string text = "The car with Id  = " + id + " will be updated from the system";
            return text;
        }*/
    }
    }

