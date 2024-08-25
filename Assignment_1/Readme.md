# Classes

This is a library project created for sharing the reusable codes for both Questions. The files are explained as follows

### Action.cs
This is a class made to store the various actions in the Action Space

### ActionSpace.cs
This class is used to store the whole action space with methods to add actions and get a list of all actions in the action space

### MDP.cs
This class is used to create the MDP with the complete state space, action space, and transitions, and it includes methods for performing value iteration and policy iteration. This class is the core of this assignment.

### State.cs
Made to store the states similar to Action class

### StateAction.cs
This class is used to store the store all of the transitions from one state by an action.

### StateSpace.cs
This class is used to store state space similar to ActionSpace

### Transition
This class is used to store the transition from a state to the next, as well as the transition probabiltity and reward

# Q1
This only has Program.cs Class which has the main function, all of the states and transitions are added accordingly and value and policy iteration is done which are stored in the Results.txt file

# Q2
    
This is used to solve the 2nd question and plot its results using python with the Python.NET package for C# and python interoperation

### Coordinate.cs

This class is used to generate a (x,y) tuple with some methods to compare with other coordinates

### Environment.cs

This class is used to generalise the environment generation where we can give the grid size, walkable tiles, obstacles, portals and goals and it will create states according to the coordinates given

### Program.cs
Here the MDP is generated using the environment and all of the rewards are given according to the tiles. Value and Policy iteration is done, Python interop is used to provide the values of all the iterations to the python scripts and the methods are run.

### main.py
Here the values from C# is taken as parameter and further used to create a heatmap where all the tiles are given their values and quiver plot is generated