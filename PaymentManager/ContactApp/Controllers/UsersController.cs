using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentManagement.Model;
using PaymentManagement.Entities;
using System;
using Newtonsoft.Json;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace PaymentManagement.Controllers
{

    public class LoginClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            foreach (var user in _context.User)
            {
                List<BankAccount> bankAccounts = _context.BankAccount.ToList();
                foreach (var bankAccount in bankAccounts)
                {
                    if (user.Id == bankAccount.UserId)
                    {

                        List<Card> cards = _context.Card.ToList();
                        foreach (var card in cards)
                        {
                            if (bankAccount.Id == card.BankAccountId)
                            {
                                if (!bankAccount.CardList.Contains(card))
                                    bankAccount.CardList.Add(card);
                            }
                        }

                    }
                }
            }

            _context.SaveChanges();

            return _context.User.ToList();

        }


        [HttpPost("find")]
        public int FindUser([FromBody] List<string> loginObject)
        {

            Console.WriteLine(loginObject[0]);
            Console.WriteLine(loginObject[1]);

            List<User> users = _context.User.ToList();

            foreach(User user in users)
            {
                if(user.Username == loginObject[0] && user.Password == loginObject[1])
                {
                    return user.Id;
                }
            }
            return -1;
            
        }

        [HttpGet("{id}", Name = "GetUserById")]
        //[HttpGet("getid",Name = "GetUserById")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            List<BankAccount> bankAccounts = _context.BankAccount.ToList();
            foreach (var bankAccount in bankAccounts)
            {
                if (id == bankAccount.UserId)
                {
                        List<Card> cards = _context.Card.ToList();
                        foreach (var card in cards)
                        {
                            if (bankAccount.Id == card.BankAccountId)
                            {
                                if (!bankAccount.CardList.Contains(card))
                                    bankAccount.CardList.Add(card);
                            }
                        }                    
                }
            }

            return user;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, [FromBody] User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;
            foreach (var bankAccount in user.BankAccounts)
            {
                if (id == bankAccount.UserId)
                {
                    if (!_context.BankAccount.Contains(bankAccount)) // Verificam daca bankAccountul exista deja in DB
                    {
                        foreach (var card in bankAccount.CardList)
                        {
                            if (id == Int32.Parse(card.BankAccountId))
                            {
                                if (!_context.Card.Contains(card)) // Verificam daca cardul exista deja in DB
                                    _context.Card.Add(card);
                                else return BadRequest();
                            }
                        }
                    _context.BankAccount.Add(bankAccount);

                    }
                    else return BadRequest();
                }
                 
            }

            try
            {
                await _context.SaveChangesAsync();
                return Ok();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            foreach (BankAccount bankAccount in _context.BankAccount)
            {
                if (bankAccount.UserId == id)
                {


                    foreach (Card card in _context.Card)
                    {
                        if ((card.BankAccountId == bankAccount.Id))
                        {
                            _context.Card.Remove(card);

                        }
                    }

                    _context.BankAccount.Remove(bankAccount);

                }
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody] User user)
        {
            _context.User.Add(user);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserById", new { id = user.Id }, user);
        }

        //[HttpPost]
        //public async Task<ActionResult<User>> Login([FromBody] string username, string password)
        //{
        //    _context.User.Add(user);

        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetUserById", new { id = user.Id }, user);
        //}


        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }

    }
}
