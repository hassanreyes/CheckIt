using System;

namespace CheckIt.Entities
{
    [Flags]
    public enum AccessLevel : int
    {
        AllowView = 0,
        AllowEdit = 1,
        AllowUse = 2
    }
}
