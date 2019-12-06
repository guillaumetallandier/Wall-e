using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ecouter : Action
{
    private List<Regle> rulesList;

    override public void execute(Personne p, GameObject gm)
    {   
        Debug.Log("Robot : ecoute " + p.name);
    }

    public override string getType()
    {   
        return "ecoute";
    }
}
