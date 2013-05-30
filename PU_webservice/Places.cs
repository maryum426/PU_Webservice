using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace PU_webservice
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Places
    {
        int id;
        double longitude;
        double latitude;
        string name;
        string description;
        string image;
        int cat_id;

        [DataMember]
        public int Place_Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        [DataMember]
        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        [DataMember]
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DataMember]
        public int Category_Id
        {
            get { return cat_id; }
            set { cat_id = value; }
        }
    }
}