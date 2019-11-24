using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voler : Action {

	override public void execute(Personne p, Personne pAgit)
    {
        Debug.Log(pAgit.Name + " vole : " + p.Name);
        pAgit.notifyObservers(this.getType(), pAgit.gameObject);
        
    }

    public override string getType()
    {
        return "voler";
    }

}
