using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_Library2._0
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Book, GetBookDTO>();
            CreateMap<AddBookDTO, Book>();
            CreateMap<UpdateBookDTO, Book>();

        }
    }
}