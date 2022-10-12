using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    private float maxDistance;
    private Vector3 startPos;

    public void Init(float distance,float velocity)
    {
        maxDistance = distance;
        startPos=transform.position;
        GetComponent<Rigidbody>().velocity = Vector3.forward*velocity;
    }


    void FixedUpdate()
    {
        if ((startPos-transform.position).magnitude>=maxDistance)
        {
            Destroy(gameObject);
        }
        
    }
}