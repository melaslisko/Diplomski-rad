using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{

    public void QuitApp()
    {
        Application.Quit();
    }
    public void ChangeToScene(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
