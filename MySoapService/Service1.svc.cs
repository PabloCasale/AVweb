using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MySoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetCity(string value)
        {
            return char.ToUpper(value[0]) + value.Substring(1);
        }

        public string GetCountry(string value)
        {
            return char.ToUpper(value[0]) + value.Substring(1);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetDescription(string value)
        {
            return value.ToUpper();
        }

        public double GetFarenheit(double value)
        {
            return Math.Round(value);
        }

        public string GetName(string value)
        {
            return value.ToString();
        }

        public double GetTemperature(double value)
        {
            var result = Math.Round(value);
            return result;
        }

        public double GetWind(double value)
        {
            return Math.Round((value) * (60 * 60) / 1000);
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
