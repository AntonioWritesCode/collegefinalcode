using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPick : MonoBehaviour
{
    public GameObject ArmorPack;
    public float armorPack;
    public float myArmor = 85f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void BuildArmor(float amount)
    {
        myArmor += amount;
        if (myArmor >= 10f)
        {
            Pick();
        }

        void Pick()
        {

        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<playerHealth>().myArmor = col.gameObject.GetComponent<playerHealth>().myArmor + 90;
            Destroy(gameObject);
        }
    }
}
