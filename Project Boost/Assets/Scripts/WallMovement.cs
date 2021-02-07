using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 m_from = new Vector3(0.0F, 0.0F, -25.0F);
    [SerializeField] protected Vector3 m_to = new Vector3(0.0F, 0.0F, 25.0F);
    [SerializeField] protected float m_frequency = 0.4F; // should be between 0-1

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion from = Quaternion.Euler(this.m_from);
        Quaternion to = Quaternion.Euler(this.m_to);
 
        float lerp = 0.5F * (1.0F + Mathf.Sin(Mathf.PI * Time.realtimeSinceStartup * this.m_frequency));
        this.transform.localRotation = Quaternion.Lerp(from, to, lerp);
    }
}
