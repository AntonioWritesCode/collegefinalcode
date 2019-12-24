using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockDoor : MonoBehaviour
{
    public GameObject Lockdoor;
    public GameObject Bluesoul;
    public GameObject Redsoul;
    public GameObject Greensoul;
    public GameObject Yellowsoul;
    public bool IsLockOpened = false;
    public bool hasbluesoul = false;
    public bool hasyellowsoul = false;
    public bool hasredsoul = false;
    public bool hasgreensoul = false;
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
        if (!hasbluesoul && col.gameObject.tag == "onesoul")
        {
            hasbluesoul = true;
            print("Blue soul collected!");
            Destroy(Bluesoul);
        }

        if (!hasredsoul && col.gameObject.tag == "twosoul")
        {
            hasredsoul = true;
            print("red soul collected!");
            Destroy(Redsoul);
        }

        if (!hasgreensoul && col.gameObject.tag == "threesoul")
        {
            hasgreensoul = true;
            print("Green soul collected!");
            Destroy(Greensoul);
        }

        if (!hasyellowsoul && col.gameObject.tag == "foursoul")
        {
            hasyellowsoul = true;
            print("Yellow soul collected!");
            Destroy(Yellowsoul);
        }

        if (hasbluesoul && hasgreensoul && hasredsoul && hasyellowsoul)
        {
            IsLockOpened = true;
            Lockdoor.transform.position = new Vector3(8.5f, 3.62f, -10.99f);
        }
    }

}
