using System.Collections.Generic;
using UnityEngine;

/*public class TrajectoryRenderer : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int linePoints = 15;                         //количество точек линии
    public float timeBetweenLines = 0.1f;               //временной шаг
        
    //метод отрисовки траектории
    public void DrawTrajectory(Vector3 startPos, Vector3 startVelocity)
    {
        lineRenderer.positionCount = linePoints;
        List<Vector3> points = new List<Vector3>();
        for (int i = 0; i < linePoints; i++)
        {
           //Формула:
           float time = i * 0.1f;
           points[i] = startPos + startVelocity * time + Physics.gravity * time * time / 2f;
           if (points[i].y < 0) {
               lineRenderer.positionCount = i;
               break;
                     
            points.Add(startPos + startVelocity * i);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
    }
}
}
*/