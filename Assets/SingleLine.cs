using UnityEngine;
using System.Collections;

public class SingleLine : MonoBehaviour
{

    public GameObject circlePointPrefab;
    public GameObject currentLineRenderer;
    public GameObject lineRendererPrefab;
    public Material drawingMaterial;
    private Vector3 previousPosition, currentPosition;
    private bool clickStarted;
    private int numberOfPoints;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (currentLineRenderer == null)
        { 
            currentLineRenderer = (GameObject)Instantiate(lineRendererPrefab);

        }
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        currentPosition.z = -5.0f;
        if (Input.GetMouseButtonDown(0))
        {
          
            InstatiateCirclePoint(currentPosition, currentLineRenderer.transform);
            clickStarted = true;
        }else if (clickStarted)
        {
            TouchSpaceHandle(currentPosition, currentLineRenderer);
        }
        if (Input.GetMouseButtonUp(0))
        {
            clickStarted = false;
        }

    }

    private void TouchSpaceHandle(Vector3 pos, GameObject currentLineRendererGO)
    {
        LineRenderer currentLineRenderer = currentLineRendererGO.GetComponent<LineRenderer>();
        numberOfPoints++;
        currentLineRenderer.SetVertexCount(numberOfPoints);
        currentPosition = pos;
        currentLineRenderer.SetPosition(numberOfPoints-1,currentPosition);
    }

    private void InstatiateCirclePoint(Vector3 pos, Transform parent)
    {
        GameObject currentCircle = (GameObject)Instantiate(circlePointPrefab);
        currentCircle.transform.parent = parent;
        currentCircle.GetComponent<Renderer>().material = drawingMaterial;
        currentCircle.transform.position = pos;
    }
}

