using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Voiture : Observable
{
    public string name { get; set; }

    private GameObject go;
  
    public Action action { get; set; }
    private NavMeshAgent nav;

    public Voiture(string name, GameObject go)
    {
        this.name = name;
        this.go = go;
        this.nav = go.GetComponent<NavMeshAgent>();
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
