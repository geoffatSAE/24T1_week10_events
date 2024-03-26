using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonSc : MonoBehaviour
{
    public UnityEvent OnTriggered;

    //public GameObject door, boss, bossLight;

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
        OnTriggered?.Invoke();

        /*
        //open the door
        door.SetActive(false);

        //set a boss active
        BossScript b = boss.GetComponent<BossScript>();
        b.ActivateBoss();


        //dramatic lights
        BossLight bl = bossLight.GetComponent<BossLight>();
        bl.ActivateLight();
        */
    }
}
