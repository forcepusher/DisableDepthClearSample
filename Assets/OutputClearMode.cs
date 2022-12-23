using UnityEngine;

[RequireComponent(typeof(Camera))]
public class OutputClearMode : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"Clear Flags = {GetComponent<Camera>().clearFlags}");
    }
}
