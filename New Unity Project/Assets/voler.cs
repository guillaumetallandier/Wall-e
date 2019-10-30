using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class voler : MonoBehaviour {

    Transform player;
    Transform escap;
    NavMeshAgent nav;
    Collider m;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        pos = this.transform.position;
        nav.SetDestination(player.position);
        m=gameObject.AddComponent<BoxCollider>();
        m.isTrigger = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entrer");
    }

    private float stayCount = 0.0f;
    private void OnTriggerStay(Collider other)
    {

         
                Debug.Log("staying");
               
          


    }
    void OncollisionExit(Collider collision)
    {
        Debug.Log("partir");    
    }
    public void Partir()
    {
        nav.isStopped = false;
        escap = GameObject.FindGameObjectWithTag("escap").transform;
        nav.SetDestination(escap.position);
    }
}
