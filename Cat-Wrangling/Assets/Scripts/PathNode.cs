using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathNode : MonoBehaviour
{
    //private Grid<PathNode> grid;
    private int x;
    private int y;

    public int gCost;
    public int hCost;
    public int fCost;

    public PathNode cameFromNode;

    /*public PathNode(Grid<PathNode> grid, int x, int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
    }*/

    public override string ToString()
    {
        return x + "," + y;
    }
}
