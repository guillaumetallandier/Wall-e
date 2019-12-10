using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreparerNourriture : Action
{
    override public void execute(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("preparerNourriture", go.GetComponent<Personne>().name, "");
    }

    public override string getType()
    {
        return "preparerNourriture";
    }
}