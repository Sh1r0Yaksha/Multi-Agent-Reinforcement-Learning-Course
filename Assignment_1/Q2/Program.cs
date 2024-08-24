// Add nuget pythonnet
// Create a nxn grid, set n = 9
// Grid is Created by making a 2D array
// 81 states

// Set states based on their coordinate - use regex to get the corresponding coordinate
// Actions are Up, Down, Left and Right


// Add obstacles array
// Add Portal array

// Define Logic For movement, add logic for obstacle, boundary and portal

// Set Robot position
// Set Goal position

// Use Python to plot

/// <summary>
/// The Following code is for python interop and will be used later
/// </summary>
// using Python.Runtime;

// RunScript("python_script");

// static void RunScript(string scriptName)
// {
//     Runtime.PythonDLL = @"/home/shir0/miniconda3/envs/system/lib/libpython3.10.so";
//     PythonEngine.Initialize();

//     int[] array = {100, 200, 300, 400, 500};

//     using(Py.GIL())
//     {

//         dynamic sys = Py.Import("sys");
//         sys.path.append(".");

//         var PythonScript = Py.Import(scriptName);
//         var list = array.ToPython();
//         var result = PythonScript.InvokeMethod("plot", new PyObject[] {list});
//         Console.WriteLine(result);   
//     }

//     PythonEngine.Shutdown();
// }

