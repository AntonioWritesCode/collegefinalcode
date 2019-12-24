using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPick : MonoBehaviour
{
    public GameObject HealthPack;
    public float healthPack;
    public float myHealth = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RepairHealth(float amount)
    {
        myHealth += amount;
        if(myHealth >= 10f)
        {
            Pick(); 
        }

        void Pick()
        {
           
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<playerHealth>().myHealth = col.gameObject.GetComponent<playerHealth>().myHealth +90;
            Destroy(gameObject);
        }
    }
}
