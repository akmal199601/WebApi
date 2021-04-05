using Api.DataContext;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ApiContext db;
        public ValuesController(ApiContext _db)
        {
            db = _db;
        }
        [HttpPost]
        public async Task<IActionResult> Greate(Quote model)
        {
            if (ModelState.IsValid)
            {
                db.Quotes.Add(model);
                await db.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var li = await db.Quotes.ToListAsync();
            return Ok(li);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id,Quote model)
        {
            if(ModelState.IsValid)
            {
                var prModel = await db.Quotes.FirstOrDefaultAsync(p=> p.Id == id);
                if(prModel != null)
                {
                    prModel.Author = model.Author;
                    prModel.InsertDate = model.InsertDate;
                    prModel.Text = model.Text;
                    await db.SaveChangesAsync();
                    return Ok();
                }
                return BadRequest();
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id )
        {
            if(id != 0)
            {
                var model = await db.Quotes.FirstAsync(p => p.Id == id);
                db.Quotes.Remove(model);
                await db.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }

    }
}
