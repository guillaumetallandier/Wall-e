using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreparerNourriture : Action
{
    override public void execute(Personne p, Personne pAgit)
    {
        Debug.Log("Robot : prepare plat demandé");
    }

    public override string getType()
    {
        return "preparerNourriture";
    }
}