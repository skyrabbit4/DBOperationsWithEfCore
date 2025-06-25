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
    [Route("api/language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public LanguageController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllLanguage()
        {
            var result = await _appDbContext.Languages.ToListAsync();

            return Ok(result);
        }

    }
}
