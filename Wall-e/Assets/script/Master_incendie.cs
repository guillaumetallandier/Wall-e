using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class Master_incendie : MonoBehaviour
{

    public GameObject po1; //personne en danger
    public GameObject robot;

    public Text texte;
    private bool fin = false;
    public string json;
    private Dictionary<string, string> result;

    // Use this for initialization
    public void begin(List<Regle> lr, List<EnumPeople> lp)
    {
        //Initialisation du composant pour la lecture des textes + encodage en utf8 
        Debug.Log("Personnage et Robot près");
        Encoding t = Encoding.Default;
        StreamReader readervict = new StreamReader("texte.json", t);
        json = readervict.ReadToEnd();
        result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

        po1.GetComponent<Observable>().Setup();
        robot.GetComponent<Robot>().Setup("walle",lr,lp);

        po1.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());

        po1.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());

        po1.GetComponent<Personne>().SetUp("Gege");

        Debug.Log("Personnage et Robot près");

        po1.GetComponent<Personne>().appelerSecours();
        robot.GetComponent<Robot>().execute(robot, po1);

        //fin = true;
    }

    public Action aleAction()
    {
        System.Random rd = new System.Random();
        int nbr = rd.Next(4);
        Action a;

        switch (nbr)
        {
            case 0:
                a = new AllerSauver();
                break;

            case 1:
                a = new UtiliserObjet();
                break;

            case 2:
                a = new PrevenirAutorite();
                break;

            default:
                a = new Frapper();
                break;
        }
        return a;

    }
    public void RecupTexte(string key, string name1, string name2)
    {
        this.texte.text += name1 + result[key] + name2 + "\n";
    }

    //Fonction quitter le jeu total 
    public void EndGame()
    {

    }

    //Fonction pause situation avant la suivante 
    public void pauseSituation()
    {
        Time.timeScale = 0;
    }
}
