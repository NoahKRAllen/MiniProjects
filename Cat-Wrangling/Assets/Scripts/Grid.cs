using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.UIElements;

public class Grid
{
    private int xWidth;
    private int zHeight;

    private float cellSize;
    private int[,] gridArray;
    private TextMesh[,] debugTextArray;
    
    public Grid(int width, int height, float cellSize)
    {
        this.xWidth = width;
        this.zHeight = height;

        this.cellSize = cellSize;
        
        gridArray = new int[xWidth, zHeight];
        debugTextArray = new TextMesh[xWidth, zHeight];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int z = 0; z < gridArray.GetLength(1); z++)
            {
                    //Debug.Log(x + ", " + y);
                    //TODO: Change into 3D grid adding in Z to work with 3D objects
                    debugTextArray[x,z] = UtilsClass.CreateWorldText(gridArray[x, z].ToString(), null, GetWorldPosition(x, z) + new Vector3(cellSize, 0 , cellSize) *.5f, 20, Color.white, TextAnchor.MiddleCenter, TextAlignment.Center, 5000, true);
 
                    Debug.DrawLine(GetWorldPosition(x, z), GetWorldPosition(x + 1, z), Color.white, 100f);
                    Debug.DrawLine(GetWorldPosition(x, z), GetWorldPosition(x , z + 1), Color.white, 100f);
                
            }
        }
        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
        Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);
        
        SetValue(2, 1, 59);
    }

    private Vector3 GetWorldPosition(int x, int z)
    {
        //Debug.Log(new Vector3(x, 0, z) * cellSize);
        return new Vector3(x, 0, z) * cellSize;
    }

    private void GetXZ(Vector3 worldPosition, out int x, out int z)
    {
        x = Mathf.FloorToInt(worldPosition.x / cellSize);
        z = Mathf.FloorToInt(worldPosition.z / cellSize);
    }

    public void SetValue(int x, int z, int value)
    {
        if (x >= 0 && z >= 0 && x < xWidth && z < zHeight)
        {
            gridArray[x, z] = value;
            debugTextArray[x, z].text = value.ToString();
        }
    }

    public void SetValue(Vector3 worldPosition, int value)
    {
        GetXZ(worldPosition, out var x, out var z);
        SetValue(x, z, value);
    }

    public int GetValue(int x, int z)
    {
        if (x >= 0 && z >= 0 && x < xWidth && z < zHeight)
        {
            return gridArray[x, z];
        }
        else
        {
            return -1;
        }
    }
    public int GetValue(Vector3 worldPosition)
    {
        GetXZ(worldPosition, out var x, out var z);
        return GetValue(x, z);
    }
    
}
