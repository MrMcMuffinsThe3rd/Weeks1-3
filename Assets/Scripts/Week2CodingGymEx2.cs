using UnityEngine;

public class Week2CodingGymEx2 : MonoBehaviour
{

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 newPosition = transform.position;
       newPosition.x += 3 * Time.deltaTime;
        transform.position = Random.insideUnitCircle * Time.deltaTime;
    }
}
