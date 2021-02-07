using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlanet : MonoBehaviour
{
    [SerializeField] float engelhiz = 5F;
    [SerializeField] float engelyayilim = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time * engelhiz) * engelyayilim; 
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);
        
    }
}
