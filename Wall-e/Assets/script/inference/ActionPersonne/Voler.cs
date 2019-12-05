using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voler : Action {

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
    }

    public override string getType()
    {
        return "voler";
    }

}
