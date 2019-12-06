using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtiliserObjet : Action
{
    override public void execute(Personne p, GameObject gm)
    {
        Debug.Log("Robot : utilise objet proche");
    }

    public override string getType()
    {
        return "utiliserObjet";
    }
}
