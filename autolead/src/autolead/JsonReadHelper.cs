using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace autolead
{
    public static class JsonReadHelper
    {

        public static string GetAllAutoLeads()
        {
            FileStream filestream = new FileStream("auto.leads.json", FileMode.Open);
            using (StreamReader r = new StreamReader(filestream))
            {
                string json = r.ReadToEnd();        
                return json;
            }
        }

        public static string GetAutoLeadById(int Id)
        {
            FileStream filestream = new FileStream("auto.leads.json", FileMode.Open);
            using (StreamReader r = new StreamReader(filestream))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);

                var byid = from idval in (IEnumerable<dynamic>)array
                           where idval.id == Id 
                           select new
                           {
                               idval
                           };
                return JsonConvert.SerializeObject(byid);
            }
        }

        public static string GetAutoLeadByState(string State)
        {
            FileStream filestream = new FileStream("auto.leads.json", FileMode.Open);
            using (StreamReader r = new StreamReader(filestream))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);

                var byState = from state in (IEnumerable<dynamic>)array
                           where state.consumer.state == State
                           select new
                           {
                               state
                           };
                return JsonConvert.SerializeObject(byState);
            }
        }

        public static string GetAutoLeadByMake(string Make)
        {
            FileStream filestream = new FileStream("auto.leads.json", FileMode.Open);
            using (StreamReader r = new StreamReader(filestream))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);

                var byMake = from make in (IEnumerable<dynamic>)array
                           from vehicles in (IEnumerable<dynamic>)make.vehicle
                           where vehicles.make == Make
                           select new
                           {
                               make
                           };
                return JsonConvert.SerializeObject(byMake);
            }
        }

        public static string GetAutoLeadByFormerinsurer(string insurar)
        {
            FileStream filestream = new FileStream("auto.leads.json", FileMode.Open);
            using (StreamReader r = new StreamReader(filestream))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);

                var byinsurance = from insurance in (IEnumerable<dynamic>)array
                           where insurance.coverage.former_insurer == insurar
                           select new
                           {
                               insurance
                           };
                return JsonConvert.SerializeObject(byinsurance);
            }
        }


    }
}
