using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraper : Action
{
    override public void execute(Personne p, Personne pAgit)
    {
        Debug.Log("Robot : Attrape " + p.name);
    }

    public override string getType()
    {
        return "attrape";
    }
}

