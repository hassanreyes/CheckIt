
namespace CheckIt.Entities
{
    public partial class Share : Entity
    {
        public AccessLevel AccessLevel { get; set; }

        public virtual Account SharedBy { get; set; }
        public virtual Checklist Checklist { get; set; }
        public virtual User User { get; set; }
    }
}
