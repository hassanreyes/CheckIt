using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public interface ISectionRepository
    {
        Section GetById(Guid id);

        IEnumerable<Section> GetSections(Checklist chklst);

        bool SaveSection(Section section);

        bool DeleteSection(Section section);

        bool IncreaseHints(Guid id);
    }
}
