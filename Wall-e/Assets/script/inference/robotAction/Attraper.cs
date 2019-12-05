using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class Attraper : Action
{
<<<<<<< HEAD
    override public void execute(Personne p, Personne pAgit)
    {   
        Debug.Log("Robot : Attrape " + p.Name);
=======
    override public void execute(Personne p, GameObject gm)
    {
<<<<<<< HEAD
        Debug.Log("Robot : Attrape " + gm.name);
=======
        string json;
        StreamReader readervict = new StreamReader("texte.json", Encoding.UTF8);
        json = readervict.ReadToEnd();
        var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte(result["voleurAttraper"] + pAgit.Name);
        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().pauseSituation();

        pAgit.notifyObservers(this.getType(), p.gameObject);

>>>>>>> 33317e3b6f4b04d159ba1956f62173e83b9da3d1
>>>>>>> d8ea07e29c7e8989b3107383b07f871f999015f9
    }

    public override string getType()
    {
        return "attrape";
    }

}

