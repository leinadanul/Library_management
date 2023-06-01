using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_Library2._0.DTO.Book
{
    public class UpdateBookDTO
    {
    public int Id {get;set;}       
    public string ISBN {get;set;} = "df897324y5r7823";
    public string title {get;set;} = "las aventuras de tom";
    public string author {get;set;} = "pepe Grillo";
    public string genere {get;set;} = "comedia";
    public int amountCopies {get;set;} = 100;
    }
}