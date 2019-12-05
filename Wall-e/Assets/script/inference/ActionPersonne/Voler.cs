using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Voler : Action {

	override public void execute(Personne p, GameObject gm)
    {
       string json;
        
        StreamReader readervict = new StreamReader("texte.json",Encoding.UTF8); 
        json = readervict.ReadToEnd();
        var result = JsonConvert.DeserializeObject < Dictionary < string,string>>(json);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte(gm.GetComponent<Personne>().Name + result["volerDebut"] + p.Name);
        
        gm.GetComponent<Observable>().notifyObservers(this.getType(), gm.gameObject);
        
    }

    public override string getType()
    {
        return "voler";
    }

}
