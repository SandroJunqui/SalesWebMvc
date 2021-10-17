using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)    // classe base para NOTFOUND         EXCESSAO PERSONALIDADA
        {
        }
    }
}
