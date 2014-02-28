using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public interface IItemRepository
    {
        Item GetById(Guid id);

        IEnumerable<Item> GetItems(Checklist chklst);

        IEnumerable<Item> GetItems(Section section);

        bool SaveItem(Item item);

        bool DeleteItem(Item item);

        bool IncreaseHints(Guid id);

        bool SetStatus(Guid id, ItemStatus status);
    }
}
