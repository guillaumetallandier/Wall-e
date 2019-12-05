    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rouler : Action
{

    override public void execute(Personne p, GameObject gm)
    {
        GameObject personneGo = p.getGo();
      
        gm.GetComponent<Voiture>().setDest(personneGo.transform);

    }

    public override string getType()
    {
        return "Roule";
    }

}
