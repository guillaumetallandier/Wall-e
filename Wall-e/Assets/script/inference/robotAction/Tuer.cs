using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : Action
{
    override public void execute(Personne p, Personne pAgit)
    {
        Debug.Log("Robot : tue" + p.Name);
        p.die();
    }

    public override string getType()
    {
        return "tuer";
    }
}
