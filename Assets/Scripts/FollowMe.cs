using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMe : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()); //instead of moving the mouse with the whole monitor (circle moving with mouse)
                                                                                               //we use the camera to set the world pixels
        transform.position = mousePos;

        //OR

        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //mousePos.z = 0;
        //transform.position = mousePos;

    }
}
