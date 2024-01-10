using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Expressions;

namespace WPR
{
    public interface IResearchRepository
    {
        // Global
        Task<List<Research>> Get();
        Task<Research?> GetById(int id);
        Task Delete(int id);

        // Questionnaire
        Task<Questionnaire> GetQuestionnaireById(int id);
        Task<Questionnaire> CreateQuestionnaire(Questionnaire questionnaire);
        Task UpdateQuestionnaire(int id, Questionnaire questionnaire);
        Task DeleteQuestionnaire(int id);
        
        // Interview
        Task<Interview> GetInterviewById(int id);
        Task<Interview> CreateInterview(Interview interview);
        Task UpdateInterview(int id, Interview interview);
        Task DeleteInterview(int id);

        // Online
        Task<OnlineAssignment> GetOnlineAssignmentById(int id);
        Task<OnlineAssignment> CreateOnlineAssignment(OnlineAssignment online);
        Task UpdateOnlineAssignment(int id, OnlineAssignment online);
        Task DeleteOnlineAssignment(int id);    
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
            Research? research =  await _dbContext.Researches.FirstOrDefaultAsync(r => r.ResearchID == id);
            if(research != null){
                return research;
            }else{
                throw new InvalidOperationException($"Research with ID {id} not found");
            }
        }

        public async Task Delete(int id)
        {
            Research? research = await _dbContext.Researches.FirstAsync(r => r.ResearchID == id);
            if(research != null){
                _dbContext.Researches.Remove(research);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Research wih ID {id} not found for Delete");
            }
        }

        public async Task<Questionnaire> CreateQuestionnaire(Questionnaire questionnaire)
        {

            _dbContext.Questionnaires.Add(questionnaire);
            await _dbContext.SaveChangesAsync();
            return questionnaire;
        }
        public async Task<Interview> CreateInterview(Interview interview)
        {
            _dbContext.Interviews.Add(interview);
            await _dbContext.SaveChangesAsync();
            return interview;
        }
        public async Task<OnlineAssignment> CreateOnlineAssignment(OnlineAssignment onlineAssignment)
        {
            _dbContext.OnlineAssignments.Add(onlineAssignment);
            await _dbContext.SaveChangesAsync();
            return onlineAssignment;
        }
        public async Task UpdateQuestionnaire(int id, Questionnaire questionnaire)
        {
            Questionnaire? oldQuestionnaire = await _dbContext.Questionnaires.FindAsync(id);
            if(oldQuestionnaire != null){
                _dbContext.Update(questionnaire);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Questionnaire with ID {id} not found for updatre");
            }
        }
        public async Task UpdateInterview(int id, Interview interview)
        {
            Interview? oldInterview = await _dbContext.Interviews.FindAsync(id);
            if(oldInterview != null){
                _dbContext.Update(interview);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Interview with ID {id} not found for update");
            }
        }
        public async Task UpdateOnlineAssignment(int id, OnlineAssignment onlineAssignment){
            OnlineAssignment? oldOnlineAssignment = await _dbContext.OnlineAssignments.FindAsync(id);
            if(oldOnlineAssignment != null){
                _dbContext.Update(onlineAssignment);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"OnlineAssignment with ID {id} not found for update");
            }
        }

        public async Task DeleteQuestionnaire(int id)
        {
            Questionnaire? questionnaire = await _dbContext.Questionnaires.FirstOrDefaultAsync(q => q.ResearchID == id);
            if(questionnaire != null)
            {
                _dbContext.Questionnaires.Remove(questionnaire);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Questionnaire with ID {id} not found for Delete");
            }
        }

        public async Task DeleteInterview(int id)
        {
            Interview? interview = await _dbContext.Interviews.FirstOrDefaultAsync(i => i.ResearchID == id);
            if(interview != null){
                _dbContext.Interviews.Remove(interview);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Interview with ID {id} not found for Delete");
            }
        }

        public async Task DeleteOnlineAssignment(int id)
        {
            OnlineAssignment? onlineAssignment = await _dbContext.OnlineAssignments.FirstOrDefaultAsync(o => o.ResearchID == id);
            if(onlineAssignment != null){
                _dbContext.OnlineAssignments.Remove(onlineAssignment);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"OnlineAssignment with ID {id} not found for Delete");
            }
        }

        public async Task<Questionnaire> GetQuestionnaireById(int id)
        {
            Questionnaire? questionnaire = await _dbContext.Questionnaires.FirstOrDefaultAsync(q => q.ResearchID == id);
            if(questionnaire != null){
                return questionnaire;
            }else{
                throw new InvalidOperationException($"Questionnaire with Id {id} not found");
            }
        }

        public async Task<Interview> GetInterviewById(int id)
        {
            Interview? interview = await _dbContext.Interviews.FirstOrDefaultAsync(i => i.ResearchID == id);
            if(interview != null){
                return interview;
            }else{
                throw new InvalidOperationException($"Interview with Id {id} not found");
            }
        }

        public async Task<OnlineAssignment> GetOnlineAssignmentById(int id)
        {
            OnlineAssignment? onlineAssignment = await _dbContext.OnlineAssignments.FirstOrDefaultAsync(o => o.ResearchID == id);
            if(onlineAssignment != null){
                return onlineAssignment;
            }else{
                throw new InvalidOperationException($"OnlineAssignment with Id {id} not found");
            }
        }
    }
}

