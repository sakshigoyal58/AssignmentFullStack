using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShowReelsAPI.Domain;
using ShowReelsAPI.Services;

namespace ShowReelsAPI.Controllers
{
    [Route("api/[controller]")]
    public class ShowReelController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IShowReelRepository _repository;

        public ShowReelController(IMapper mapper, IShowReelRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpPost("CreateReel")]
        public HttpStatusCode CreateShowReel(ShowReelDTO showReelDTO)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var showReelModel = _mapper.Map<ShowReelModel>(showReelDTO);
                    _repository.CreateShowReel(showReelModel);
                    return HttpStatusCode.Created;
                }

                return HttpStatusCode.BadRequest;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.BadGateway;
            }
        }

        [HttpGet("GetReel")]
        public async Task<ActionResult<IEnumerable<ShowReelDTO>>> GetShowReels(string name)
        {
            try
            {
                var showReelList = await _repository.GetShowReels(name);
                if(showReelList != null)
                    return Ok(_mapper.Map<IEnumerable<ShowReelDTO>>(showReelList));

                return NoContent();
            }
            catch (Exception ex)
            {
                return NoContent();
            }

        }
    }
}

