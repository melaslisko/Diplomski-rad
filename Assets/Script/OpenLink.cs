using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenFacebookHyperlink()
    {

        Application.OpenURL("https://www.facebook.com/ictaac");
        //Application.ExternalEval("window.open(\"https://www.facebook.com/ictaac",\"_blank")");
        //Application.ExternalEval("window.open(\"https://www.facebook.com/ictaac\")");
        return;

    }
    public void OpenICTAACHyperlink()
    {
        Application.OpenURL("http://www.ict-aac.hr/index.php/hr/");
        //Application.ExternalEval("window.open(\"http://www.ict-aac.hr/index.php/hr\")");
        return;
    }
}
