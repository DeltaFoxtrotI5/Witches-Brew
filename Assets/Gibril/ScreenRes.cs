using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1024, 768, Screen.fullScreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
