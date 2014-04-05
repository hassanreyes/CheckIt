
namespace CheckIt.Entities
{
    public class UserPreferences
    {
        public int PageSize { get; set; }

        public struct Defaults
        {
            ///Pagination
            public static int PageSize = 2;
        }

        public UserPreferences()
        {
            this.PageSize = UserPreferences.Defaults.PageSize;
        }
    }
}
