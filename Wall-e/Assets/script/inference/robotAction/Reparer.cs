using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reparer : Action
{
    override public void execute(Personne p, GameObject gm)
    {
        Debug.Log("Robot : réparer la voiture");
     
    }

    public override string getType()
    {
        return "réparation";
    }
}
