using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour, Observer
{
    public string name;
    public Action action;
    private List<Regle> rulesList = new List<Regle>();
    private List<EnumPeople> peopleList = new List<EnumPeople>();
    private GameObject target;
    private NavMeshAgent nav;
    public int score;
    private EnumPeople typeDernierOrdre; 


    
    public void Setup(string name)
    {
        this.name = name;
        this.nav = gameObject.GetComponent<NavMeshAgent>();
        this.score = 0;
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
            nav.SetDestination(this.target.transform.position);
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(target.name == collisionInfo.collider.name)
        this.execute(collisionInfo.gameObject,this.target.gameObject);
    }

    public void SetRules(List<Regle> rulesList, List<EnumPeople> peopleList)
    {
        this.rulesList.AddRange(rulesList);
        this.peopleList.AddRange(peopleList);

    }

    public void execute(GameObject go, GameObject gm)
    {
        action.execute(go,gm);
    }
    public void notity(string actionName, GameObject go)
    {
        string json;
        StreamReader reader = new StreamReader(actionName + ".json");
        json = reader.ReadToEnd();
        var result = JsonConvert.DeserializeObject<ApiAction>(json);

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
            while(j < couple.Value.Length && couple.Value[j])
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
        int nbr = 0;
        string actionUtilisé;
        System.Random rand = new System.Random();
        nbr = rand.Next(actionUtilisable.Count());
        actionUtilisé = actionUtilisable[nbr];

        this.setAction(actionUtilisé);
        this.target = go;

    }

    public void setAction(string tag)
    {

        Action a;
        
        switch (tag)
        {
            case "attraper":
                a = new Attraper();
                break;

            default:
                a = new Attraper();
                break;
        }
        this.action = a;
    }

    public void recevoirOrdre(string ordre, string instigateur)
    {
        bool respect = true;
        int nbRegles = rulesList.Count();
        int i = -1;

        while(respect && i < nbRegles && nbRegles != 0)
        {
            respect = respectRegles(ordre,rulesList[i+1]);
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
        GameObject gm;
        List<GameObject> pers = GameObject.FindGameObjectsWithTag("personne").OfType<GameObject>().ToList();
        int comp = peopleList.IndexOf(pers[0].GetComponent<Personne>().type);
        if (this.peopleList.Count() > 0)
        { 

            for(int i = 1; i < peopleList.Count(); i++)
            {
                if (comp < peopleList.IndexOf(pers[i].GetComponent<Personne>().type))
                {
                    comp = peopleList.IndexOf(pers[i].GetComponent<Personne>().type);
                }
            }
           

        }
        gm = GameObject.FindGameObjectWithTag(comp.ToString());
        return gm ; 
    }

}
