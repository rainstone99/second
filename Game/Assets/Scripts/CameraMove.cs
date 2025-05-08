using UnityEngine;

public class CameraMove : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(Vector3.back, Time.deltaTime * 40f);
        
    }
}
