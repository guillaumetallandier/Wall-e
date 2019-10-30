using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Personne : MonoBehaviour {
    
    private Transform player;
    private NavMeshAgent nav;

    private string _name;
    private GameObject _robot;
    private int _dangerosite;
    private EnumPeople _typePeople;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Personne").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }

    public void Setup(string name, GameObject robot, int dangerosite, EnumPeople typePeople)
    {
        _name = name;
        _robot = robot;
        _dangerosite = dangerosite;
        _typePeople = typePeople;
    }

    public string getName()
    {
        return _name;
    }

    public void setDangerosite(int dangerosite)
    {
        _dangerosite = dangerosite;
    }

    void donnerOrdre(string quote, EnumRules order, Personne target)
    {
        Debug.Log(quote);
        _robot.GetComponent<Robot>().Execute(order,target);
    }

}
