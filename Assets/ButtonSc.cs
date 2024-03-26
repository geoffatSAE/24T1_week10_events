using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add the Unity Events features for this script
using UnityEngine.Events;

public class ButtonSc : MonoBehaviour
{
    //declare a UnityEvent with name OnTriggered (remember to use On in the naming of your events)
    public UnityEvent OnTriggered;

    private void OnTriggerEnter(Collider other)
    {
        //call the event when the parameters are met, in this case something enters the trigger
        OnTriggered?.Invoke();
        //note the ? for null reference check

    }
}
