using Kolokwium.DTOs;
using Kolokwium.Models;

namespace Kolokwium.Services;

public interface IDbService
{
    Task<NurseryDto> GetNursery(int id);
    //Task AddTreeWithResponible(TreeDto tree, List<AddResponsibleDto> responsibles);
}