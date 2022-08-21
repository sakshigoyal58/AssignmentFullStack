using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TimeCodeAPI.Domain;
using TimeCodeAPI.Services;

namespace TimeCodeAPI.Controllers
{
    [Route("api/[controller]")]
    public class TimecodeController : Controller
    {
        private readonly ITimecodeService _service;
        private readonly IMapper _mapper;

        public TimecodeController(ITimecodeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("GetTotalByAdd")]
        public ActionResult<TimecodeDTO> GetTotalTimeDurationByAdding(TimecodeDTO timecodeDTO)
        {
            try
            {
                var timeCodeModel = _mapper.Map<TimecodeModel>(timecodeDTO);

                _service.AddTimeToTotalTimeDuration(timeCodeModel);

                if (timeCodeModel.TotalTimeDuration != null)
                    return Ok(_mapper.Map<TimecodeDTO>(timeCodeModel));

                return NoContent();
            }
            catch (Exception ex)
            {
                return NoContent();
            }


           
        }

        [HttpGet("GetTotalByRemove")]
        public ActionResult<TimecodeDTO> GetTotalTimeDurationByRemoving(TimecodeDTO timecodeDTO)
        {
            try
            {
                var timeCodeModel = _mapper.Map<TimecodeModel>(timecodeDTO);
                _service.RemoveTimeFromTotalTimeDuration(timeCodeModel);

                if (timeCodeModel.TotalTimeDuration != null)
                    return Ok(_mapper.Map<TimecodeDTO>(timeCodeModel));

                return NoContent();

            }
            catch (Exception ex)
            {
                return NoContent();
            }
            
        }


    }
}

