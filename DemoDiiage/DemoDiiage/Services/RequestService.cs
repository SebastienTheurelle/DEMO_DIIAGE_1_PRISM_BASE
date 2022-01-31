using System;
using System.Net.Http;
using System.Threading.Tasks;
using DemoDiiage.Commons;
using DemoDiiage.Helpers.Interfaces;
using DemoDiiage.Models.Dtos;
using DemoDiiage.Services.Interfaces;

namespace DemoDiiage.Services
{
    public class RequestService : IRequestService
    {
        private readonly IDataTransferHelper _dataTransferHelper;
        
        public RequestService(IDataTransferHelper dataTransferHelper)
        {
            _dataTransferHelper = dataTransferHelper;
        }

        public async Task<MovieDownDto> GetRandomMovie()
        {
            try
            {
                var route = $"{Constants.BaseServerAddress}{Constants.RandomEndpoint}";
                var result = await _dataTransferHelper.SendAsync<MovieDownDto>(route, HttpMethod.Get);
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}