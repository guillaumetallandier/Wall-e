using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Voler : Action {

<<<<<<< HEAD
	override public void execute(Personne p, GameObject gm)    {
        Debug.Log(gm.name + " vole : " + p.name);
        gm.GetComponent<Observable>().notifyObservers(this.getType(), gm.gameObject);
=======
	override public void execute(Personne p, Personne pAgit)
    {
       string json;
        
        StreamReader readervict = new StreamReader("texte.json",Encoding.UTF8); 
        json = readervict.ReadToEnd();
        var result = JsonConvert.DeserializeObject < Dictionary < string,string>>(json);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte(pAgit.Name + result["volerDebut"] + p.Name);
        
        pAgit.notifyObservers(this.getType(), pAgit.gameObject);
>>>>>>> 33317e3b6f4b04d159ba1956f62173e83b9da3d1
        
    }

    public override string getType()
    {
        return "voler";
    }

}
