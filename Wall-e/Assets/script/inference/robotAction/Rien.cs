using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rien : Action {

    override public void execute(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
    }
    public override string getType()
    {
        return "rien";
    }
}
