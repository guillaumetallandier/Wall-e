﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : Action
{
    override public void execute(GameObject gop, GameObject gm)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("tuer", gop.GetComponent<Robot>().name, gm.GetComponent<Personne>().name);
        gm.GetComponent<Personne>().die();
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
    }

    public override string getType()
    {
        return "tuer";
    }
}
