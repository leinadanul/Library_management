using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Manage_Library2._0.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
    
        private readonly IBookService _bookService;

        //Constructor
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
///////////////////////////////////////////////////////////////////////////////////// Iniciando ////////////////////////////////////////////////////////////////////////
        //GET
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetBookDTO>>>> Get()
        {
            return Ok(await _bookService.GetAllBooks());
        }
        
        //GET ID
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetBookDTO>>> GetBookId(int id)
        {
            return Ok(await _bookService.GetBookById(id));
        }

        
        //POST
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetBookDTO>>>> AddBook( AddBookDTO newBook)
        {
            
            return Ok(await _bookService.AddBook(newBook));
        }
    
    
    }
}