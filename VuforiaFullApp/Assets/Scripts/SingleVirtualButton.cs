using UnityEngine;
using Vuforia;

public class SingleVirtualButton : MonoBehaviour
{
    public GameObject objectToToggle;
    public VirtualButtonBehaviour virtualButtonBehaviour;

    void Start()
    {
        virtualButtonBehaviour.RegisterOnButtonPressed(OnButtonPressed);
        virtualButtonBehaviour.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        objectToToggle.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        objectToToggle.SetActive(false);
    }
}
