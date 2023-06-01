using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_Library2._0.DTO.Book
{
    public class AddBookDTO
    {
        

    public string ISBN {get;set;}
    public string title {get;set;}
    public string author {get;set;}
    public string genere {get;set;}
    public int amountCopies {get;set;}
    }
}