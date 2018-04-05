using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Line Renderer Attributes Script
public class LineRendererAttributes : MonoBehaviour
{
    private int numberOfPoints;//the number of points in the line
    private List<Vector3> points;//the points of the line
    public Material material;//the material of the line
    public Color[] colors;//the colors set used to select a random color for the line

    void Start()
    {
        //Create a new material if the current material is null
        GetComponent<LineRenderer>().material = material;//set the line material
        if (material == null)
        {
            material = new Material(Shader.Find("Sprite/Default"));
            material.color = Color.black;
        }

        //initiate the list of points
        points = new List<Vector3>();
    }

    //Set a random color
    public void SetRandomColor()
    {
        Color[] colors = new Color[10];
        colors[1] = new Color(0.886f, 0.31f, 0.31f, 1f);
        colors[0] = new Color(0.914f, 0.243f, 0.243f, 1f);
        colors[2] = new Color(0.655f, 0.388f, 0.635f, 1f);
        colors[3] = new Color(0.31f, 0.337f, 0.898f, 1f);
        colors[4] = new Color(0.914f, 0.549f, 0.314f, 1f);
        colors[5] = new Color(0.439f, 0.965f, 0.463f, 1f);
        colors[6] = new Color(0.992f, 0.635f, 0.91f, 1f);
        colors[7] = new Color(0.733f, 0.98f, 1f, 1f);
        colors[8] = new Color(0.804f, 1f, 0.733f, 1f);
        colors[9] = new Color(0.702f, 0.71f, 0.729f, 1f);
        material.color = colors[Random.Range(0, colors.Length)];
        return;
    }

    //Property for the number of points
    public int NumberOfPoints
    {
        get { return this.numberOfPoints; }
        set { this.numberOfPoints = value; }
    }

    //Property for the points list
    public List<Vector3> Points
    {
        get { return this.points; }
        set { this.points = value; }
    }

}
