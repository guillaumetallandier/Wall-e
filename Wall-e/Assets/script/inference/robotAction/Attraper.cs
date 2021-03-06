﻿using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class Attraper : Action
{

    override public void execute(GameObject go, GameObject gm)
    {        
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("voleurAttraper",gm.GetComponent<Personne>().name, go.GetComponent<Personne>().name);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
    }

    public override string getType()
    {
        return "attrape";
    }

}

