using System;

namespace ServiceWebMvc.Services.Exceptions
{
    public class NotFoundException : AccessViolationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
