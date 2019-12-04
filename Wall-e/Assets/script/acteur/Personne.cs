using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Personne : Observable
{
    public string Name { get; set; }
    public string Type { get; set; }
    public Action Action { get; set; }
    private NavMeshAgent nav;
    private GameObject target;

    public Personne(string name, string type)
    {
        this.Name = name;
        this.Type = type;
        this.nav = gameObject.GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }
    public void SetUp(string name, string type)
    {
        this.Name = name;
        this.Type = type; 

    }
    void Update()
    {
        if (this.target != null)
        {
            nav.SetDestination(this.target.transform.position);
        }


    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "escape")
        {
            Debug.Log(this.Name + " s'est enfui");
        }

        else if (target != null && collisionInfo.collider.name == target.name)
        {
            Debug.Log("target != null");
            this.Action.execute(target.GetComponent<Personne>(), this);
            this.setDest(GameObject.FindGameObjectWithTag("escape"));
        }
        
    }
   

    //fonction
    public void getCatch()
    {
        Debug.Log("tu m'as attraper");
    }

    public void getHit()
    {
        Debug.Log("Aie !");
    }

    public void die()
    {
        Debug.Log("je meurt");
    }

    public void execute(Action a, Personne p)
    {
        this.Action = a;
        this.setDest(p.gameObject);
    }

    public GameObject getGo()
    {
        return this.gameObject;
    }

    public Transform getDest()
    {
        return this.gameObject.GetComponent<Personne>().getDest();
    }

    public void setDest(GameObject target)
    {
        this.target = target;
    }
}
