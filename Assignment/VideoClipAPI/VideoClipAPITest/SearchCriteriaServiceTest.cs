using System.Xml.Linq;
using VideoClipAPI.Services;

namespace VideoClipAPITest;

public class SearchCriteriaServiceTest :IClassFixture<DbContext>
{
    private readonly DbContext _context;
    private readonly ISearchCriteriaService _service;

    public SearchCriteriaServiceTest(DbContext context)
    {
        _context = context;
        _service = new SearchCriteriaService(_context.context);
    }

    [Fact]
    public void GetAllVideoDefinitions()
    {
        var data = _service.GetAllVideoDefinitions();

        data.Result.Count.Equals(2);
        data.Result.Any(x => x.Value.Equals("HD"));
        data.Result.Any(x => x.Value.Equals("SD"));
    }

    [Fact]
    public async Task GetAllVideoStandards()
    {
        var data = _service.GetAllVideoStandards();

        data.Result.Count.Equals(2);
        data.Result.Any(x => x.Value.Equals("PAL"));
        data.Result.Any(x => x.Value.Equals("NTSC"));
    }
}
