using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    public Vector3 Offset;
    private void LateUpdate()
    {
        camera.transform.position = player.transform.position + Offset; 
    }
}
