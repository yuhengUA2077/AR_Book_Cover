using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(onButtonPressed);
        Vb.RegisterOnButtonReleased(onButtonReleased);
        text1.SetActive(true);
        text2.SetActive(false);
    }

    public void onButtonPressed(VirtualButtonBehaviour Vb)
    {
        text1.SetActive(false);
        text2.SetActive(true);
    }

    public void onButtonReleased(VirtualButtonBehaviour Vb)
    {
        text1.SetActive(true);
        text2.SetActive(false);
    }
}
