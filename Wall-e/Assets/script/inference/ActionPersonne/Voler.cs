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

       p.presenteInventaire();
       string json;
        
        StreamReader readervict = new StreamReader("texte.json",Encoding.UTF8); 
        json = readervict.ReadToEnd();
        var result = JsonConvert.DeserializeObject < Dictionary < string,string>>(json);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte(gm.GetComponent<Personne>().name + result["volerDebut"] + p.name);
        
        gm.GetComponent<Observable>().notifyObservers(this.getType(), gm.gameObject);

        gm.GetComponent<Personne>().setItem(p.getItem());
        gm.GetComponent<Personne>().setItem(null);

        p.presenteInventaire(); //inventaire voleur : doit avoir porte-feuille
        p.presenteInventaire(); //inventaire humain: doir etre vide

        gm.GetComponent<Personne>().estVoler();
        
    }

    public override string getType()
    {
        return "voler";
    }

}
