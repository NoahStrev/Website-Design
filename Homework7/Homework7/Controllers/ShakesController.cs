using Homework7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Homework7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ShakesController : ControllerBase
    {
        // GET: api/<ShakesController>
        List<ShakesPlay> plays = new List<ShakesPlay>();

        public ShakesController()
        {
            plays.Add(new ShakesPlay { ptitle = "The Tempest", mainchar1 = "Prospero", mainchar2 = "Ariel", playtpe = "Comedy", briefdesc = "The Tempest is a play about magic, betrayal, love and forgiveness.\r\nIt is set on an island somewhere near Italy where Prospero, the one-time Duke of\r\nMilan, and his beautiful daughter, Miranda, live with a sprite called Ariel and\r\na strange wildman called Caliban." });
            plays.Add(new ShakesPlay { ptitle = "Romeo and Juliet", mainchar1 = "Romeo", mainchar2 = "Juliet", playtpe = "Tragedy", briefdesc = "Romeo and Juliet is about two young star-crossed lovers whose deaths\r\nultimately reconcile their feuding families." });
            plays.Add(new ShakesPlay { ptitle = "Hamlet", mainchar1 = "Hamlet", mainchar2 = "Claudius", playtpe = "Tragedy", briefdesc = "Set in Denmark, the play depicts Prince Hamlet and his revenge against his uncle, Claudius, who has murdered Hamlet's father in order to seize his throne and marry Hamlet's mother." });
            plays.Add(new ShakesPlay { ptitle = "Julius Caesar", mainchar1 = "Caesar", mainchar2 = "Brutus", playtpe = "Tragedy", briefdesc = "Set in Rome in 44 BC, the play depicts the moral dilemma of Brutus as he\r\njoins a conspiracy led by Cassius to murder Julius Caesar to prevent him from becoming\r\ndictator of Rome." });
        }

        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            string returnJSON = JsonSerializer.Serialize(plays[id - 1]);
            return returnJSON;
            //return "value";
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<ShakesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShakesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShakesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
