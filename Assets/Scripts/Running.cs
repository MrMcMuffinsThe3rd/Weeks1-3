using System.Security.Cryptography;
using TreeEditor;
using Unity.Mathematics.Geometry;
using UnityEngine;
using UnityEngine.Rendering;

public class Running : MonoBehaviour
{
    //public float speed = 0.01f;
    public float pNoise;
    //x and y positions for perlin noise
    public float x;
    public float y;

    //lerp start/end object variables
    public Transform start;
    public Transform end;

    //time variable
    public float t = 0.01f;

    //animation curve variable for easing
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        //moves the object between 2 transform positions relative to time
        transform.position = Vector2.Lerp(start.position, end.position, t);

        float y = curve.Evaluate(t); //evaluates the curve
        transform.localPosition = Vector3.one * curve.Evaluate(t); //eases the lerp using an animation curve

        pNoise = Mathf.PerlinNoise(x, y);
    }
}
