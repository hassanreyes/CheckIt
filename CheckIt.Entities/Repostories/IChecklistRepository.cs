﻿
using System;
using System.Collections.Generic;
namespace CheckIt.Entities
{
    public interface IChecklistRepository
    {
        Checklist GetById(Guid id);

        IEnumerable<Checklist> GetChecklists(Category category = null);

        IEnumerable<Checklist> GetChecklists(Guid[] ids);

        bool SaveChecklist(Checklist chklst);

        bool DeleteChecklist(Category chklst);

        bool IncreaseHints(Guid id);

        bool SetRating(Guid id, short rating);

        Guid[] SearchText(string searchText);
    }
}
