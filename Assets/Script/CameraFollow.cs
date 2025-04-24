using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 position;
    public float changeSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 changePlayer = player.position + position;
        Vector3 velocityCamera = Vector3.Lerp(transform.position, changePlayer, changeSpeed * Time.deltaTime);
        transform.position = velocityCamera;
    }
    public void SetChange(Transform NewChange)
    {
        player = NewChange;
    }
}
