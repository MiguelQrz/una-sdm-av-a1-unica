using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValeAtivos324133124.Data;
using ValeAtivos324133124.Models;

namespace ValeAtivos324133124.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EquipamentosController : ControllerBase
{   
    private readonly AppDbContext context;
    public EquipamentosController(AppDbContext ctx){
        context = ctx;
    }

    [HttpPost]
    public async Task<ActionResult> Post(Equipamento equip)
    {
        context.Equipamentos.Add(equip);
        await context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), equip);
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var equipamentos = await context.Equipamentos.ToListAsync();
        return Ok(equipamentos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetPerId(int id)
    {
        var equip = await context.Equipamentos.FirstOrDefaultAsync(e => e.Id == id);
        if (equip == null)
        {
            return NotFound();
        }
        return Ok(equip);
    }
    

}
