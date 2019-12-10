using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frapper : Action
{
    override public void execute(GameObject go, GameObject gm)
    {
        Debug.Log("Robot : frappe" + gm.name);
        gm.GetComponent<Personne>().getHit();
    }

    public override string getType()
    {
        return "frappe";
    }
}
