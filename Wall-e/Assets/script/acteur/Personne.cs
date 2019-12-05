using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Personne : Acteur
{
  
    private NavMeshAgent nav;
    private GameObject target;
<<<<<<< HEAD

    private Item inventory;

    private Robot robot;

    public Personne(string name, string type)
=======
    public Personne(string name,GameObject gm,int vie,Item item) : base(name,gm,3,item)
>>>>>>> d8ea07e29c7e8989b3107383b07f871f999015f9
    {
        
        this.nav = gameObject.GetComponent<NavMeshAgent>();
        this.inventory = null;
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

    public Item getItem()
    {
        return inventory;
    }

    public void setItem(Item item)
    {
        inventory = item;
    }

    public void setRobot(Robot bidule) {
        robot = bidule;
    }

    public void presenteInventaire()
    {
        if(inventory == null)
        {
            Debug.Log(this.name + " : Mon inventaire est vide");
        }
        else
        {
            Debug.Log(this.name + " : Je possède : " + inventory.getType());
        }
    }

    public void estVoler()
    {
        Debug.Log("Au voleur !! A l'assassin !!! AU MEURTRIER !!!!!!");
        this.ordonne("attraper");
    }

    public void ordonne(string ordre)
    {
        Debug.Log(ordre);
        robot.recevoirOrdre(ordre,this.Name);
    }
}
