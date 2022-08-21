using TimeCodeAPI.Controllers;
using TimeCodeAPI.Services;
using Moq;
using AutoMapper;
using TimeCodeAPI.Domain;

namespace TimeCodeAPITest;

public class TimecodeServiceTest
{
    ITimecodeService _service;
    DataClass _data;
    [SetUp]
    public void Setup()
    {
        _service = new TimecodeService();
        _data = new DataClass();
    }

    [Test]
    public void CheckIfTimeAddedForFirstTimeTest()
    {
        var timeCodeModel = _data.CreateModelToAddVideoFirstTime();

        _service.AddTimeToTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 30);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 23);
        Assert.IsNull(timeCodeModel.ErrorMessage);
    }

    [Test]
    public void CheckIfTimeAddedForPALTest()
    {
        var timeCodeModel = _data.CreateModelForPALVideoToAdd();

        _service.AddTimeToTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 01);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 46);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 22);
        Assert.IsNull(timeCodeModel.ErrorMessage);
    }

    [Test]
    public void CheckIfTimeAddedForNTSCTest()
    {
        var timeCodeModel = _data.CreateModelForNTSCVideoToAdd();

        _service.AddTimeToTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 01);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 46);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 27);
        Assert.IsNull(timeCodeModel.ErrorMessage);
    }

    [Test]
    public void CheckIfTimeRemovedForPALTest()
    {
        var timeCodeModel = _data.CreateModelForPALVideoToRemove();

        _service.RemoveTimeFromTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 45);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 02);
        Assert.IsNull(timeCodeModel.ErrorMessage);
    }

    [Test]
    public void CheckIfTimeRemovedForNTSCTest()
    {
        var timeCodeModel = _data.CreateDataTimeForNTSCVideoToRemove();

        _service.RemoveTimeFromTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 45);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 01);
        Assert.IsNull(timeCodeModel.ErrorMessage);
    }

    [Test]
    public void CheckIfTimeRemovedWhenSecondsAreGreaterTest()
    {
        var timeCodeModel = _data.CreateModelWhereSecondsAreGreater();

        _service.RemoveTimeFromTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 01);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 15);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 24);
        Assert.AreEqual(timeCodeModel.ErrorMessage, "Time to be removed is greater than Total Duration");
    }

    [Test]
    public void CheckIfTimeRemovedWhenFramesAreGreaterTest()
    {
        var timeCodeModel = _data.CreateModelWhereFramesAreGreater();

        _service.RemoveTimeFromTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 24);
        Assert.IsNull(timeCodeModel.ErrorMessage);
    }

    [Test]
    public void CheckTotalDurationWhenTimeRemovedIsEqualToDurationTest()
    {
        var timeCodeModel = _data.CreateModelWhereCalculatedTimeIsEqual();

        _service.RemoveTimeFromTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 00);
        Assert.IsNull(timeCodeModel.ErrorMessage);
    }

    [Test]
    public void CheckIfModelIsNullForPALTest()
    {
        var timeCodeModel = _data.CreateDataTimeForPALVideoToNotRemove();

        _service.RemoveTimeFromTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 01);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 15);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 40);
        Assert.AreEqual(timeCodeModel.ErrorMessage, "Time to be removed is greater than Total Duration");
    }

    [Test]
    public void CheckIfModelIsNullForNTSCTest()
    {
        var timeCodeModel = _data.CreateDataTimeNTSCVideoToNotRemove();

        _service.RemoveTimeFromTotalTimeDuration(timeCodeModel);

        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Hour, 00);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Minutes, 01);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Seconds, 15);
        Assert.AreEqual(timeCodeModel.TotalTimeDuration.Frames, 40);
        Assert.AreEqual(timeCodeModel.ErrorMessage, "Time to be removed is greater than Total Duration");
    }
}