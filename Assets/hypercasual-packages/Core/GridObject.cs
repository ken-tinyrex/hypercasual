using Hypercasual.Implementation;
using UnityEngine;
using Grid = Hypercasual.Implementation.Grid;

public class GridObject : MonoBehaviour
{
    private Grid _grid;

    void Start()
    {
        _grid = new Grid(10, 10, 1, new Vector3(-5f, 0f, -5f));    
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePosition = Utils.GetMouseWorldPositionWithZ();
            Debug.Log($"[mouse click] : {mousePosition}");
            _grid.SetValue(Utils.GetMouseWorldPositionWithZ(), 10);
        }

        if (Input.GetMouseButtonDown(1))
        {
            var mousePosition = Utils.GetMouseWorldPositionWithZ();
            Debug.Log($"[mouse click] : {mousePosition}");
            Debug.Log(_grid.GetValue(mousePosition));
        }
    }
}
