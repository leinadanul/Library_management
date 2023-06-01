using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_Library2._0.Models
{
    public class ServiceResponse<T>
    {
        public T? Data {get; set;}

        public bool Success {get;set;} = true;

        public string Message {get;set;} = string.Empty;
    }
}

// Esta es un contenedor para respuestas del contenido del service 
// tiene propiedades de mensaje, exito, error en el codigo y el contenido "Data"