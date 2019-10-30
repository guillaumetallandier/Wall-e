using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenar : MonoBehaviour{
    private Solution choix;

    public GameObject personne;
    public GameObject robot_prefab;
    void Start()
    {
        GameObject voleur = GameObject.Instantiate(personne, new Vector3(0.0F,0.5F,0.0F), new Quaternion(0,0,0,0));
        GameObject robot = GameObject.Instantiate(robot_prefab, new Vector3(-3.0F, 0.5F, 0.0F), new Quaternion(0, 0, 0, 0));
    }
}
