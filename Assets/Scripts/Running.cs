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
    public float t = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime * speed;
        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, t);



        //left to do:
        //add easing to astro running
        //do the same for monster floating
        //add perlin noise to ufo
        //set light to "spot"
        //done
    }
}
