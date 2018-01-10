using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using JIT.Test.Swagger.SwaggerValue.Response.Employee;

namespace WebApi.Controllers
{
    public class PersonController : ApiController
    {
        /// <summary>
        /// Save Persons 
        /// </summary>
        /// <param name="lst"> List of Employees. List of Employees. List of Employees. List of Employees. List of Employees. List of Employees. List of Employees. List of Employees.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Persons")]
        public List<FinancialEmployeePerson> PostValues(List<FinancialEmployeePerson> lst)
        {
            return new List<FinancialEmployeePerson>();
        }


        /// <summary>
        /// Save person 
        /// </summary>
        /// <param name="Employee">Employees data. Employees data.Employees data. Employees data. Employees data. Employees data. Employees data.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Person")]
        public FinancialEmployeePerson PostValue(FinancialEmployeePerson lst)
        {
            return new FinancialEmployeePerson();
        }

    }
}