using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonController : MonoBehaviour
{
    public GameObject PFB_Characters_Lady;
    public VirtualButtonBehaviour vb;
    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        PFB_Characters_Lady.SetActive(true);

    }

    void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        PFB_Characters_Lady.SetActive(false);
    }
}
