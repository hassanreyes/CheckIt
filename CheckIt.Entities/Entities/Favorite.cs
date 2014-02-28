
namespace CheckIt.Entities
{
    public partial class Favorite : Entity
    {
        public virtual Account Account { get; set; }
        public virtual Checklist Checklist { get; set; }
        public virtual Section Section { get; set; }
        public virtual Item Item { get; set; }
    }
}
