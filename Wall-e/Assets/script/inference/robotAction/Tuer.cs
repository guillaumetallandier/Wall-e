using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : Action
{
    override public void execute(GameObject gop, GameObject gm)
    {
        string actionPers=gm.GetComponent<Personne>().getAction().getType();
        Debug.Log(actionPers);
        if(actionPers== "Nucleaire")
        {
            string actionRob = gop.GetComponent<Acteur>().action.ToString();
            Debug.Log(actionRob);
            if (actionRob == "rien")
            {
                GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("NucR", gm.name, "");
                //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
            }
            else
            {
                GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("NucF", gm.name, gm.name);
                GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
                //gm.GetComponent<Personne>().die();
            }


        }
        //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
        //gm.GetComponent<Personne>().die();
    }

    public override string getType()
    {
        return "tuer";
    }
}
