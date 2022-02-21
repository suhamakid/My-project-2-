using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpURL: MonoBehaviour
{
    public string URL = "https://www.instagram.com/whizchillhouse/";

    public void clickPhoto()
        {
            Application.OpenURL(URL);
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
