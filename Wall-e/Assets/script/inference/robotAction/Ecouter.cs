using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ecouter : Action
{
    private List<Regle> rulesList;

    override public void execute(Personne p, Personne pAgit)
    {   
        Debug.Log("Robot : ecoute " + p.Name);
    }

    public override string getType()
    {   
        return "ecoute";
    }
}
