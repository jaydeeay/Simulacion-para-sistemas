using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionGraoh : MonoBehaviour
{
    [SerializeField] private GameObject pointPrefab;
    [SerializeField] int totalSamplePoints = 20;
    [SerializeField] float separation = 0.6f;
    [SerializeField] float amplitude = 0.5f;

    private List<GameObject> newPoints = new List<GameObject>();

    private void Start()
    {
        for(int i=0; i < totalSamplePoints; i++)
        {
            var newPoint = Instantiate(pointPrefab, transform);
            newPoints.Add(newPoint);
            
        }
    }
    private void Update()
    {
        for(int i =0; i<totalSamplePoints; i++)
        {
            var newPoint = newPoints[i];
            float x = i * separation;
            float y = amplitude * Mathf.Sin(i + Time.time);
            newPoint.transform.localPosition = new Vector3(x, y);
        }
    }
}
