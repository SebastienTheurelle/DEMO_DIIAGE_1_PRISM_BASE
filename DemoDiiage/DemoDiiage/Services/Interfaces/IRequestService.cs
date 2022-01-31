using System.Threading.Tasks;
using DemoDiiage.Models.Dtos;

namespace DemoDiiage.Services.Interfaces
{
    public interface IRequestService
    {
        Task<MovieDownDto> GetRandomMovie();
    }
}