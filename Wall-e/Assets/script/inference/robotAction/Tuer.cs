using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : Action
{
    override public void execute(GameObject gop, GameObject gm)
    {
        string action=gm.GetComponent<Personne>().getAction().getType();

        if(action== "Nucleaire")
        {
            GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("tuer", "","");
        }
        //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("tuer", "", gm.name);
        gm.GetComponent<Personne>().die();
    }

    public override string getType()
    {
        return "tuer";
    }
}
