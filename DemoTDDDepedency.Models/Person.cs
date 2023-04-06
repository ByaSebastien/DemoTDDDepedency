namespace DemoTDDDepedency.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object o)
        {
            if (o is Person p)
                return Id == p.Id && FirstName == p.FirstName && LastName == p.LastName;
            return false;
        }

        //public static bool operator ==(Person a, Person b)
        //{
        //    return a.Id == b.Id && a.FirstName == b.FirstName && a.LastName == b.LastName;
        //}
        //public static bool operator !=(Person a, Person b)
        //{
        //    return !(a == b);
        //}
    }
}