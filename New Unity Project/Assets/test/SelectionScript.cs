using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class OptionRule : Dropdown.OptionData
{
    private EnumRules value;
    public OptionRule(EnumRules value) : base()
    {
        this.Value = value;
    }

    public EnumRules Value { get => value; set => this.value = value; }

}

public class SelectionScript : MonoBehaviour
{
    public Text rule;
    public Dropdown dd;
    public Transform contentPanel;
    public GameObject type1;
    public GameObject type2;

    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < Enum.GetNames(typeof(EnumRules)).Length ; i++)
        {
            {
                dd.options.Add(new OptionRule((EnumRules) Enum.GetValues(typeof(EnumRules)).GetValue(i)) { text = Enum.GetNames(typeof(EnumRules))[i] }); ;
            }
        }
        dd.onValueChanged.AddListener(delegate
        {
            spawnRule((OptionRule)dd.options[dd.value]);
        });
    }

    public void spawnRule(OptionRule ruleType)
    {
        GameObject spawnedGameObject;
        switch (ruleType.Value)
        {

            case  EnumRules.peutTuer:

                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(EnumRules.peutTuer, "Robot peut tuer");
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                Destroy(gameObject);

                break;

            case EnumRules.nePasTuer:

                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                Destroy(gameObject);

                break;

            case EnumRules.ecoute:

                spawnedGameObject = (GameObject)GameObject.Instantiate(type2);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                Destroy(gameObject);

                break;
        }
    }
}
