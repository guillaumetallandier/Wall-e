using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Personne : Acteur
{
  
    private NavMeshAgent nav;
    private GameObject target;
    public EnumPeople type { get; set; }
    private Robot robot;


    public Personne(string name,GameObject gm,int vie,Item item) : base(name,gm,3,item)
    {
        
        this.nav = gameObject.GetComponent<NavMeshAgent>();
    }

    void Start()
    {
       nav = GetComponent<NavMeshAgent>();
    }
    public void SetUp(string name,EnumPeople type)
    {
        base.name = name;
        this.type = type;

    }
    void Update()
    {
       
        if (this.target != null)
        {
            Debug.Log("pers va  :" + target.name.ToString());
            nav.SetDestination(this.target.transform.position);
            Debug.Log(this.name + " est partie vers " + this.target.name);
        }


    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        
        if (collisionInfo.collider.tag == "escape")
        {
            Debug.Log(this.name + " s'est enfui");
        }

        else if (target != null && collisionInfo.collider.name == target.name)

        if (collisionInfo.collider.tag.ToString() != "static")

        {
            
            if (collisionInfo.collider.tag == "escape")
            {

                Debug.Log(this.name + " s'est enfui");
            }
            else if (target != null && action.getType() == "FinMonde")
            {
                Debug.Log("contact bouton ");
                //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
                //Debug.Log("pause");
                setDest(null);
                this.action.execute(target, gameObject);
            }
            else if (target != null && collisionInfo.collider.name == target.name)
            {
                Debug.Log("target != null");
                this.action.execute(target, gameObject);
                this.setDest(GameObject.FindGameObjectWithTag("escape"));
            }
        }
        
        
    }
   

    //fonction
    public void getCatch()
    {
        Debug.Log("tu m'as attraper");
    }

    public void getHit()
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("hFrapper", "", "");
    }

    internal void SetUp(string v, Type type)
    {
        throw new NotImplementedException();
    }

    public void die()
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("hMourir", "", "");
    }

    public void execute(Action a, GameObject p)
    {
        Debug.Log("execute");
        this.action = a;

        if(a.getType() == "voler")
        {
            this.setDest(p.gameObject);
        }
        else
        {
            this.action.execute(p,robot.gameObject);
        }
        

        this.setDest(p);

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
        Debug.Log("setDest");
    }

    public Item getItem()
    {
        return this.item;
    }

    public void setItem(Item item)
    {
        this.item = item;
    }

    public void setRobot(Robot bidule) {
        robot = bidule;
    }

    public Robot getRobot()
    {
        return this.robot;
    }

    public void presenteInventaire()
    {
        if (this.name == null)
        {
            Debug.Log(this.name + " : Mon inventaire est vide");
            //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("hInventaireVide", "", "");

        }
        else
        {
            Debug.Log(this.name + " : Je possède : " + item.name);
            //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("hInventaire", "", item.name);

        }
    }

    public void estVoler()
    {
        Debug.Log("Au voleur !! A l'assassin !!! AU MEURTRIER !!!!!!");
        //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("hEstVoler", "", "");

        this.ordonne("attraper");
    }

    public void ordonne(string ordre)
    {
        Debug.Log(ordre);
        robot.recevoirOrdre(ordre,this.name);
    }

    public void appelerSecours()
    {
        Debug.Log("It is fine !");
        this.ordonne("sauver");
    }


    public void setTarget(GameObject gm)
    {
        this.target = gm;
    }
    public GameObject getTarget()
    {
        return this.target;
    }

}
