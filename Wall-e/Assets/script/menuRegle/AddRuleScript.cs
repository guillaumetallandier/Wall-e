using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddRuleScript : MonoBehaviour
{

    public Button but;
	// Use this for initialization
	void Start () {
        this.but.onClick.AddListener(delegate
        {
            spawnNewRule();
        });
    }

    public void spawnNewRule()
    {
        GameObject.FindGameObjectWithTag("gestionMenuRules").GetComponent<GroupScript>().spawnSelection(gameObject.transform.GetSiblingIndex());
    }
}
