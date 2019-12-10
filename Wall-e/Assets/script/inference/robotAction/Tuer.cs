using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : Action
{
    override public void execute(GameObject gop, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("tuer", "", gm.name);
        GameObject.FindGameObjectWithTag("robot").GetComponent<Robot>().nePasTuerDil();
        gm.GetComponent<Personne>().die();
    }

    public override string getType()
    {
        return "tuer";
    }
}
