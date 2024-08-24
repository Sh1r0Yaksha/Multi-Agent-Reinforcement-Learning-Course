using Classes;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            double gamma = 0.999;
            double epsilon = 1e-6;

            dynamic s1 = new StateSpace();
            s1.Add("Hostel");
            s1.Add("Academic_Building");
            s1.Add("Canteen");

            dynamic a1 = new ActionSpace();
            a1.Add("Class");
            a1.Add("Hungry");

            MDP Mdp = new MDP(s1, a1);
            var transitionsHostelClass = new List<Transition>
            {
                new Transition(s1.Hostel, 0.5, -1),
                new Transition(s1.Academic_Building, 0.5, 3)
            };
            Mdp.AddStateAction(s1.Hostel, a1.Class, transitionsHostelClass);

            var transitionsHostelHungry = new List<Transition>
            {
                new Transition(s1.Canteen, 1, 1)
            };
            Mdp.AddStateAction(s1.Hostel, a1.Hungry, transitionsHostelHungry);

            var transitionsABClass = new List<Transition>
            {
                new Transition(s1.Academic_Building, 0.7, 3),
                new Transition(s1.Canteen, 0.3, 1)
            };
            Mdp.AddStateAction(s1.Academic_Building, a1.Class, transitionsABClass);

            var transitionsABHungry = new List<Transition>
            {
                new Transition(s1.Academic_Building, 0.2, 3),
                new Transition(s1.Canteen, 0.8, 1)
            };
            Mdp.AddStateAction(s1.Academic_Building, a1.Hungry, transitionsABHungry);

            var transitionsCanteenClass = new List<Transition>
            {
                new Transition(s1.Hostel, 0.3, -1),
                new Transition(s1.Academic_Building, 0.6, 3),
                new Transition(s1.Canteen, 0.1, 1)
            };
            Mdp.AddStateAction(s1.Canteen, a1.Class, transitionsCanteenClass);

            var transitionsCanteenHungry = new List<Transition>
            {
                new Transition(s1.Canteen, 1, 1)
            };
            Mdp.AddStateAction(s1.Canteen, a1.Hungry, transitionsCanteenHungry);


            Dictionary<State, double> value = new Dictionary<State, double>();

            Dictionary<State, Classes.Action> policy = new Dictionary<State, Classes.Action>();

            Mdp.ValueIteration(out value, out policy, gamma, epsilon);
            Console.WriteLine("Optimal Values With Value Iterations:");
            foreach (var state in Mdp.States)
            {
                Console.WriteLine($"value({state}) = {value[state]:F4}");
            }

            Console.WriteLine("\nOptimal Policy:");
            foreach (var state in Mdp.States)
            {
                Console.WriteLine($"π({state}) = {policy[state]}");
            }

            Console.WriteLine("\n*************************\n");

            Mdp.PolicyIteration(out value, out policy, gamma, epsilon);
            Console.WriteLine("Optimal Values With Policy Iterations:");
            foreach (var state in Mdp.States)
            {
                Console.WriteLine($"value({state}) = {value[state]:F4}");
            }

            Console.WriteLine("\nOptimal Policy:");
            foreach (var state in Mdp.States)
            {
                Console.WriteLine($"π({state}) = {policy[state]}");
            }
        }
    }
}