using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType(string value) : base(value)
        {
        }
        /*
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }



        public PositionType(string value) : this()
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PositionType);
        }

        public bool Equals(PositionType other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }



        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.*/

    }
}
