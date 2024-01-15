namespace WPR
{
    public interface IOnlineAssignmentResultService
    {
        Task<List<OnlineAssignmentResult>> Get();
        Task<OnlineAssignmentResult?> GetById(int id);
        Task<OnlineAssignmentResult?> Create(OnlineAssignmentResult onlineAssignmentResult);
        Task Update(int id, OnlineAssignmentResult onlineAssignmentResult);
        Task Delete(int id);

    }
    public class OnlineAssignmentResultService : IOnlineAssignmentResultService
    {
        private readonly IOnlineAssignmentResultRepository _onlineAssignmentResultRepository;

        public OnlineAssignmentResultService(IOnlineAssignmentResultRepository onlineAssignmentResultRepository)
        {
            this._onlineAssignmentResultRepository = onlineAssignmentResultRepository;
        }

        public async Task<OnlineAssignmentResult?> Create(OnlineAssignmentResult onlineAssignmentResult)
        {
            return await _onlineAssignmentResultRepository.Create(onlineAssignmentResult);
        }

        public async Task Delete(int id)
        {
            await _onlineAssignmentResultRepository.Delete(id);
        }

        public async Task<List<OnlineAssignmentResult>> Get()
        {
            return await _onlineAssignmentResultRepository.Get();
        }

        public async Task<OnlineAssignmentResult?> GetById(int id)
        {
            return await _onlineAssignmentResultRepository.GetById(id);
        }

        public async Task Update(int id, OnlineAssignmentResult onlineAssignmentResult)
        {
            await _onlineAssignmentResultRepository.Update(id, onlineAssignmentResult);
        }
    }
}