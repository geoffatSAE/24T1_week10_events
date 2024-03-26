using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuritySystem : MonoBehaviour
{

    public delegate void SecurityAction();
    public static event SecurityAction OnSecurity;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(OnSecurity != null) OnSecurity();


    }
}
