using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
namespace StockAPI.Controllers
{
    public class APIController : ApiController
    {
        private IGestioneBlue _blue;

        public APIController()
        {
            _blue = new TrivialBlue();
        }
        public APIController(IGestioneBlue blue)
        {
            _blue = blue;
        }

        [Route("api/getbluechips", Name = "GetAllBluechips")]
        public List<Bluechip> GetAllBluechips()
        {
            return _blue.GetAllBluechips();

        }
        [Route("api/getbluechipbysimbol", Name = "GetBluechipBySimbol")]
        public Bluechip GetBluechipsBySimbol(string Simbolo)
        {
            return _blue.GetBluechipBySimbol(Simbolo);
        }
    }
}
