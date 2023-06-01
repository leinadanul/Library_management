using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_Library2._0.Services
{
    public class BookService : IBookService
    {
        private static List<Book> books = new List<Book>{};
        private readonly IMapper _mapper;
        private readonly DataContext _context;


        // Constructor de la clase service 
        public BookService(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;
        }   
        public async Task<ServiceResponse<List<GetBookDTO>>> GetAllBooks()
        {
            var ServiceResponse = new  ServiceResponse<List<GetBookDTO>>();
            var dbBook = await _context.Books.ToListAsync();
            ServiceResponse.Data = dbBook
            .Select(p=> _mapper.Map<GetBookDTO>(p)).ToList();
            return ServiceResponse;
        }
    }
    
}

