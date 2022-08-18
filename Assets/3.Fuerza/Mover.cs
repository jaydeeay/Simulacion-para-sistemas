using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private MyVector position;
    [SerializeField] private MyVector aceleracion;
    private MyVector Displacement;
    [SerializeField] private MyVector velocity;
    [SerializeField] private int state = 0;
    [SerializeField] private Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Displacement.Draw(position, Color.red);
        position.Draw(position, Color.blue);
        Move();
        velocity.Draw(position, Color.red);

    }
    public void Move()
    {
        // Displacement =velocity*Time.deltaTime;
        Displacement = velocity * Time.deltaTime;
        velocity = velocity + aceleracion * Time.deltaTime;
        position = position + Displacement;

        /*
         if (position.x < -5 || position.x > 5)
         {
             position.x = Mathf.Sign(position.x) * 5;
             velocity.x *= -1;
         }
         if (position.y < -5 || position.y > 5)
         {
             position.y = Mathf.Sign(position.y) * 5;
             velocity.y *= -1;
         }
        */
        transform.position = position;
        
        aceleracion = Target.position - transform.position;
       

    }
}
