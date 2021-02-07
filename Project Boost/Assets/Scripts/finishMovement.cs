using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishMovement : MonoBehaviour
{

    [SerializeField] float sure = 5F;
    [SerializeField] float dalga = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;  
        float z = Mathf.Sin(Time.time * sure) * dalga;

        transform.position = new Vector3(x, y, z-7);
        
    }
}
