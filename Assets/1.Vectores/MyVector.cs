using System.Reflection;
using UnityEngine;

[System.Serializable]
public struct MyVector
{
    public float x;
    public float y;
    public float magnitude => Mathf.Sqrt(x * x + y * y);

    public MyVector normalized
    {
        get
        {
            float distance = magnitude;
            if (distance < 0.0001f)
            {
                return new MyVector(0, 0);
            }
            return new MyVector(x / distance, y / distance);
        }
    }
    public MyVector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public void Draw(Color color)
    {
        Debug.DrawLine(new Vector3(0, 0, 0), new Vector3(x, y, 0), color);

    }
    
    public void Draw(MyVector vector, Color color)
    {
        Debug.DrawLine(new Vector3(vector.x, vector.y, 0), new Vector3(x + vector.x, y + vector.y, 0), color);
 
    }
    
    public static MyVector operator+(MyVector a, MyVector b)
    {
        return new MyVector(
            a.x + b.x,
            a.y + b.y
        );
    }
    
    public void Normalize()
    {
        float magnitudeCache = magnitude;
        if (magnitudeCache < 0.001)
        {
            x = 0;
            y = 0;
        }
        else
        {
            x = x / magnitudeCache;
            y = y / magnitudeCache;
        }
    }
    
    public static implicit operator Vector3(MyVector a)
    {
        return new Vector3(a.x, a.y, 0);
    }

    public static implicit operator MyVector(Vector3 a)
    {
        return new MyVector(a.x, a.y);
    }
    
    public static MyVector operator-(MyVector a, MyVector b)
    {
        return new MyVector(
            a.x - b.x,
            a.y - b.y
        );
    }
    
    public static MyVector operator-(MyVector a)
    {
        return new MyVector(
            -a.x,
            -a.y
        );
    }
    
    public static MyVector operator*(MyVector a, float b)
    {
        return new MyVector(
            a.x * b,
            a.y * b
        );
    }

    public static MyVector operator /(MyVector a, float b)
    {
        return new MyVector(
            a.x / b,
            a.y / b
        );
    }

    public static MyVector Lerp(MyVector a, MyVector b, float c)
    {
        return new MyVector(
            a.x + (b.x - a.x) * c,
            a.y + (b.y - a.y) * c
            );
    }
}

