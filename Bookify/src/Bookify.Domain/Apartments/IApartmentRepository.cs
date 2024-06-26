﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments
{
    public interface IApartmentRepository
    {
        Task<Appartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
