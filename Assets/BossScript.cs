using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{

    bool active;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {

            Rigidbody r = GetComponent<Rigidbody>();
            r.AddForce(new Vector3(
                Random.RandomRange(-10, 10), 
                Random.RandomRange(0, 20), 
                Random.RandomRange(-10, 10)));
        }
    }

    public void ActivateBoss()
    {
        active = true;
    }

}
