using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reparer : Action
{
    override public void execute(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("reparer", go.GetComponent<Personne>().name, "");

    }

    public override string getType()
    {
        return "réparation";
    }
}
