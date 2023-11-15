using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIAssignment1.Models;

namespace WebAPIAssignment1.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>()
        {
            new Country { ID = 1, CountryName = "Europe", Capital = "Brussels" },
            new Country { ID = 2, CountryName = "Soth Korea", Capital = "Seoul" },
            new Country { ID = 3, CountryName = "Switzerland", Capital = "Bern" }
        };

        // Implement CRUD operations here
        // GET: api/Country
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        // GET: api/Country/1
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            return Ok(country);
        }

        // POST: api/Country
        public IHttpActionResult Post([FromBody] Country country)
        {
            country.ID = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }

        // PUT: api/Country/1
        public IHttpActionResult Put(int id, [FromBody] Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;

            return Ok(country);
        }

        // DELETE: api/Country/1
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            countries.Remove(country);

            return StatusCode(HttpStatusCode.NoContent);
        }
    }

}
