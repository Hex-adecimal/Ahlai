using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        if (Time.time < 60f)
        {
            transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
        }
        else if (Time.time < 120f)
        {
            transform.position += new Vector3(2 *cameraSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position += new Vector3(3 * cameraSpeed * Time.deltaTime, 0, 0);
        }
    }
}
