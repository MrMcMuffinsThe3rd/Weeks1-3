using UnityEngine;

public class Companion : MonoBehaviour
{
    public Transform triangle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Vector2 newPos = triangle.position;

        //if (triangle.position.x < 0)
        //{
        //    //set our position to be -2
        //    newPos.x = triangle.position.x - 2;
        //}
        //else
        //{
        //    //set our position to be +2
        //    newPos.x = triangle.position.x + 2;
        //}

        //transform.position = newPos;




        //THE BETTER WAY

        Vector2 newPos = triangle.localPosition;

        if(triangle.position.x  < 0)
        {
            //set our position to be -2
            newPos.x = triangle.position.x - 2;
        }
        else
        {
            //set our position to be +2
            newPos.x = triangle.position.x + 2;
        }

        transform.localPosition = newPos;
    }
}
