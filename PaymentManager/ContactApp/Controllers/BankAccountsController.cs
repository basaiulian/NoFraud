﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentManagement.Model;
using PaymentManagement.Entities;
using System;

namespace PaymentManagement.Controllers
{
    [Route("api/v1/bankaccounts")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly DataContext _context;

        public BankAccountsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BankAccount>> GetBankAccounts()
        {
            foreach (var bankaccount in _context.BankAccount)
            {
                List<Card> cards = _context.Card.ToList();
                foreach (var card in cards)
                {
                    if (bankaccount.Id == card.BankAccountId)
                    {
                        if (!bankaccount.CardList.Contains(card))
                            bankaccount.CardList.Add(card);
                    }
                }
            }

            _context.SaveChanges();

            return _context.BankAccount.ToList();
        
        }

        [HttpGet("{id}", Name = "GetBankAccountById")]
        public async Task<ActionResult<BankAccount>> GetBankAccountById(string id)
        {
            var bankAccount= await _context.BankAccount.FindAsync(id);

            if (bankAccount == null)
            {
                return NotFound();
            }

            List<Card> cards = _context.Card.ToList();
            foreach (var card in cards)
            {
                if (id == card.BankAccountId)
                {
                    if (!bankAccount.CardList.Contains(card))
                        bankAccount.CardList.Add(card);
                }
            }

            return bankAccount;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankAccount(int id, [FromBody] BankAccount bankAccount)
        {
            if (id.ToString() != bankAccount.Id)
            {
                return BadRequest();
            }

            _context.Entry(bankAccount).State = EntityState.Modified;
            foreach (var card in bankAccount.CardList)
            {
                if (id == Int32.Parse(card.BankAccountId))
                {
                    if (!_context.Card.Contains(card))
                        _context.Card.Add(card);
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
                if (!BankAccountExists(id))
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
        public async Task<IActionResult> DeleteBankAccount(string id)
        {
            var bankAccount = await _context.BankAccount.FindAsync(id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            foreach (Card card in _context.Card)
            {
                if(card.BankAccountId == id)
                {
                    _context.Card.Remove(card);

                }
            }

            _context.BankAccount.Remove(bankAccount);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("transfer")]
        public async Task<ActionResult<int>> TransferBetweenUsers([FromBody] List<string> transferData)
        {
            List<BankAccount> bankAccounts = _context.BankAccount.ToList();

            var sourceBankAccount = bankAccounts.Where(p => p.UserId == Int32.Parse(transferData[1])).First();
            var destinationBankAccount = bankAccounts.Where(p => p.UserId == Int32.Parse(transferData[2])).First();

            Console.WriteLine(sourceBankAccount.Balance);
            Console.WriteLine(destinationBankAccount.Balance);

            if (sourceBankAccount.Balance < Convert.ToDouble(transferData[0]))
            {
                Console.WriteLine("Balance prea mic");
                return -1;
            }
            else
            {
                sourceBankAccount.Balance -= Convert.ToDouble(transferData[0]);
                destinationBankAccount.Balance += Convert.ToDouble(transferData[0]);
                _context.SaveChanges();
                Console.WriteLine("Transfer");
                return 1;
            }
        }


        [HttpPost]
        public async Task<ActionResult<BankAccount>> PostBankAccount([FromBody] BankAccount bankAccount)
        {
            _context.BankAccount.Add(bankAccount);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBankAccountById", new { id = bankAccount.Id }, bankAccount);
        }


        private bool BankAccountExists(int id)
        {
            return _context.BankAccount.Any(e => e.Id == id.ToString());
        }

    }
}
