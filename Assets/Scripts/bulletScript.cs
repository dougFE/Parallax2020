using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
	private Vector3 normalizeDirection;
	public Transform Target;

    	public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    	normalizeDirection = (Target.position - transform.position).normalized;
    	
    }

    // Update is called once per frame
    void Update()
    {
        

       transform.position += normalizeDirection * speed * Time.deltaTime;
       
       
    }
}
