using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PU_webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebService" in both code and config file together.
    [ServiceContract]
    public interface IWebService
    {
        //[OperationContract]
        [WebGet(UriTemplate="/GetSomeData")]
        string GetData();

        
      /*  [WebGet(UriTemplate="/CarPool/xml/{id}",
             ResponseFormat = WebMessageFormat.Xml)]
        Car GetCarXml(string id); */


        //[OperationContract]
        [WebGet(UriTemplate = "/PlacesPool/json/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        Places GetPlaceJSON(string id);

       /* //[OperationContract]
        [WebGet(UriTemplate = "/CarPool/json/",
            ResponseFormat = WebMessageFormat.Json)]
        List<Car> GetAllCarsXml(); */

        //[OperationContract]
        [WebGet(UriTemplate = "/PlacesPool/json/",
            ResponseFormat = WebMessageFormat.Json)]
        List<Places> GetAllPlacesJson();

        //  [OperationContract]
        [WebInvoke(UriTemplate = "/PlacesPool/add", Method="POST",
            ResponseFormat = WebMessageFormat.Json)]
        bool AddPlace(Places place);

        /*
        //[OperationContract]
        [WebInvoke(UriTemplate = "/CarPool/{id}", Method = "DELETE", ResponseFormat = WebMessageFormat.Json)]
        string DeleteCar(string id);

        //[OperationContract]
        [WebInvoke(UriTemplate = "/CarPool/{id}", Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        string UpdateCar(string id,Car c);*/
    }
    }

