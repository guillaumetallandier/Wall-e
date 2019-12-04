using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voler : Action {

	override public void execute(Personne p, GameObject gm)    {
        Debug.Log(gm.name + " vole : " + p.name);
        gm.GetComponent<Observable>().notifyObservers(this.getType(), gm.gameObject);
        
    }

    public override string getType()
    {
        return "voler";
    }

}
