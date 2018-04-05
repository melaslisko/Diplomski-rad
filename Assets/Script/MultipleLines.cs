using UnityEngine;
using System.Collections;

public class MultipleLines : MonoBehaviour
{

    public GameObject circlePointPrefab;
    public GameObject currentLineRenderer;
    public GameObject lineRendererPrefab;
    public Material drawingMaterial;
    private Vector3 previousPosition, currentPosition;
    private bool clickStarted;
    private int numberOfPoints;
    private bool setRandomColor;

    void Start()
    {

    }

    void Update()
    {


        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        currentPosition.z = -5.0f;
        if (Input.GetMouseButtonDown(0))
        {
            TouchSpaceHandle();
            clickStarted = true;
        }
        else if (clickStarted)
        {
            TouchSpaceHandle();
        }
        if (Input.GetMouseButtonUp(0))
        {
            clickStarted = false;
            currentLineRenderer = null;
            numberOfPoints = 0;
        }

    }

    private void TouchSpaceHandle()
    {
        if (currentLineRenderer == null)
        {
            currentLineRenderer = Instantiate(lineRendererPrefab) as GameObject;
            GameObject lines = GameObject.Find("Lines");
            currentLineRenderer.transform.parent = lines.transform;
            setRandomColor = true;
        }
        numberOfPoints++;

        Vector3 mousePos = Input.mousePosition;
        Vector3 wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0 - Camera.main.transform.position.z));
        LineRenderer ln = currentLineRenderer.GetComponent<LineRenderer>();

        if(setRandomColor)
        {
            Color[] colors = new Color[6];
            colors[0] = Color.red;
            colors[1] = Color.blue;
            colors[2] = new Color(50,70,250);
            colors[3] = new Color(255,0,255);
            colors[4] = Color.green;
            colors[5] = new Color(255,165,0);

            ln.material.color = colors[Random.Range(0, colors.Length)];
            setRandomColor = false;

        }

        ln.SetVertexCount(numberOfPoints);
        ln.SetPosition(numberOfPoints - 1, wantedPos);
    }

    private void InstatiateCirclePoint(Vector3 pos, Transform parent)
    {
        GameObject currentCircle = (GameObject)Instantiate(circlePointPrefab);
        currentCircle.transform.parent = parent;
        currentCircle.GetComponent<Renderer>() .material = drawingMaterial;
        currentCircle.transform.position = pos;
    }
}

