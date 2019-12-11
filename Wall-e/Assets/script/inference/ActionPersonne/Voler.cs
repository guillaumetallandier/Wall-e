using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Voler : Action {

	override public void execute(GameObject go, GameObject gm)
    {
        go.GetComponent<Personne>().presenteInventaire();
     
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("volerDebut",gm.GetComponent<Personne>().name, go.GetComponent<Personne>().name);

        gm.GetComponent<Observable>().notifyObservers(this.getType(), gm.gameObject);

        gm.GetComponent<Personne>().setItem(go.GetComponent<Personne>().getItem());
        go.GetComponent<Personne>().setItem(null);

        gm.GetComponent<Personne>().presenteInventaire(); //inventaire voleur : doit avoir porte-feuille
        go.GetComponent<Personne>().presenteInventaire(); //inventaire humain: doir etre vide

        gm.GetComponent<Personne>().estVoler();
        
    }

    public override string getType()
    {
        return "voler";
    }

}
