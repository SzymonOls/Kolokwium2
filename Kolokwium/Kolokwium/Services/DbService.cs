using Kolokwium.Data;
using Kolokwium.DTOs;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<NurseryDto> GetNursery(int id)
    {
        var nursery = await _context.Nursery
            .Select(n => new NurseryDto
            {
                NurseryId = n.NurseryId,
                Name = n.Name,
                EstablishedDate = n.EstablishedDate,
                Batches = n.SeedlingBatches.Select(b => new BatchDto
                {
                    batchId = b.BatchId,
                    Quantity = b.Quantity,
                    SownDate = b.SownDate,
                    ReadyDate = b.ReadyDate,
                    Species = new SpeciesDto
                    {
                        LatinName = b.TreeSpecies.LatinName,
                        GrowthTimeInYears = b.TreeSpecies.GrowthTimeInYears,
                    },
                    Responsibles = b.Responsibles.Select(r => new ResponsibleDto
                    {
                        FirstName = r.Employee1.FirstName,
                        LastName = r.Employee1.LastName,
                        Role = r.Role
                    }).ToList(),
                }).ToList()
            }).FirstOrDefaultAsync();
        if (nursery is null)
            throw new NullReferenceException();
        
        return nursery;
    }


    
}