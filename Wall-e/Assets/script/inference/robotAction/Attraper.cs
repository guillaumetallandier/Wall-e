using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class Attraper : Action
{

    override public void execute(Personne p, GameObject gm)
    {
        Debug.Log("Robot : Attrape " + gm.name);
        string json;
        StreamReader readervict = new StreamReader("texte.json", Encoding.UTF8);
        json = readervict.ReadToEnd();
        var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte(result["voleurAttraper"] + gm.GetComponent<Personne>().name);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
    }

    public override string getType()
    {
        return "attrape";
    }

}

