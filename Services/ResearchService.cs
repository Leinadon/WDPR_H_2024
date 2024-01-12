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

        Task<Research> CreateQuestionnaire(int id, Questionnaire questionnaire);
        Task<Research> CreateInterview(int id, Interview interview);
        Task<Research> CreateOnlineAssignment(int id, OnlineAssignment onlineAssignment);

        Task UpdateQuestionnaire(int id, Questionnaire questionnaire);
        Task UpdateInterview(int id, Interview interview);
        Task UpdateOnlineAssignment(int id, OnlineAssignment onlineAssignment);
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

        public async Task<Research> CreateQuestionnaire(int id, Questionnaire questionnaire)
        {
            return await _researchRepository.CreateQuestionnaire(id, questionnaire);
        }

        public async Task<Research> CreateInterview(int id, Interview interview)
        {
            return await _researchRepository.CreateInterview(id, interview);
        }

        public async Task<Research> CreateOnlineAssignment(int id, OnlineAssignment onlineAssignment)
        {
            return await _researchRepository.CreateOnlineAssignment(id, onlineAssignment);
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
    }
}
