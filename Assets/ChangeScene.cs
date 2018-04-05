using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
    
	public void ChangeToScene (string sceneToChangeTo) {
		if (sceneToChangeTo == "MultipleLines")
			Application.Quit();
			
        Application.LoadLevel(sceneToChangeTo);
	}
}
