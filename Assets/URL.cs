using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public class AccessWeb : MonoBehaviour
    {
        public void clickPhoto()
        {
            Application.OpenURL("https://www.instagram.com/whizchillhouse/");
        }
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
