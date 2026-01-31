using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles; //NOTT VECTOR2!!!
                                                      //Why? because you rotate using the z axis
                                                      //and the z axis only exists in 3D (hence vector3)
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    }
}
