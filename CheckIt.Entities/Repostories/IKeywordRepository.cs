
using System;
using System.Collections.Generic;
namespace CheckIt.Entities
{
    public interface IKeywordRepository
    {
        Keyword GetById(Guid id);

        IEnumerable<Keyword> GetKeywords(string text);

        IEnumerable<Keyword> GetKeywords();

        IEnumerable<Keyword> GetKeywords(Keyword Keyword);

        IEnumerable<Keyword> GetKeywordsByLang(string lang);

        IEnumerable<Keyword> GetKeywords(Keyword Keyword, string lang);

        bool SaveKeyword(Keyword Keyword);

        bool DeleteKeyword(Keyword Keyword);

        bool IncreaseHints(Guid id);
    }
}
