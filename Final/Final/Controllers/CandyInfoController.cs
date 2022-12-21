using Final.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandyInfoController : ControllerBase
    {

        List<Candy> CandyList = new List<Candy>();

        public CandyInfoController()
        {
            CandyList.Add(new Candy { ProductNum = 101, Category = "Sweets", Description = "Milk Chocolate Covered Raisins", PricePerPound = 8.99});
            CandyList.Add(new Candy { ProductNum = 110, Category = "Sweets", Description = "Chocolate White Nonpareils", PricePerPound = 6.95 });
            CandyList.Add(new Candy { ProductNum = 120, Category = "Sugar-Free", Description = "Peanut Butter Cups", PricePerPound = 7.50 });
            CandyList.Add(new Candy { ProductNum = 127, Category = "Hard", Description = "Butterscotch Drops", PricePerPound = 4.25 });
            CandyList.Add(new Candy { ProductNum = 132, Category = "Sugar-Free", Description = "Strawberry Flavored Licorice", PricePerPound = 12.99 });
            CandyList.Add(new Candy { ProductNum = 135, Category = "Sweets", Description = "Marshmallow Coconut Toasties", PricePerPound = 13.50 });
        }


        [HttpGet, Route("sweets")]
        public List<Candy> sweets()
        {
            List<Candy> SweetsList = new List<Candy>();
            for (int i = 0; i < CandyList.Count; i++)
            {
                if (CandyList[i].Category.Equals("Sweets"))
                {
                    SweetsList.Add(CandyList[i]);
                }
            }
            return SweetsList;
        }

        [HttpGet, Route("averageprice")]

        public double averageprice()
        {
            double price = 0;
            for (int i = 0; i < CandyList.Count; i++)
            {
                    price += CandyList[i].PricePerPound;
            }
            double aveprice = price/CandyList.Count;
            return aveprice;
        }

        // GET: api/<CandyInfoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<CandyInfoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CandyInfoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CandyInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
