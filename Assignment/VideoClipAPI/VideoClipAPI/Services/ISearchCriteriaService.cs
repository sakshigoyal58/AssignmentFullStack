using System;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public interface ISearchCriteriaService
    {
        Task<IList<VideoDefinitionModel>> GetAllVideoDefinitions();

        Task<IList<VideoStandardModel>> GetAllVideoStandards();
    }
}

