using System;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public interface ISearchCriteriaRepository
    {
        Task<SearchCriteriaModel> GetSearchCriteria();
    }
}

