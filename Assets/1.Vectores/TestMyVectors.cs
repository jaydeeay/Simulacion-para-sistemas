using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMyVectors : MonoBehaviour
{
    [SerializeField]
    private MyVector myObj;
    [SerializeField]
    private MyVector myObj2;
    [SerializeField]
    private MyVector myObj3;

    [SerializeField, Range(0, 1)] 
    private float scale;
    // Start is called before the first frame update
    void Start()
    {
    }
    
    void Update()
    {
        myObj.Draw(Color.blue);
        myObj2.Draw(Color.yellow);

        myObj3 = (myObj2 - myObj) * scale;
        myObj3.Draw(myObj, Color.magenta);
        
        MyVector myObj4 = MyVector.Lerp(myObj,myObj2, scale);
        
        
        myObj4.Draw(Color.green);
    }
}
