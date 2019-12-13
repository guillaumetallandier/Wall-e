using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class voiture : Robot   

public class Voiture : Robot 

{
    public string name { get; set; }

    private GameObject go;
  
    public Action action { get; set; }
    private NavMeshAgent nav;
    private List<Regle> rulesList;
    private List<EnumPeople> peopleList;


    /*public voiture(string name, GameObject go)

     public Voiture(string name, GameObject go, int vie,Item item)
     {
         this.name = name;
         this.go = go;
         this.nav = go.GetComponent<NavMeshAgent>();
     }*/
    public Voiture(string name, GameObject gm, int vie, Item item) : base(name, gm, 3, null)
    {
        this.nav = gameObject.GetComponent<NavMeshAgent>();
    }


    public void Setup(string name)
    {
        base.name = name;
        this.nav = gameObject.GetComponent<NavMeshAgent>();
        this.score = 0;
    }


    public void Setup(string name, List<Regle> lr, List<EnumPeople> le)
    {
        base.name = name;
        this.nav = gameObject.GetComponent<NavMeshAgent>();
        this.score = 0;
        this.peopleList = le;
        this.rulesList = lr;
    }

    public void getstop()
    {
        Debug.Log("à l'arret");
    }


    public void broke()
    {
        Debug.Log("je suis cassé");
    }

   

    public GameObject getGo()
    {
        return this.go;
    }

    public void reparation()
    {
        Debug.Log("je me fait réparer");
    }

    public Transform getDest()
    {
        return this.go.GetComponent<DestUpdate>().getDest();
    }

    public void setDest(Transform dest)
    {
        this.go.GetComponent<DestUpdate>().setDest(dest);
    }
}
