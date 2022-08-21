using System;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public class SearchCriteriaRepository :ISearchCriteriaRepository
    {
        ISearchCriteriaService _service;

        public SearchCriteriaRepository(ISearchCriteriaService service)
        {
            _service = service;
        }

        public async Task<SearchCriteriaModel> GetSearchCriteria()
        {
            var videoDefinitionModel = await _service.GetAllVideoDefinitions();
            var videoStandardsModel = await _service.GetAllVideoStandards();

            SearchCriteriaModel searchCriteriaModel= new SearchCriteriaModel();

            searchCriteriaModel.VideoDefinitions = videoDefinitionModel;
            searchCriteriaModel.VideoStandards = videoStandardsModel;

            return searchCriteriaModel;

        }
    }
}

