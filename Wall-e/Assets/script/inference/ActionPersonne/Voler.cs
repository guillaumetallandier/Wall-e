using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voler : Action {

	override public void execute(Personne p, Personne pAgit)
    {
        GameObject personneGo = p.getGo();
        Debug.Log(pAgit.name + " vole : " + p.name);
        pAgit.setDest(personneGo.transform);
        
    }

    public override string getType()
    {
        return "voler";
    }

}
