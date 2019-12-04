using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour, Observer
{
    public string Name;
    public Action action;
    private List<Regle> rulesList = new List<Regle>();
    private List<EnumPeople> peopleList = new List<EnumPeople>();
    private GameObject target;
    private NavMeshAgent nav;

    public void Setup(string name)
    {
        this.name = name;
        this.nav = gameObject.GetComponent<NavMeshAgent>();
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
        this.execute(this.target.GetComponent<Personne>());
    }

    public void SetRules(List<Regle> rulesList, List<EnumPeople> peopleList)
    {
        this.rulesList.AddRange(rulesList);
        this.peopleList.AddRange(peopleList);

    }

    public void execute(Personne p)
    {
        action.execute(p,null);
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

}
