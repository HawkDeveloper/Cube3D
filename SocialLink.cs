using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialLink : MonoBehaviour
{
    public void Instagram()
    {
        Application.OpenURL("https://instagram.com/kostyashutko?igshid=YmMyMTA2M2Y=");
    }

    public void Linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/kostiantyn-shutko-371410235/");
    }

    public void YouTube()
    {
        Application.OpenURL("https://www.youtube.com/@hawkdeveloper4768");
    }
}
