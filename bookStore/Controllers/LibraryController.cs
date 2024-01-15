using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("GetBooksByAuthor")]
        public GetBooksByAuthorResponse?
            GetBooksByAuthor(GetBooksByAuthorRequest? request)
        {
            if (request == null) return null;

            return _libraryService.GetBooksByAuthor(request);
        }

        [HttpPost("TestEndpoint")]
        public string GetTestEndpoint(
            [FromBody] TestRequest request)
        {
            return "Test OK";
        }

    }
}
