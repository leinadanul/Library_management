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

        //Service para obtener todos los libros que se encuenrran en la lista 
        public async Task<ServiceResponse<List<GetBookDTO>>> GetAllBooks()
        {
            var serviceResponse = new  ServiceResponse<List<GetBookDTO>>();
            var dbBook = await _context.Books.ToListAsync();
            serviceResponse.Data = dbBook
            .Select(p=> _mapper.Map<GetBookDTO>(p)).ToList();
            return serviceResponse;
        }


        //Service de Post Para publicar nuevo libro 

        public async Task Save(Book book)
    {
        _context.Add(book);
        await _context.SaveChangesAsync();
    }


        
        public async Task<ServiceResponse<List<GetBookDTO>>> AddBook(AddBookDTO NewBook)
        {
            var serviceResponse = new ServiceResponse<List<GetBookDTO>>();
            var book = _mapper.Map<Book>(NewBook);

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            serviceResponse.Data = books
            .Select(p => _mapper.Map<GetBookDTO>(p)).ToList();
            return serviceResponse;
        }
        

    }
    
}

