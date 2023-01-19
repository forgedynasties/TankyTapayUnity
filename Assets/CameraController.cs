using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;

    private Vector3 previousTouchPosition;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                previousTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Vector3 touchDeltaPosition = (Vector3)touch.position - (Vector3)previousTouchPosition;
                transform.Translate(-touchDeltaPosition.x * panSpeed * Time.deltaTime, -touchDeltaPosition.y * panSpeed * Time.deltaTime, 0);
                previousTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                //smoothly reset camera
                transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, 0), Time.deltaTime * 5f);
            }
        }
    }
}