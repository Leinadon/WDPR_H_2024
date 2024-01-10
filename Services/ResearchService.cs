using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IResearchService
    {
        Task<List<Research>> GetResearches();
        Task<Research?> GetById(int id);
        Task DeleteResearch(int id);

        Task<Questionnaire> GetQuestionnaireById(int id);
        Task<Interview> GetInterviewById(int id);
        Task<OnlineAssignment> GetOnlineAssignmentById(int id);

        Task<Questionnaire> CreateQuestionnaire(Questionnaire questionnaire);
        Task<Interview> CreateInterview(Interview interview);
        Task<OnlineAssignment> CreateOnlineAssignment(OnlineAssignment onlineAssignment);

        Task UpdateQuestionnaire(int id, Questionnaire questionnaire);
        Task UpdateInterview(int id, Interview interview);
        Task UpdateOnlineAssignment(int id, OnlineAssignment onlineAssignment);

        Task DeleteQuestionnaire(int id);
        Task DeleteInterview(int id);
        Task DeleteOnlineAssignment(int id);
    }

    public class ResearchService : IResearchService
    {
        private readonly IResearchRepository _researchRepository;

        public ResearchService(IResearchRepository researchRepository)
        {
            _researchRepository = researchRepository;
        }

        public async Task<List<Research>> GetResearches()
        {
            return await _researchRepository.Get();
        }

        public async Task<Research?> GetById(int id)
        {
            return await _researchRepository.GetById(id);
        }

        public async Task DeleteResearch(int id)
        {
            await _researchRepository.Delete(id);
        }

        public async Task<Questionnaire> CreateQuestionnaire(Questionnaire questionnaire)
        {
            return await _researchRepository.CreateQuestionnaire(questionnaire);
        }

        public async Task<Interview> CreateInterview(Interview interview)
        {
            return await _researchRepository.CreateInterview(interview);
        }

        public async Task<OnlineAssignment> CreateOnlineAssignment(OnlineAssignment onlineAssignment)
        {
            return await _researchRepository.CreateOnlineAssignment(onlineAssignment);
        }

        public async Task UpdateQuestionnaire(int id, Questionnaire questionnaire)
        {
            await _researchRepository.UpdateQuestionnaire(id, questionnaire);
        }

        public async Task UpdateInterview(int id, Interview interview)
        {
            await _researchRepository.UpdateInterview(id, interview);
        }

        public async Task UpdateOnlineAssignment(int id, OnlineAssignment onlineAssignment)
        {
            await _researchRepository.UpdateOnlineAssignment(id, onlineAssignment);
        }

        public async Task DeleteQuestionnaire(int id)
        {
            await _researchRepository.DeleteQuestionnaire(id);
        }

        public async Task DeleteInterview(int id)
        {
            await _researchRepository.DeleteInterview(id);
        }

        public async Task DeleteOnlineAssignment(int id)
        {
            await _researchRepository.DeleteOnlineAssignment(id);
        }

        public async Task<Questionnaire> GetQuestionnaireById(int id)
        {
            return await _researchRepository.GetQuestionnaireById(id);
        }

        public async Task<Interview> GetInterviewById(int id)
        {
            return await _researchRepository.GetInterviewById(id);
        }

        public async Task<OnlineAssignment> GetOnlineAssignmentById(int id)
        {
            return await _researchRepository.GetOnlineAssignmentById(id);
        }
    }
}
