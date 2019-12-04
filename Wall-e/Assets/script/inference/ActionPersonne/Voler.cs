using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Voler : Action {

	override public void execute(Personne p, Personne pAgit)
    {
       string json;
        
        StreamReader readervict = new StreamReader("texte.json",Encoding.UTF8); 
        json = readervict.ReadToEnd();
        var result = JsonConvert.DeserializeObject < Dictionary < string,string>>(json);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte(pAgit.Name + result["volerDebut"] + p.Name);
        
        pAgit.notifyObservers(this.getType(), pAgit.gameObject);
        
    }

    public override string getType()
    {
        return "voler";
    }

}
