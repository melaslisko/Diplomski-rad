using UnityEngine;
using System.Collections;

public class EnableLetter : MonoBehaviour
{
    public GameObject Letter;

    private void Start()
    {
        Letter.SetActive(true);
    }

    public void OnMouseDown()
    {
        Letter.SetActive(false);
    }
    
}
