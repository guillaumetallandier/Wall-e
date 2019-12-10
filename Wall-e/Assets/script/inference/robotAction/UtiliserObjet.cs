using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtiliserObjet : Action
{
    override public void execute(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("utiliser", "", "");
    }

    public override string getType()
    {
        return "utiliserObjet";
    }
}
