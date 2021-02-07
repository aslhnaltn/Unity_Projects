using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleObstacles : MonoBehaviour
{
    [SerializeField] float hiz = 5F;
    [SerializeField] float yayilim = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time * hiz) * yayilim; 
        float z = transform.position.z;

        transform.position = new Vector3(x, 25f+y, z);
        
    }
}
