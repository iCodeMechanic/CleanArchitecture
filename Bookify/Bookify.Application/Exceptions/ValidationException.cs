using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Application.Exceptions
{
    public sealed class ValidationException : Exception
    {
        public ValidationException(IEnumerable<ValidationError> errors) 
        {
            errors = errors;    
        }

        public IEnumerable<ValidationError> Errors { get; }
    }
}
