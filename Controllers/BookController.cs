using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Manage_Library2._0.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;

        //Constructor
        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetBookDTO>>>> Get()
        {
            return Ok(await _bookService.GetAllBooks());
        }
    }
}