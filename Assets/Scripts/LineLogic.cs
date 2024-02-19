using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineLogic : MonoBehaviour
{
    LineRenderer lineRenderer;

    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, start.position);
        lineRenderer.SetPosition(1, end.position);
    }
}
