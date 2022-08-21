using System;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TimeCodeAPI.Controllers;
using TimeCodeAPI.Domain;
using TimeCodeAPI.Services;

namespace TimeCodeAPITest
{
    public class TimecodeControllerTest
    {
        private readonly Mock<IMapper> _mapper = new Mock<IMapper>();
        private readonly Mock<ITimecodeService> _service = new Mock<ITimecodeService>();
        private TimecodeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new TimecodeController(_service.Object, _mapper.Object);
        }

        [Test]
        public void CheckResponseWhenTimeAddedToTotalDuration()
        {
            TimecodeModel model = new TimecodeModel()
            {
                TotalTimeDuration = new TimeModel()
            };

            _mapper.Setup(x => x.Map<TimecodeModel>(It.IsAny<TimecodeDTO>())).Returns(model);

            _service.Setup(y => y.AddTimeToTotalTimeDuration(model));

            var  result = _controller.GetTotalTimeDurationByAdding(It.IsAny<TimecodeDTO>());
            var okObjectResult = (OkObjectResult)result.Result;

            okObjectResult.StatusCode.Equals(200);

        }

        [Test]
        public void CheckResponseWhenTimeIsNotAddedDueToSomeUnknownReason()
        {
            TimecodeModel model = new TimecodeModel()
            {
                TotalTimeDuration = null
            };

            _mapper.Setup(x => x.Map<TimecodeModel>(It.IsAny<TimecodeDTO>())).Returns(model);

            model.TotalTimeDuration =  new TimeModel();
            _service.Setup(y => y.AddTimeToTotalTimeDuration(model));

            var result = _controller.GetTotalTimeDurationByAdding(It.IsAny<TimecodeDTO>());
            var okObjectResult = (OkObjectResult)result.Result;

            okObjectResult.StatusCode.Equals(200);
        }

        [Test]
        public void CheckResponseWhenTimeRemovedToTotalDuration()
        {
            TimecodeModel model = new TimecodeModel()
            {
                TotalTimeDuration = new TimeModel()
            };

            _mapper.Setup(x => x.Map<TimecodeModel>(It.IsAny<TimecodeDTO>())).Returns(model);


            _service.Setup(y => y.RemoveTimeFromTotalTimeDuration(model));

            var result = _controller.GetTotalTimeDurationByRemoving(It.IsAny<TimecodeDTO>());

            var okObjectResult = (OkObjectResult)result.Result;

            okObjectResult.StatusCode.Equals(200);
        }

        [Test]
        public void CheckResponseWhenTimeRemovedIsGreaterThanTotalDuration()
        {
            TimecodeModel model = new TimecodeModel()
            {
                TotalTimeDuration = null
            };

            _mapper.Setup(x => x.Map<TimecodeModel>(It.IsAny<TimecodeDTO>())).Returns(model);
            model.TotalTimeDuration = new TimeModel();
            _service.Setup(y => y.RemoveTimeFromTotalTimeDuration(model));
           

            var result = _controller.GetTotalTimeDurationByRemoving(It.IsAny<TimecodeDTO>());

            var okObjectResult = (OkObjectResult)result.Result;

            okObjectResult.StatusCode.Equals(200);
        }

    }
}

