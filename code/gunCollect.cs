using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunCollect : MonoBehaviour
{
    public GameObject myWeapon;
    public GameObject weaponOnGround;

    // Start is called before the first frame update
    void Start()
    {
        myWeapon.SetActive(false);
    }

    void OnTriggerEnter(Collider _collider)
    {
        if(_collider.gameObject.tag == "Player")
        {
            myWeapon.SetActive(true);
            weaponOnGround.SetActive(true);
        }
       
    }

}
