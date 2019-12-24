using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follow : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    public bool Aggro = false;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Aggro)
        {
            transform.LookAt(agent.destination, Vector3.zero);
            if (Vector3.Distance(transform.position, target.position) > .02f)
            {
                agent.destination = target.position;
            }
            else
            {
                agent.destination = this.transform.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            target = other.transform;
            Aggro = true;
        }
    }
}
