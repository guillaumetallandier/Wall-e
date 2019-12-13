using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerSauver : Action {

    override public void execute(GameObject rob, GameObject pers)
    {
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("asauver", "", pers.name);

        GameObject cible = GameObject.FindGameObjectWithTag("escape");
        
        rob.GetComponent<Robot>().setTarget(cible);
        
        pers.GetComponent<Personne>().setTarget(GameObject.FindGameObjectWithTag("escape"));
       
    }

    public override string getType()
    {
        return "sauve";
    }
}
