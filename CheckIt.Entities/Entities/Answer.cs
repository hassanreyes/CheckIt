
namespace CheckIt.Entities
{
    public abstract partial class Answer : Entity
    {
        public virtual byte[] Value { get; set; }
        //public virtual ItemType Type { get; set; }

        public virtual Item Item { get; set; }
        public virtual User User { get; set; }
    }
}
