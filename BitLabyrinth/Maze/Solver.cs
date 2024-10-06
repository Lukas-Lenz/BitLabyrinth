using BitLabyrinth;
using BitLabyrinth.Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitLabyrinth
{
    internal interface MazeSolver
    {
        MazePath SolveMaze(int cutoff);
        MazePath NextSteps(int numSteps);

    }
}
