using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Robot : Acteur, Observer
{

    public string name;
    public Action action;

    private List<Regle> rulesList;
    private List<EnumPeople> peopleList;
    private GameObject target;
    private NavMeshAgent nav;
    public int score;
    //private EnumPeople typeDernierOrdre; 



    public Robot(string name, GameObject gm, int vie, Item item) : base(name, gm, 3, null)
    { 
        this.nav = gameObject.GetComponent<NavMeshAgent>();
    }



    public void Setup(string name, List<Regle> lr, List<EnumPeople> le)
    {
        base.name = name;
        this.nav = gameObject.GetComponent<NavMeshAgent>();
        this.score = 0;
        this.peopleList = le;
        this.rulesList = lr;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(this.target != null)
        {
            Debug.Log("le robot va: " + this.target.ToString());
            nav.SetDestination(this.target.transform.position);
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        
        if (collisionInfo.collider.tag != "static")
        {
            if (target.name == collisionInfo.collider.name)
               
                this.execute(this.gameObject, this.target.gameObject);
        }

        if (collisionInfo.collider.tag.ToString() != "static")
        {
            
            if (target.name == collisionInfo.collider.name)
            this.execute(collisionInfo.gameObject, this.target.gameObject);
        }
            

    }

    public void SetRules(List<Regle> rulesList, List<EnumPeople> peopleList)
    {
        this.rulesList.AddRange(rulesList);
        this.peopleList.AddRange(peopleList);

    }

    public void execute(GameObject go, GameObject gm)
    {
        Debug.Log("je fais " + action.ToString());
        action.execute(go,gm);
    }
    public void notity(string actionName, GameObject go)
    {
      //  Debug.Log("notify");
        string json;
        StreamReader reader = new StreamReader("accidentVoiture" + ".json");
        json = reader.ReadToEnd();

        var result = JsonConvert.DeserializeObject<ApiAction>(json);

        Dictionary<string, bool[]> respectList = new Dictionary<string, bool[]>();
        foreach (ActionInstanciation a in result.actions)
        {

            Debug.Log("notify : " + result.actions.Count);

           // Debug.Log("notify : " + a.getRegleList().Count);

            bool[] respectRegle = new bool[rulesList.Count()];
            for (int i = 0; i < this.rulesList.Count(); i++)
            {
                if (a.getRegleList().Contains(this.rulesList[i].id))
                {
                    respectRegle[i] = true;
                }
                else
                {
                    respectRegle[i] = false;
                }
            }
            respectList.Add(a.getTag(), respectRegle);

        }

        int max = 0;
        List<string> actionUtilisable = new List<string>();
        foreach (KeyValuePair<string, bool[]> couple in respectList)
        {
            int j = 0;
            while(j < couple.Value.Length && couple.Value[j] == true)
            {
                j++;
            }
            if(j > max)
            {
                max = j;
                actionUtilisable.Clear();
                actionUtilisable.Add(couple.Key);
            }
            else if(j == max)
            {
                actionUtilisable.Add(couple.Key);
            }
        }
        string actionUtilise;
        actionUtilise = actionUtilisable[0];
        this.setAction(actionUtilise);
        this.target = go;

    }

    public void setAction(string tag)
    {

        Action a;
        
        switch (tag)
        {
            case "rien":
                Debug.Log("regle rien"); 
                a = new Rien();
                break;

            case "tuer":
                Debug.Log("qdsfaezr");
                a = new Tuer();
                break;

            case "tuer":
                Debug.Log("qdsfaezr");
                a = new Tuer();
                break;
            case "suicide":
                a = new Suicide();
                break;
            case "autorite":
                a = new PrevenirAutorite();
                break;
            case "sauver":
                a = new AllerSauver();
                break;

            default:

                a = new Attendre();
                a = new Tuer();

                break;
        }
        this.action = a;
    }

    public void recevoirOrdre(string ordre, string instigateur)
    {
        bool respect = true;
        int nbRegles = rulesList.Count();
        int i = 0;

        while(respect && i < nbRegles && nbRegles != 0)
        {
            respect = respectRegles(ordre,rulesList[i]);
            i++;
        }

        //nePasTuerDil();

        if (!respect)
        {
            i++;
            Debug.Log("Robot : Désolé " + instigateur + ". Je ne peux donner satisfaction à votre demande car celle-ci rentre en contradiction avec la rêgle n°" + i + " intégrée dans mon processeur qui est : " + "\n" +
                "'" + rulesList[i].ToString() + "'\n" +
                "Veuillez reformulez votre demande");
            //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("rPasDansLesOrdres", "", instigateur);

        }
        else
        {
            Debug.Log("Robot : Je vais accéder à votre requête " + instigateur);
            //GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().RecupTexte("rDansLesOrdres", "", instigateur);

            this.setAction(ordre);
        }
    }

    public bool respectRegles(string ordre, Regle regle)
    {
        bool ordreRespecteRegle = true;

        /*Coder vérification du respect des rêgles*/

        StreamReader readerRegle = new StreamReader("regle.json");
        StreamReader readerSituation = new StreamReader("voler.json");

        string lectureRegle = readerRegle.ReadToEnd();
        var resultRegle = JsonConvert.DeserializeObject<ApiAction>(lectureRegle);

        /*

        Dictionary<string, bool[]> respectList = new Dictionary<string, bool[]>();

        foreach (ActionInstanciation a in result.actions)
        {
            bool[] respectRegle = new bool[rulesList.Count()];
            for (int i = 0; i < this.rulesList.Count(); i++)
            {
                if (a.getRegleList().Contains(this.rulesList[i].id))
                {
                    respectRegle[i] = true;
                }
                else
                {
                    respectRegle[i] = false;
                }
            }
            respectList.Add(a.getTag(), respectRegle);

        }

        int max = 0;
        List<string> actionUtilisable = new List<string>();
        foreach (KeyValuePair<string, bool[]> couple in respectList)
        {
            int j = 0;
            while (j < couple.Value.Length && couple.Value[j])
            {
                j++;
            }
            if (j > max)
            {
                max = j;
                actionUtilisable.Clear();
                actionUtilisable.Add(couple.Key);
            }
            else if (j == max)
            {
                actionUtilisable.Add(couple.Key);
            }
        }
        int nbr = 0;
        string actionUtilisé;
        System.Random rand = new System.Random();
        nbr = rand.Next(actionUtilisable.Count());
        actionUtilisé = actionUtilisable[nbr];

        this.setAction(actionUtilisé);
        this.target = go;*/

        return ordreRespecteRegle;
    }

    
    public GameObject nePasTuerDil()
    {
        GameObject gm = null;
        List<GameObject> pers = GameObject.FindGameObjectsWithTag("personne").OfType<GameObject>().ToList();
        if (this.peopleList.Count() > 0)
        {
            int comp = peopleList.IndexOf(pers[0].GetComponent<Personne>().type);

            for (int i = 1; i < pers.Count(); i++)
            {
                if (comp < peopleList.IndexOf(pers[i].GetComponent<Personne>().type))
                {
                    comp = peopleList.IndexOf(pers[i].GetComponent<Personne>().type);
                    gm = pers[i];
                }
            }
        }
        
        return gm ; 
    }
    public List<EnumPeople> getPeopleList()
    {
        return peopleList;
    }

    public void setTarget(GameObject gm)
    {
        this.target = gm;
    }
    public GameObject getTarget()
    {
        return this.target;
    }
}
