using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Week2CodingGymEx1 : MonoBehaviour
{

    public float speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        //newPos.x += speed; //moves circle in x (left and right)
        newPos.y += speed; //moves circle in y (up and down)
        transform.position = newPos;

        

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //if (screenPos.x < -10 || screenPos.x > Screen.width) //checks for the edges left and right
        //{
        //    speed = speed * -1;
        //}

        if (screenPos.y < -10 || screenPos.y > Screen.height) //checks for the edges up and down
        {
            speed = speed * -1;
        }
    }
}
