using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenFacebookHyperlink()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Application.ExternalEval("window.open(\"https://www.facebook.com/ictaac\")");
            return;
        }
        else
        {

            Application.OpenURL("https://www.facebook.com/ictaac");
            return;
        }

    }
    public void OpenICTAACHyperlink()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Application.ExternalEval("window.open(\"http://www.ict-aac.hr/index.php/hr\")");
            return;
        }
        else
        {
            Application.OpenURL("http://www.ict-aac.hr/index.php/hr/");
            return;
        }
    }
    public void OpenHRPrivacyPolicy()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Application.ExternalEval("window.open(\"http://www.ict-aac.hr/index.php/hr/politika-privatnosti\")");
            return;
        }
        else
        {
            Application.OpenURL("http://www.ict-aac.hr/index.php/hr/politika-privatnosti");
            return;
        }
    }
    public void OpenENPrivacyPolicy()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Application.ExternalEval("window.open(\"http://www.ict-aac.hr/index.php/en/privacy-policy\")");
            return;
        }
        else
        {
            Application.OpenURL("http://www.ict-aac.hr/index.php/en/privacy-policy");
            return;
        }
    }
}
