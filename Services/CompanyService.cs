

namespace WPR
{
    public interface ICompanyService
    {
        Task<List<Company>> Get();
        Task<Company?> GetById(int id);
        Task<Company?> Create(Company company);
        Task Update(int id, Company company);
        Task Delete(int id);
    }

    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            this._companyRepository = companyRepository;
        }

        public async Task<List<Company>> Get()
        {
            return await _companyRepository.Get();
        }

        public async Task<Company?> GetById(int id)
        {
            return await _companyRepository.GetByID(id);
        }

        public async Task<Company?> Create(Company company)
        {
            return await _companyRepository.Create(company);
        }

        public async Task Delete(int id)
        {
            await _companyRepository.Delete(id);
        }

        public async Task Update(int id, Company company)
        {
            await _companyRepository.Update(id, company);
        }
    }
}
