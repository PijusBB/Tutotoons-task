using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linedrawer : MonoBehaviour
{
    public LineRenderer linerenderer;
    private float counter;
    private float dist;
    public Transform origin= null;
    public Transform destination= null;
    public float lineDrawSpeed = 1;
    public int i = 0;
    public static int pointqueue = 0;
    
    void Start()
    {
        pointqueue = 0;
        linerenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if(counter < dist) // Piešimas
        {
            counter += .1f / lineDrawSpeed; // Piešimo greitis 
 
            float x = Mathf.Lerp(0, dist, counter); // 

            Vector3 pointA = origin.position;
            Vector3 pointB = destination.position;

            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA; // Sukuriam vektoriu tinkama kryptimi, padauginam is x, jog gautumem norima ilgį, ir pastatom į origin(linijos pradžią) poziciją

            linerenderer.SetPosition(i, pointAlongLine);

        }
    }
    public void Addpoint(Transform point)
    {
        if (origin == null) // Jei pirmas taškas neturi reikšmės, jy issisaugom ir nieko nedarom
        {
            origin = point;
        }
        else if (origin != null & destination == null ) 
        {
            linerenderer.positionCount++;
            destination = point;
            linerenderer.SetPosition(i++, origin.position);
            linerenderer.startWidth = 1;
            linerenderer.endWidth = 1;
            dist = Vector3.Distance(origin.position, destination.position); // Pradedam piešimą, kai nustatome dist
        }
        else if (origin != null & destination != null)
        {
            linerenderer.positionCount++;
            origin = destination;
            destination = point;
            linerenderer.SetPosition(i++, origin.position);
            linerenderer.startWidth = 1;
            linerenderer.endWidth = 1;
            dist = Vector3.Distance(origin.position, destination.position);
            counter = 0;
        }
        pointqueue++;
    }
}
