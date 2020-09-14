using System;
using System.Collections.Generic;

namespace PetClinic.Domain.Common
{
    public interface IInitialData
    {
        Type EntityType { get; }

        IEnumerable<object> GetData();
    }
}
