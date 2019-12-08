using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class Master : MonoBehaviour {

    public GameObject po1; //voleur
    public GameObject po2; //humain
    public GameObject robot;

    public GameObject GO_item;
    public GameObject ITEM_item;

    public Text texte;
    private bool fin = false;
    public string json;
    private Dictionary<string, string> result; 

    // Use this for initialization
    public void begin (List<Regle> lr, List<EnumPeople> lp) {

        //Initialisation du composant pour la lecture des textes + encodage en utf8 
        //string json;
        Encoding t = Encoding.Default;
        StreamReader readervict = new StreamReader("texte.json",t);
        json = readervict.ReadToEnd();
        result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

        po1.GetComponent<Observable>().Setup();
        po2.GetComponent<Observable>().Setup();
        robot.GetComponent<Robot>().Setup("walle");

        po1.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
        po2.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());

        po1.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());
        po2.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());

        po1.GetComponent<Personne>().SetUp("Gege");
        po2.GetComponent<Personne>().SetUp("Bernard");

        po2.GetComponent<Personne>().setItem(new Item("porte-feuille", GO_item));

        po1.GetComponent<Personne>().execute(new Voler() , po2);


       


    }
	
	// Update is called once per frame
	void Update () {
         
	}

  
    public Action aleAction()
    {
        System.Random rd = new System.Random();
        int nbr = rd.Next(2);
        Action a;

        switch (nbr)
        {
            case 0 :
                a = new Voler();
                break;

            default:
                a = new Frapper();
                break;
        }
        return a;

    }
    public void RecupTexte(string key, string name1, string name2)
    {
        
        this.texte.text += name1 + result[key] + name2 +"\n";
    }

    //Fonction quitter le jeu total 
    public void EndGame()
    {
        
    }

    //Fonction pause situation avant la suivante 
    public void pauseSituation()
    {
        //if (Input.GetKeyDown(KeyCode.Space)){
        // if (fin)
        //  Time.timeScale = 1;
        //else
        //{
                Time.timeScale = 0;
          //  }
            //fin = !fin;
        //}
        
    }
}
