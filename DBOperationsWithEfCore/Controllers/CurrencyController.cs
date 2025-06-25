using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBOperationsWithEfCore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEfCore.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet("")]
        public IActionResult GetAllCurrencies()
        {
            var result = _appDbContext.Currencies.ToList();
            return Ok(result);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCurrenciesByIdAsync([FromRoute] int id)
        {
            var result = await  _appDbContext.Currencies.FindAsync(id);
            return Ok(result);

        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetCurrenciesByNameAsync([FromRoute] string name)
        {
            var result = await _appDbContext.Currencies.Where(x=>x.Title==name).FirstOrDefaultAsync();
            return Ok(result);

        }
    }
}
