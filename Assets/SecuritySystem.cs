using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuritySystem : MonoBehaviour
{
    //Define the delegate instance
    public delegate void SecurityAction();
    //Define the event to subscribe to (and from)
    public static event SecurityAction OnSecurity;


    private void OnTriggerEnter(Collider other)
    {
        //call the event when the parameters are met, in this case something enters the trigger
        if (OnSecurity != null) OnSecurity();
        //note the if statement for null reference check

    }
}
