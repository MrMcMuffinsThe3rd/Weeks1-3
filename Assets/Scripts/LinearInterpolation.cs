using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //public Vector2 startPoition;
    public Transform start;

    //public Vector2 endPoition;
    public Transform end;

    public AnimationCurve curve;

    public float t = 0; 

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

        //transform.position = Vector2.Lerp(startPoition, endPoition, t);
        transform.position = Vector2.Lerp(start.position, end.position, t);

        float y = curve.Evaluate(t);

        //transform.localScale = Vector3.one * curve.Evaluate(t);

    }
}
