using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IResearchRepository
    {
        // Global
        Task<List<Research>> Get();
        Task<Research?> GetById(int id);
        Task Delete(int id);

        // Questionnaire
        Task UpdateQuestionnaire(int id, Research questionnaire);
        Task<Research> CreateQuestionnaire(int id, Research OnlineAssignment);

        // Interview
        Task UpdateInterview(int id, Research interview);
        Task<Research> CreateInterview(int id, Research OnlineAssignment);

        // Online
        Task UpdateOnlineAssignment(int id, Research online);
        Task<Research> CreateOnlineAssignment(int id, Research OnlineAssignment);
    }

    public class ResearchRepository: IResearchRepository
    {
        private readonly WPRDbContext _dbContext;

        public ResearchRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Research>> Get()
        {

            return await _dbContext.Researches.ToListAsync();
        }

        public async Task<Research?> GetById(int id)
        {
            Research? research =  await _dbContext.Researches.FirstOrDefaultAsync(r => r.ID == id);
            if(research != null){
                return research;
            }else{
                throw new InvalidOperationException($"Research with ID {id} not found");
            }
        }

        public async Task Delete(int id)
        {
            Research? research = await _dbContext.Researches.SingleOrDefaultAsync(r => r.ID == id);
            if(research != null){
                _dbContext.Researches.Remove(research);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Research wih ID {id} not found for Delete");
            }
        }

        public async Task<Questionnaire> CreateQuestionnaire(Questionnaire questionnaire)
        {

            _dbContext.Researches.Add(questionnaire);
            await _dbContext.SaveChangesAsync();
            return questionnaire;   
        }
        public async Task<Interview> CreateInterview(Interview interview)
        {
            _dbContext.Researches.Add(interview);
            await _dbContext.SaveChangesAsync();
            return interview;
        }
        public async Task<OnlineAssignment> CreateOnlineAssignment(OnlineAssignment onlineAssignment)
        {
            _dbContext.Researches.Add(onlineAssignment);
            await _dbContext.SaveChangesAsync();
            return onlineAssignment;
        }
        public async Task UpdateQuestionnaire(int id, Research questionnaire)
        {
            Research? oldQuestionnaire = await _dbContext.Researches.FindAsync(id);
            if(oldQuestionnaire != null){
                _dbContext.Update(questionnaire);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Questionnaire with ID {id} not found for updatre");
            }
        }
        public async Task UpdateInterview(int id, Research interview)
        {
            Research? oldInterview = await _dbContext.Researches.FindAsync(id);
            if(oldInterview != null){
                _dbContext.Update(interview);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Interview with ID {id} not found for update");
            }
        }
        public async Task UpdateOnlineAssignment(int id, Research onlineAssignment){
            Research? oldOnlineAssignment = await _dbContext.Researches.FindAsync(id);
            if(oldOnlineAssignment != null){
                _dbContext.Update(onlineAssignment);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"OnlineAssignment with ID {id} not found for update");
            }
        }

        public async Task DeleteQuestionnaire(int id)
        {
            Research? questionnaire = await _dbContext.Researches.FirstOrDefaultAsync(q => q.ID == id);
            if(questionnaire != null)
            {
                _dbContext.Researches.Remove(questionnaire);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Questionnaire with ID {id} not found for Delete");
            }
        }

        public async Task DeleteInterview(int id)
        {
            Research? interview = await _dbContext.Researches.FirstOrDefaultAsync(i => i.ID == id);
            if(interview != null){
                _dbContext.Researches.Remove(interview);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Interview with ID {id} not found for Delete");
            }
        }

        public async Task DeleteOnlineAssignment(int id)
        {
            Research? onlineAssignment = await _dbContext.Researches.FirstOrDefaultAsync(o => o.ID == id);
            if(onlineAssignment != null){
                _dbContext.Researches.Remove(onlineAssignment);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"OnlineAssignment with ID {id} not found for Delete");
            }
        }

        public async Task<Research> GetQuestionnaireById(int id)
        {
            Research? questionnaire = await _dbContext.Researches.FirstOrDefaultAsync(q => q.ID == id);
            if(questionnaire != null){
                return questionnaire;
            }else{
                throw new InvalidOperationException($"Questionnaire with Id {id} not found");
            }
        }

        public async Task<Research> GetInterviewById(int id)
        {
            Research? interview = await _dbContext.Researches.FirstOrDefaultAsync(i => i.ID == id);
            if(interview != null){
                return interview;
            }else{
                throw new InvalidOperationException($"Interview with Id {id} not found");
            }
        }

        public async Task<Research> GetOnlineAssignmentById(int id)
        {
            Research? onlineAssignment = await _dbContext.Researches.FirstOrDefaultAsync(o => o.ID == id);
            if(onlineAssignment != null){
                return onlineAssignment;
            }else{
                throw new InvalidOperationException($"OnlineAssignment with Id {id} not found");
            }
        }

        public async Task<Research> CreateQuestionnaire(int id, Research Questionnaire)
        {
            _dbContext.Researches.Add(Questionnaire);
            await _dbContext.SaveChangesAsync();
            return Questionnaire;
        }

        public async Task<Research> CreateInterview(int id, Research interview)
        {
            _dbContext.Researches.Add(interview);
            await _dbContext.SaveChangesAsync();
            return interview;
        }

        public async Task<Research> CreateOnlineAssignment(int id, Research OnlineAssignment)
        {
            _dbContext.Researches.Add(OnlineAssignment);
            await _dbContext.SaveChangesAsync();
            return OnlineAssignment;
        }
    }
}

