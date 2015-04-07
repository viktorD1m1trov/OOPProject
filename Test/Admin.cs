namespace Test
{
    using Enumerations;

    public class Admin : Organizer
    {
        public Admin(string firstName, string lastName, Gender sex = Gender.NonSpecified)
            : base(firstName, lastName, sex)
        {
        }

        public void AddEvent(Event @event)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEvent(Event @event)
        {
            throw new System.NotImplementedException();
        }
    }
}
