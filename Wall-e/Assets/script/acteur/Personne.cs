using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Personne : Observable
{
    public string name { get; set; }

    private GameObject go;
    public string type { get; set; }
    public Action action { get; set; }
    private NavMeshAgent nav;

    public Personne(string name, GameObject go, string type)
    {
        this.name = name;
        this.go = go;
        this.type = type;
        this.nav = go.GetComponent<NavMeshAgent>();
    }

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

    public void execute(Personne p)
    {
        action.execute(p, this);
        notifyObservers(action.getType(), this);
    }

    public GameObject getGo()
    {
        return this.go;
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
