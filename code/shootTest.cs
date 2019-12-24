using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootTest : MonoBehaviour
{
    public float damage = 5f;
    public float range = 100f;
    public int speed = 30;

    public Camera fpsCam;

    // Start is called before the first frame update
    void Start()
    {
        shoot();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) 
        {
            Debug.Log(hit.transform.name);

            target target = hit.transform.GetComponent<target>();
            if(transform != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
