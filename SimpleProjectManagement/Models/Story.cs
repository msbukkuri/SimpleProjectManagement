namespace SimpleProjectManagement.Models
{
    public class Story
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int PointValue { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Story)) return false;
            return Equals((Story)obj);
        }

        public bool Equals(Story other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Id, Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}