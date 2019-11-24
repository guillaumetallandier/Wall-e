using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frapper : Action
{
    override public void execute(Personne p, Personne pAgit)
    {
        Debug.Log("Robot : frappe" + p.Name);
        p.getHit();
    }

    public override string getType()
    {
        return "frappe";
    }
}
