namespace Classes
{
    public class State
    {
        public string Name { get; set; }

        public State(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}