using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreparerNourriture : Action
{
    override public void execute(Personne p, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("preparerNourriture", p.name, "");
    }

    public override string getType()
    {
        return "preparerNourriture";
    }
}