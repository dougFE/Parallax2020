using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float movementX;
    private float movementY;
    private Rigidbody2D rb;
    public Vector2 speed = new Vector2(10, 10);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }


    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 walking = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        walking *= Time.deltaTime;

        transform.Translate(walking);

    }
}