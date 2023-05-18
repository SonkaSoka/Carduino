using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    //public properties

    public float timeAccel;


    //Private properties
    private float xAxis; 
    private  Rigidbody _rb;
    public int force;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        InvokeRepeating("Acceleration", timeAccel, timeAccel);

    }

    public void Update()
    {
        xAxis = Input.GetAxis("Horizontal");

    }

    public void FixedUpdate()
    {
        Vector3 forceVector = new Vector3(xAxis * force, 0f, 0f);
        _rb.AddForce(forceVector);

    }
    
    public void Acceleration() 
    {

        force++;

            
    }
}
