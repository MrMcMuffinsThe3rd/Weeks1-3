using UnityEngine;

public class DirectionalMovement : MonoBehaviour
{
    public float speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.right is like saying "new Vector3(1,0,0)"
        //transform.up is like saying "new Vector3(0,1,0)" and so on and so forth
        //transform.forward is like Vectir3(0,0,1) <-- DO NOT USE IN 2D PROJECTS
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
