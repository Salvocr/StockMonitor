using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using DTO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockMonitor.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public async Task<ActionResult> Index()
        {
            //provaa
            HttpClient client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("http://localhost:63294/api/getbluechips");
            IEnumerable <Bluechip> lstBluechips = new List<Bluechip>();
            if(result.IsSuccessStatusCode)
            {
                string content = await
                result.Content.ReadAsStringAsync();
                lstBluechips = JsonConvert.DeserializeObject<IEnumerable<Bluechip>>(content);
            }
                return View(lstBluechips.ToList());
        }

        public async Task<ActionResult> Details(string sym)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("http://localhost:63294/api/getbluechipbysimbol?Simbolo="+sym);
            Bluechip bluechip = new Bluechip();
            if (result.IsSuccessStatusCode)
            {
                string content = await
                result.Content.ReadAsStringAsync();
                bluechip = JsonConvert.DeserializeObject<Bluechip>(content);
            }
            return View(bluechip);
        }

    }
}