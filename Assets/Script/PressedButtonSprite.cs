using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PressedButtonSprite : MonoBehaviour
{
    public GameObject activeModal;
    private Sprite sprst;
    public GameObject button;
    private PressedButtonSprite spriteState;
    private Sprite image;

    private void Start()
    {
        //button = gameObject.GetComponent<Button>();
        image = button.GetComponent<Sprite>();
        spriteState = button.GetComponent<PressedButtonSprite>();
        //sprst = spriteState.GetComponent<Sprite>();
    }

    // Update is called once per frame
    void Update()
    {  
        if (activeModal.active)
        {
            image = button.GetComponent<SpriteState>().highlightedSprite;
        }
    }
}
