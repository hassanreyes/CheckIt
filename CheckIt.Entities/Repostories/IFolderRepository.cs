using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public interface IFolderRepository
    {
        Folder GetById(Guid id);

        IEnumerable<Folder> GetFolders(Account account);

        IEnumerable<Folder> GetSubFolders(Folder folder);

        Folder GetRootFolder(Account account);

        bool SaveFolder(Folder Folder);

        bool DeleteFolder(Folder Folder);

        bool SetStatus(Guid id, FolderStatus status);
    }
}
