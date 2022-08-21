using AutoMapper;
using ShowReelsAPI.Controllers;
using ShowReelsAPI.Services;

namespace ShowReelsAPITest;

public class ShowReelServiceTest :IClassFixture<DbContext>
{
    private readonly DbContext _context;
    private readonly IShowReelService _service;
    private readonly DataClass _data;

    public ShowReelServiceTest(DbContext context)
    {
        _context = context;
        _data = new DataClass();
        _service = new ShowReelService(_context.context);

    }



    [Fact]
    public async Task InsertVideoClip()
    {
        await _service.AddShowReel(_data.CreateShowReelWithOneVideoClip());
        var data = _service.GetShowReelsByName("dummy_reel");

        data.Result.Any(x => x.Name.Equals("dummy_reel"));
    }

    [Fact]
    public async Task InsertMultipleVideoClip()
    {
        await _service.AddShowReel(_data.CreateShowReelWithMultipleVideoClip());
        var data = _service.GetShowReelsByName("dummy_reel1");

        data.Result.Any(x => x.Name.Equals("dummy_reel1"));
        data.Result.Any(x => x.VideoClips.Count == 2);
    }

    [Fact]
    public async Task ShouldVideoClipInsertedWithExistingName()
    {
        await _service.AddShowReel(_data.CreateShowReelWithSameNameVideoClip());
        var ex = Assert.ThrowsAsync<MongoDB.Driver.MongoWriteException>(() =>
                                _service.AddShowReel(_data.CreateShowReelWithSameNameVideoClip()));

        Assert.Contains("A write operation resulted in an error", ex.Result.Message);
    }


    [Fact]
    public void ShouldReelInsertedWhenModelIsNull()
    {
        var ex = Assert.ThrowsAsync<ArgumentNullException>(() =>  _service.AddShowReel(null));

        Assert.Contains("Value cannot be null", ex.Result.Message);
      
    }

    [Fact]
    public async Task ShouldReelInsertedWhenNameIsNull()
    {
        await _service.AddShowReel(_data.CreateShowReelWhereNameIsNull());
        var ex = Assert.ThrowsAsync<MongoDB.Driver.MongoWriteException>(() =>
                                _service.AddShowReel(_data.CreateShowReelWhereNameIsNull()));

        Assert.Contains("A write operation resulted in an error", ex.Result.Message);

    }

}
