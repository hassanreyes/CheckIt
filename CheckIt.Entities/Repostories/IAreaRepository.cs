using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public interface IAreaRepository
    {
        Area GetById(Guid id);

        IEnumerable<Area> GetAreas();

        Area GetByName(string name);

        bool SaveArea(Area area);

        bool DeleteArea(Area area);

    }
}
