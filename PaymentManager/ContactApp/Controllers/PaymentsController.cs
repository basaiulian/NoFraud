using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentManagement.Model;
using System;
using System.Data;
using Newtonsoft.Json;

namespace PaymentManagement.Controllers
{
    public class MyItem
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    [Route("api/v1/payments")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly DataContext _context;

        public PaymentsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayments()
        {
            return await _context.Payment.OrderBy(p => p.Date).ToListAsync();
        }

        [HttpGet("countries")]
        public async Task<ActionResult<List<MyItem>>> GetJson()
        {
            List<string> countries = new List<string> { };

            var json = System.IO.File.ReadAllText(@"zipcodes.json");
            var list = JsonConvert.DeserializeObject<List<MyItem>>(json);

            return list;
        }

        [HttpGet("{id}", Name = "GetPaymentById")]
        public async Task<ActionResult<Payment>> GetPaymentById(int id)
        {
            var payment = await _context.Payment.FindAsync(id);

            if (payment == null)
            {
                return NotFound();
            }

            return payment;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, [FromBody] Payment payment)
        {
            if (id != payment.Id)
            {
                return BadRequest();
            }

            _context.Entry(payment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            var payment = await _context.Payment.FindAsync(id);
            if (payment == null)
            {
                return NotFound();
            }

            _context.Payment.Remove(payment);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment([FromBody] Payment payment)
        {
            _context.Payment.Add(payment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentById", new { id = payment.Id }, payment);
        }

        [HttpPost("distance")]
        public async Task<string> GetDistance([FromBody] List<List<string>> Coordinates)
        {
            int distance = -1;

            List<string> sourceCoordinates = Coordinates[0];
            List<string> destinationCoordinates = Coordinates[1];

            double sourceLat = Convert.ToDouble(sourceCoordinates[0]);
            double sourceLong = Convert.ToDouble(sourceCoordinates[1]);

            double destinationLat = Convert.ToDouble(destinationCoordinates[0]);
            double destinationLong = Convert.ToDouble(destinationCoordinates[1]);

            var d1 = sourceLat * (Math.PI / 180.0);
            var num1 = sourceLong * (Math.PI / 180.0);
            var d2 = destinationLat * (Math.PI / 180.0);
            var num2 = destinationLong * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) +
                     Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            distance = Convert.ToInt32(6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3))) / 1000);
            
            return distance.ToString();
        }

        private bool PaymentExists(int id)
        {
            return _context.Payment.Any(e => e.Id == id);
        }

    }
}
