using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace PU_webservice
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Categories
    {
        int id;
        string name;
        string description;

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
            get { return id; }
            set { id = value; }
    }
}