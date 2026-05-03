using UnityEngine;

public class ItemRemover : MonoBehaviour
{
    public bool deleteMode = false;

    void Update()
    {
        if (!deleteMode) return;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Removable"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    public void ToggleDeleteMode()
    {
        deleteMode = !deleteMode;
    }
}