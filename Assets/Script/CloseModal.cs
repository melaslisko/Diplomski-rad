using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseModal : MonoBehaviour
{
    public GameObject modalWindow;

    public void closeModal()
    {
        modalWindow.SetActive(false);
    }

}
