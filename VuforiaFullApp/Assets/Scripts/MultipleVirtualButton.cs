using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultipleVirtualButton : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;

    public VirtualButtonBehaviour virtualButton1;
    public VirtualButtonBehaviour virtualButton2;

    void Start()
    {
        virtualButton1.RegisterOnButtonPressed(OnButton1Pressed);
        virtualButton1.RegisterOnButtonReleased(OnButton1Released);
        virtualButton2.RegisterOnButtonPressed(OnButton2Pressed);
        virtualButton2.RegisterOnButtonReleased(OnButton2Released);
    }

    public void OnButton1Pressed(VirtualButtonBehaviour vb)
    {
        obj1.SetActive(true);
    }

    public void OnButton1Released(VirtualButtonBehaviour vb)
    {
        obj1.SetActive(false);
    }

    public void OnButton2Pressed(VirtualButtonBehaviour vb)
    {
        obj2.SetActive(true);
    }

    public void OnButton2Released(VirtualButtonBehaviour vb)
    {
        obj2.SetActive(false);
    }
}
