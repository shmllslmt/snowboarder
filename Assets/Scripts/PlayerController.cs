using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    SurfaceEffector2D surfaceEffector;
    [SerializeField] float torqueAmount = 10.0f;
    [SerializeField] float baseSpeed = 15f;
    [SerializeField] float boostSpeed = 50f;
    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            BoostPlayer();
        }
    }

    public void DisablePlayer()
    { 
        canMove = false;
    }

    void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = boostSpeed;
        }
        else
        {
            surfaceEffector.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-torqueAmount);
        }
    }
}
