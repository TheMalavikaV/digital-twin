using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOnOff : MonoBehaviour
{
    public Light mylight;
    // Start is called before the first frame update
    void Start()
    {
       // mylight = GetComponent<Light>();
    }
    // Update is called once per frame
    /*void Update()
    //public void ToggleLight() 
    {
        // mylight.enabled = !mylight.enabled;
        if (Input.GetKeyUp(KeyCode.L))
        {
            mylight.enabled = !mylight.enabled;
        }
    }*/
    void OnMouseDown()
    {
        // Toggle the state of the light
        Debug.Log("Mouse click detected on: " + gameObject.name);
        mylight.enabled = !mylight.enabled;
    }
}
