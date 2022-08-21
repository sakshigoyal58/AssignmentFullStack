using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VideoClipAPI.Domain;
using VideoClipAPI.Services;

namespace VideoClipAPI.Controllers
{
    [Route("api/[controller]")]
    public class SearchCriteriaController : Controller
    {
        private readonly ISearchCriteriaRepository _repository;
        private readonly IMapper _mapper;

        public SearchCriteriaController(ISearchCriteriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<SearchCriteriaDTO>> GetVideoSearchCriteria()
        {
            try
            {
                var model = await _repository.GetSearchCriteria();

                if (model != null)
                    return Ok(_mapper.Map<SearchCriteriaDTO>(model));

                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }
    }
}

