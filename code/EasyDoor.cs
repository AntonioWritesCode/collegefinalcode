using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyDoor : MonoBehaviour
{
    public GameObject door;
    public bool IsOpened = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(IsOpened)
        {
          door.transform.position = new Vector3(7.4f, 3.11f, 2.72f);
        }

        else
        {
           door.transform.position = new Vector3(7.4f, 1.3f, 2.72f);
        }
        
    }

}
