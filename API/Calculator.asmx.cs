using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WindChillService.API
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {

        [WebMethod]
        public string CalculateWindChill(int T, int V)
        {
            int Result = (int)Math.Round(13.12 + (0.6215 * T) - (11.37 * Math.Pow(V, 0.16)) + (0.3965 * T * Math.Pow(V, 0.16)));

            return Result.ToString();
        }
    }
}
