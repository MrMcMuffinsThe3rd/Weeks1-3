using UnityEngine;

public class Floating : MonoBehaviour
{

    public float speed;

    float x;

    //lerp start/end object variables
    public Transform start;
    public Transform end;

    //time variable
    public float t = 0;

    //animation curve variable
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;
        if (t > 0.5) //decreased so that the alien is always behind the astronaut
        {
            t = 0;
        }

        //lerps the movement of the monster between two positions relative to time
        transform.position = Vector2.Lerp(start.position, end.position, t);

       float y = curve.Evaluate(t);

        //makes the mosnter float up and down using perlin noise
        Vector2 newYPos = transform.position;
        newYPos.y = Mathf.PerlinNoise(x,y) * t; //attempt at perlin noise usage
        transform.position = newYPos;



        //left to do:
        //add perlin noise to ufo
        //set light to "spot"
        //done
    }
}
