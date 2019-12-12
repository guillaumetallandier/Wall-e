using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuc : Action
{

    public override void execute(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("NucDebut", gm.GetComponent<Personne>().name, "");
        gm.GetComponent<Observable>().notifyObservers(this.getType(), gm.gameObject);

    }
    public override string getType()
    {
        return "Nucleaire";
    }
}
