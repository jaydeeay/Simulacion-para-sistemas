using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVelocity : MonoBehaviour
{
    [SerializeField]private MyVector position;
    [SerializeField] private MyVector displacement;
    void Start()
    {
        position = transform.position;
    }
    void Update()
    {
        //Debug vector
        position.Draw(Color.green);
        displacement.Draw(position, Color.yellow);
        //position.Draw(Color.red);
    }

    public void Move()
    {
        position += displacement;
//Check Bounds

        if (Mathf.Abs(position.x) > 5)
        {
            position.x = Mathf.Sign(position.x) * 5;
            displacement.x = -displacement.x;
        }
        
        if (Mathf.Abs(position.y) > 5)
        {
            position.y = Mathf.Sign(position.y) * 5;
            displacement.y = -displacement.y;
        }

        transform.position = position;
    }
}
