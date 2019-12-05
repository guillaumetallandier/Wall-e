using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Personne : Acteur
{
  
    private NavMeshAgent nav;
    private GameObject target;
    public Personne(string name,GameObject gm,int vie,Item item) : base(name,gm,3,item)
    {
        
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

            Debug.Log(this.name + " s'est enfui");
        }

        else if (target != null && collisionInfo.collider.name == target.name)
        {
            Debug.Log("target != null");
            this.action.execute(target.GetComponent<Personne>(), gameObject);
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

    public void execute(Action a, GameObject p)
    {
        this.action = a;
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
