using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicide : Action
{
    override public void execute(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("autodestruction", "", "");
    }

    public override string getType()
    {
        return "suicide";
    }
}
