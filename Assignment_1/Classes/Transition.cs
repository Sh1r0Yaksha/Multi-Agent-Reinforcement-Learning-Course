
namespace Classes
{
    public class Transition
    {
        public State NextState { get; set; }
        public double Probability { get; set; }
        public double Reward { get; set; }

        public Transition(State nextState, double probability, double reward)
        {
            NextState = nextState;
            Probability = probability;
            Reward = reward;
        }
    }
}