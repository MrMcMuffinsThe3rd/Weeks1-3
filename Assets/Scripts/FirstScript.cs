using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created (setup)
    void Start()
    {
        
    }

    // Update is called once per frame (draw)
    void Update()
    {
        //no bouncing off edges

        //Vector2 newPos = transform.position;
        //newPos.x += 0.01f; //f converts into float
        //transform.position = newPos;

        //bouncing off edges

        Vector2 newPos = transform.position;
        newPos.x += speed;
        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position); //sets the screen.width to meters instead of screen pixels

        if (screenPos.x < -10 || screenPos.x > Screen.width) 
        {

            speed = speed * -1;
        
        }
    }
}
