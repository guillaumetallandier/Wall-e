using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevenirAutorite : Action
{
    override public void execute(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("rPrevenir", "","");
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("rPrevenu", "", "");
    }

    public override string getType()
    {
        return "prevenirAutorite";
    }
}
