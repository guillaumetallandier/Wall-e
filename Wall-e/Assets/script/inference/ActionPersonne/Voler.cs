using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Voler : Action {

<<<<<<< HEAD
	override public void execute(Personne persVolee, Personne persVoleur)
    {
        persVolee.presenteInventaire(); //inventaire humain: doir avoir porte-feuille

        Debug.Log(persVoleur.name + " vole : " + persVolee.name);
        persVoleur.notifyObservers(this.getType(), persVoleur.gameObject);

        persVoleur.setItem(persVolee.getItem());
        persVolee.setItem(null);

        persVoleur.presenteInventaire(); //inventaire voleur : doit avoir porte-feuille
        persVolee.presenteInventaire(); //inventaire humain: doir etre vide

        persVolee.estVoler();
=======
	override public void execute(Personne p, GameObject gm)
    {
       string json;
        
        StreamReader readervict = new StreamReader("texte.json",Encoding.UTF8); 
        json = readervict.ReadToEnd();
        var result = JsonConvert.DeserializeObject < Dictionary < string,string>>(json);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte(gm.GetComponent<Personne>().Name + result["volerDebut"] + p.Name);
        
        gm.GetComponent<Observable>().notifyObservers(this.getType(), gm.gameObject);
        
>>>>>>> d8ea07e29c7e8989b3107383b07f871f999015f9
    }

    public override string getType()
    {
        return "voler";
    }

}
