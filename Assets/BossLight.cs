using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLight : MonoBehaviour
{
    bool active;
    Light l;

    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            l.intensity = Random.Range(0, 10);
            l.color = Color.red;


        }
    }

    public void ActivateLight()
    {

        active = true;
    }
}
