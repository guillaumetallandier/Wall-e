using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class AppelerSecours : Action {

	override public void execute(GameObject go, GameObject gm)
    {
        if (go.GetComponent<Personne>().type == EnumPeople.enfant)
        {
            Debug.Log(go.GetComponent<Personne>().name);
            GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("aDemandeAideFille", "", go.GetComponent<Personne>().name);
        }
        else
        {
            Debug.Log(go.GetComponent<Personne>().name);
            GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("aDemandeAidePere", "", go.GetComponent<Personne>().name);
        }
        
        go.GetComponent<Observable>().notifyObservers(this.getType(),go);

    }

    public override string getType()
    {
        return "accidentVoiture";
    }

}
