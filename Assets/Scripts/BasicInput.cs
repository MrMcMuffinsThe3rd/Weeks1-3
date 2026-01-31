using UnityEngine;
using UnityEngine.InputSystem;

public class BasicInput : MonoBehaviour
{
    public bool leftMouseIsPressed = false;
    public bool rightMouseIsPressed = false;
    public bool anyKeyIsPressed = false;

    public float speed = 3;
    public float rotationalSpeed = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mouse position: Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue())

        //isPressed is true all the time the button is pressed
        leftMouseIsPressed = Mouse.current.leftButton.isPressed;
        rightMouseIsPressed = Mouse.current.rightButton.isPressed;

        //wasPressedThisFrame is true the first frame the button is pressed only
        //wasReleasedThisFrame is true the first frame the button is released only
        if(Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Debug.Log("Left Button Pressed");
        }
        if(Mouse.current.rightButton.wasPressedThisFrame == true)
        {
            Debug.Log("Right Button Pressed");
        }

        anyKeyIsPressed = Keyboard.current.anyKey.isPressed;

        //test for left arrow key: move to left
        if(Keyboard.current.leftArrowKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }
        //test for right arrow key: move to the right
        if(Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Keyboard.current.upArrowKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        }
        //test for right arrow key: move to the right
        if (Keyboard.current.downArrowKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }


        //////rotation using directional vector of the object///////

        //test for left arrow key: move to left
        if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            Vector3 newPosition = transform.eulerAngles;
            newPosition.x += speed * Time.deltaTime;
            transform.eulerAngles = newPosition;
        }
        //test for right arrow key: move to the right
        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector3 newPosition = transform.eulerAngles;
            newPosition.x -= speed * Time.deltaTime;
            transform.eulerAngles = newPosition;
        }
        if (Keyboard.current.upArrowKey.isPressed == true)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        //test for right arrow key: move to the right
        if (Keyboard.current.downArrowKey.isPressed == true)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
    }
}
