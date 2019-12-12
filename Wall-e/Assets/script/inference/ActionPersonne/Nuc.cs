using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuc : Action
{

    public override void execute(GameObject go, GameObject gm)
    {
        //gm est la personne 


        pause(go, gm);
        gm.GetComponent<Observable>().notifyObservers(this.getType(), gm.gameObject);
        
    }

    public override string getType()
    {
        return "FinMonde";
    }

    public void pause(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("NucDebut", gm.GetComponent<Personne>().name, "");
    }
    public void reprendre()
    {
        Time.timeScale = 1;
        Debug.Log("reprise");
    }
}
