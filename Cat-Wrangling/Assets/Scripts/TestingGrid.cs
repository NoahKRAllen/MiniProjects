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
        grid = new Grid(20, 20, 10f, Vector3.zero);
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

    private class HeatMapVisual
    {
        private Grid grid;
        private Mesh mesh;

        public HeatMapVisual(Grid grid, MeshFilter meshFilter)
        {
            this.grid = grid;
            
            mesh = new Mesh();
            meshFilter.mesh = mesh;

            UpdateHeatMapVisual();

            grid.OnGridValueChanged += Grid_OnGridValueChanged;
        }

        private void Grid_OnGridValueChanged(object sender, System.EventArgs e)
        {
            UpdateHeatMapVisual();
        }

        public void UpdateHeatMapVisual()
        {
            Vector3[] vertices;
            Vector2[] uv;
            int[] triangles;
            
            
        }
    }
}
