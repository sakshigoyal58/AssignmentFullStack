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
    public class VideoClipController : Controller
    {
        private readonly IVideoClipRepository _repository;
        private readonly IMapper _mapper;

        public VideoClipController(IVideoClipRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VideoClipDTO>>> Get(SearchRequest searchCriteriaRequest)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var item = await _repository.GetVideoClips(searchCriteriaRequest);

                    if (item.Count >0)
                        return Ok(_mapper.Map<IEnumerable<VideoClipDTO>>(item));
                }
                
            }
            catch (Exception ex)
            {
                
            }

            return NoContent();
        }
    }
}
