using UnityEngine;

public class RemoveOnClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
