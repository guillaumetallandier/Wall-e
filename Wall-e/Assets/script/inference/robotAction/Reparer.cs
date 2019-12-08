using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reparer : Action
{
    override public void execute(Personne p, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("reparer", p.name, "");

    }

    public override string getType()
    {
        return "réparation";
    }
}
