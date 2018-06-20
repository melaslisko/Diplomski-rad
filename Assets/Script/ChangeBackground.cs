using UnityEngine;
//using Assets;
using UnityEngine.UI;
using System.Collections;


public class ChangeBackground : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public GameObject CurrentBackground;

    public int index = 0;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = CurrentBackground.GetComponent<Renderer>() as SpriteRenderer;
    }

    public void OnClick()
    {
        if (index == sprites.Length-1)
        {
            index = 0;
        }
        else index++;
        spriteRenderer.sprite = sprites[index];
    }
}