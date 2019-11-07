using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestUpdate : MonoBehaviour {

    // Update is called once per frame
    private Transform dest;
    private NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }
	void Update () {
        if(dest != null)
        {
            nav.SetDestination(dest.position);
        }
        
        
	}
    public Transform getDest()
    {
        return this.dest;
    }

    public void setDest(Transform dest)
    {
        this.dest = dest;
    }

    public NavMeshAgent getNav()
    {
        return this.nav;
    }
}
