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
        grid = new Grid(4, 4, 10f);
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
