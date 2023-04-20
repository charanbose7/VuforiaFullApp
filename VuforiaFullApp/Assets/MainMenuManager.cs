using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void singlevirtualbutton()
    {
        SceneManager.LoadScene("SingleVirtualButton");
    }

    public void multiplevirtualbutton()
    {
        SceneManager.LoadScene("MutipleVirtualButton");
    }

    public void marker()
    {
        SceneManager.LoadScene("Marker");
    }

    public void markerlessground()
    {
        SceneManager.LoadScene("MarkerLessGround");
    }

    public void markerlessmidAir()
    {
        SceneManager.LoadScene("MarkerLessMidAir");
    }

    public void cloud()
    {
        SceneManager.LoadScene("CloudReco");
    }
}
