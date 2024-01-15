using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    public interface IDisabilityTypeService
    {
        Task<List<DisabilityType>> Get();
        Task<DisabilityType?> GetById(int id);
        Task<DisabilityType?> Create(DisabilityType disabilityType);
        Task Update(int id, DisabilityType disabilityType);
        Task Delete(int id);
    }

    public class DisabilityTypeService : IDisabilityTypeService
    {
        private readonly IDisabilityTypeRepository _disabilityTypeRepository;

        public DisabilityTypeService(IDisabilityTypeRepository disabilityTypeRepository)
        {
            this._disabilityTypeRepository = disabilityTypeRepository;
        }

        public async Task<List<DisabilityType>> Get()
        {
            return await _disabilityTypeRepository.Get();
        }

        public async Task<DisabilityType?> GetById(int id)
        {
            return await _disabilityTypeRepository.GetByID(id);
        }

        public async Task<DisabilityType?> Create(DisabilityType disabilityType)
        {
            return await _disabilityTypeRepository.Create(disabilityType);
        }

        public async Task Delete(int id)
        {
            await _disabilityTypeRepository.Delete(id);
        }

        public async Task Update(int id, DisabilityType disabilityType)
        {
            await _disabilityTypeRepository.Update(id, disabilityType);
        }
    }
}
