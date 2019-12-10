using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ecouter : Action
{
    private List<Regle> rulesList;

    override public void execute(GameObject go, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("hEcoute", "", "");
    }

    public override string getType()
    {   
        return "ecoute";
    }
}
