using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityLight : MonoBehaviour
{

    Light l;


    private void OnEnable()
    {
        SecuritySystem.OnSecurity += SecurityLightOn;
    }

    private void OnDisable()
    {
        SecuritySystem.OnSecurity -= SecurityLightOn;
    }

    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SecurityLightOn()
    {

        l.intensity = 10;
        l.color = Color.red;
    }
}
