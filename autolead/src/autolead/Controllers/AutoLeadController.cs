using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace autolead.Controllers
{
  
    public class AutoLeadController : Controller
    {
        // GET: api/values
        [HttpGet]
        [Route("API/AutoLead/GetAllAutoLeadList")]
        public string GetAllAutoLeadList()
        {
            return JsonReadHelper.GetAllAutoLeads();
        }

        [HttpGet]
        [Route("API/AutoLead/GetAutoLeadById/{Id}")]
        public string GetAutoLeadById(int Id)
        {
            return JsonReadHelper.GetAutoLeadById(Id);
        }

        [HttpGet]
        [Route("API/AutoLead/GetAutoLeadByState/{State}")]
        public string GetAutoLeadByState(string State)
        {
            return JsonReadHelper.GetAutoLeadByState(State);
        }

        [HttpGet]
        [Route("API/AutoLead/GetAutoLeadByMake/{Make}")]
        public string GetAutoLeadByMake(string Make)
        {
            return JsonReadHelper.GetAutoLeadByMake(Make);
        }

        [HttpGet]
        [Route("API/AutoLead/GetAutoLeadByinurer/{Insurare}")]
        public string GetAutoLeadByinurer(string Insurare)
        {
            return JsonReadHelper.GetAutoLeadByFormerinsurer(Insurare);
        }

             

      

    }
}
