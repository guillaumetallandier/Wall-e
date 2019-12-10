    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rouler : Action
{

    override public void execute(GameObject go, GameObject gm)
    {
        GameObject personneGo = go.GetComponent<Voiture>().getGo();
      
        gm.GetComponent<Voiture>().setDest(personneGo.transform);

    }

    public override string getType()
    {
        return "Roule";
    }

}
