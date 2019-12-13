using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class Master : MonoBehaviour {

<<<<<<< HEAD
   /* public GameObject po1; //voleur
    public GameObject po2; //humain
    public GameObject robot;*/

    public List<GameObject> listeSituation;
    

    //public GameObject GO_item;
    // public GameObject ITEM_item;
=======
    //public GameObject po1; //voleur
    //public GameObject po2; //humain
    //public GameObject robot;
    public List<GameObject> Scenario;

    //public GameObject GO_item;
>>>>>>> 211e14e41debe52b5c11390b0012681fea20bb23

    public Text texte;
    private bool fin = false;
    public string json;
    private Dictionary<string, string> result; 

    // Use this for initialization
    public void begin (List<Regle> lr, List<EnumPeople> lp) {
        //Initialisation du composant pour la lecture des textes + encodage en utf8 

        Encoding t = Encoding.Default;
        StreamReader readervict = new StreamReader("texte.json", t);
        json = readervict.ReadToEnd();
        result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

<<<<<<< HEAD
        GameObject spawnedObject =  Instantiate(listeSituation[0], new Vector3(-92,2.1f, -121), Quaternion.identity);
        spawnedObject.GetComponent<Master2>().begin(lr, lp);
        //master2.begin(lr, lp);

        

        /*
        
        po1.GetComponent<Observable>().Setup();
        po2.GetComponent<Observable>().Setup();
        robot.GetComponent<Robot>().Setup("walle",lr,lp);
        po1.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
        po2.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
=======
        GameObject inst = Instantiate(Scenario[0], new Vector3(-86, 0, -121), Quaternion.identity);
        inst.GetComponent<MasterNuc>().begin(lr, lp);


        //po1.GetComponent<Observable>().Setup();
        //po2.GetComponent<Observable>().Setup();
        //robot.GetComponent<Robot>().Setup("walle",lr,lp);

        //po1.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
        //po2.GetComponent<Observable>().addObserver(robot.GetComponent<Observer>());
>>>>>>> 211e14e41debe52b5c11390b0012681fea20bb23

        //po1.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());
        //po2.GetComponent<Personne>().setRobot(robot.GetComponent<Robot>());

<<<<<<< HEAD
        po1.GetComponent<Personne>().SetUp("Gege", EnumPeople.adulte) ;
        po2.GetComponent<Personne>().SetUp("Bernard",EnumPeople.adulte);

=======
        //po1.GetComponent<Personne>().SetUp("Gege",EnumPeople.adulte);
        //po2.GetComponent<Personne>().SetUp("Bernard",EnumPeople.adulte);
>>>>>>> 211e14e41debe52b5c11390b0012681fea20bb23

        //po2.GetComponent<Personne>().setItem(new Item("porte-feuille", GO_item));

<<<<<<< HEAD
        po1.GetComponent<Personne>().execute(new Voler() , po2);
        */
=======
        //po1.GetComponent<Personne>().execute(new Voler() , po2);

>>>>>>> 211e14e41debe52b5c11390b0012681fea20bb23
    }
	
    public void RecupTexte(string key, string name1, string name2)
    {
        Debug.Log(result[key]);
        this.texte.text += name1 + result[key] + name2 +"\n";
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
