using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVelocity : MonoBehaviour
{
    [SerializeField]private MyVector position;
    [SerializeField] private MyVector velocity;
    private MyVector _displacement;
    void Start()
    {
        position = transform.position;
        // Time.maximumDeltaTime = 1f / 60f;
    }
    void Update()
    {
        //Debug vector
        position.Draw(Color.green);
        _displacement.Draw(position, Color.yellow);
        //position.Draw(Color.red);
        Move();
    }

    public void Move()
    {
        _displacement = velocity * Time.deltaTime; 
        position += _displacement;
//Check Bounds

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

        transform.position = position;
    }
}
