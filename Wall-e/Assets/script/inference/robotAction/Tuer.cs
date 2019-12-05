using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : Action
{
    override public void execute(Personne p, GameObject gm)
    {
        Debug.Log("Robot : tue" + gm.name);
        gm.GetComponent<Personne>().die();
    }

    public override string getType()
    {
        return "tuer";
    }
}
