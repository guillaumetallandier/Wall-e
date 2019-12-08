using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : Action
{
    override public void execute(Personne p, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("tuer", "", gm.name);
        gm.GetComponent<Personne>().die();
    }

    public override string getType()
    {
        return "tuer";
    }
}
