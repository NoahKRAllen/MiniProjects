using UnityEngine;
public class TestingGrid : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    private Grid grid;
    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
        grid = new Grid(4, 4, 10f, new Vector3(5,0,0));
        grid = new Grid(4, 2, 4f, new Vector3(0,0,3));
        grid = new Grid(8, 4, 7f, new Vector3(5,0,9));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Vector3 worldPos = hit.point;
                worldPos.y = 0;
                grid.SetValue(worldPos, 69);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Vector3 worldPos = hit.point;
                worldPos.y = 0;
                Debug.Log(grid.GetValue(worldPos));
            }
        }
    }
}
