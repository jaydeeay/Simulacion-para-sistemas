using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVelocity : MonoBehaviour
{
    private MyVector position;
    private MyVector velocity;
    private MyVector displacement;
    [SerializeField] MyVector acceleration;
    void Start()
    {
        position = transform.position;
        //Time.maximumDeltaTime = 1f / 60f;
    }

    private void FixedUpdate()
    {
        Move();
    }
    void Update()
    {
        // Debug vector
        position.Draw(Color.green);
        displacement.Draw(position, Color.yellow);
        velocity.Draw(position, Color.red);
        //position.Draw(Color.red);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Hacer que cuando se presione el espacio cambiar la direccion
        }

    }

    public void Move()
    {
        // Calcule displacemente position
        // Integrate by Euler vector
        velocity = velocity + acceleration * Time.fixedDeltaTime;
        displacement = velocity * Time.fixedDeltaTime;
        position += displacement; 

        // Check Bounds

        if (Mathf.Abs(position.x) > 5)
        {
            position.x = Mathf.Sign(position.x) * 5;
            velocity.x = -velocity.x;
        }
        
        if (Mathf.Abs(position.y) > 5)
        {
            position.y = Mathf.Sign(position.y) * 5;
            velocity.y = -velocity.y;
        }

        // Update unity object
        transform.position = position;
    }
}
