using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour {

    public GameObject po1; //voleur
    public GameObject po2; //humain
    public GameObject robot;

    public GameObject GO_item;
    public GameObject ITEM_item;

    public Text texte;
    private bool fin = false;

    // Use this for initialization
    public void begin (List<Regle> lr, List<EnumPeople> lp) {
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

       // pauseSituation();

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
    public void RecupTexte(string expli)
    {
        this.texte.text += expli + "\n";
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
