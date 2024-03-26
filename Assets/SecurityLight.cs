using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityLight : MonoBehaviour
{
    Light l;
    private void OnEnable()
    {
        //Subjectibe to the event
        SecuritySystem.OnSecurity += SecurityLightOn;
    }
    private void OnDisable()
    {
        //and unsubscribe when no longer around
        SecuritySystem.OnSecurity -= SecurityLightOn;
    }
    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Light>();

    }
    
    void SecurityLightOn() //Define the function to call on event call
    {

        l.intensity = 10;
        l.color = Color.red;
    }
}
