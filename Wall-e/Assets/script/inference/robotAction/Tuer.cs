using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : Action
{
    override public void execute(GameObject gop, GameObject gm)
    {

        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("tuer", gop.GetComponent<Robot>().name, gm.GetComponent<Personne>().name);
        gm.GetComponent<Personne>().die();
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();

        string actionPers=gm.GetComponent<Personne>().getAction().getType();
        Debug.Log(actionPers);
        if(actionPers== "FinMonde")
        {
            string actionRob = gop.GetComponent<Acteur>().action.getType();
            Debug.Log(actionRob);
            if (actionRob == "rien")
            {
                GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("NucR", gm.GetComponent<Personne>().name, "");
                GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
            }
            else
            {
                GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("NucF", gm.GetComponent<Personne>().name, gm.GetComponent<Personne>().name);
                GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
                gm.GetComponent<Personne>().die();
            }

           // gm.GetComponent<Personne>().die();
        }
        //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();
       

    }

    public override string getType()
    {
        return "tuer";
    }
}
