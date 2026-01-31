using System.Security.Cryptography;
using TreeEditor;
using Unity.Mathematics.Geometry;
using UnityEngine;
using UnityEngine.Rendering;

public class Running : MonoBehaviour
{
    public float speed;

    //lerp start/end object variables
    public Transform start;
    public Transform end;

    //time variable
    public float t = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime * speed; //slows down the movement of the astronaut
        if (t > 1.4)
        {
            t = 0;
        }

        //lerps the movement of the astronaut between two positions relative to time
        transform.position = Vector2.Lerp(start.position, end.position, t);
    }

    //type out readings and classwork (practice and also we need them for grades)
}
