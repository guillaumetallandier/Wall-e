using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour {

    private Transform player;
    private NavMeshAgent nav;

    //liste de regles que le Robot doit respecter
    private List<EnumRules> rulesList = new List<EnumRules>();
    //liste de personnes que le Robot doit écouter
    private List<EnumPeople> peopleList = new List<EnumPeople>();

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Personne").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    public void SetRules(List<EnumRules> rulesList, List<EnumPeople> peopleList)
    {
        this.rulesList.AddRange(rulesList);
        if (this.rulesList.Contains(EnumRules.ecoute)) {
            this.peopleList.AddRange(peopleList);
        }
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }

    public void Execute(EnumRules order, Personne target)
    {
        Debug.Log("Robot : " + order.ToString() + " SUR " + target.getName());

        //mettre le code de déplacement
    }
}
