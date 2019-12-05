using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicide : Action
{
    override public void execute(Personne p, GameObject gm)
    {
        Debug.Log("Robot : autodestruction");
    }

    public override string getType()
    {
        return "suicide";
    }
}
