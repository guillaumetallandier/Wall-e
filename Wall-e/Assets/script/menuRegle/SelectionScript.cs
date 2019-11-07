using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;



public class OptionRule : Dropdown.OptionData
{
    private Regle value;
    public OptionRule(Regle value) : base()
    {
        this.value = value;
    }

    public Regle getValue()
    {
        return this.value;
    }

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
        string json;
        StreamReader reader = new StreamReader("regle.json");
        json = reader.ReadToEnd();
        var result = JsonConvert.DeserializeObject<ApiRegle>(json);
        for (int i = 0; i < result.getRegles().Count; i++)
        {
            {
                dd.options.Add(new OptionRule(result.getRegles()[i]) { text = result.getRegles()[i].getDescription() }); ;
            }
        }
        dd.onValueChanged.AddListener(delegate
        {
            spawnRule((OptionRule)dd.options[dd.value]);
        });
        dd.captionText.text = dd.options[0].text;
    }

    public void spawnRule(OptionRule ruleType)
    {
        GameObject spawnedGameObject;
        switch (ruleType.getValue().getTag())
        {

            case "tuer":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue());
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                Destroy(gameObject);

                break;

            case "nePasTuer":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue());
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                Destroy(gameObject);

                break;

            case "ecoute":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type2);
                spawnedGameObject.GetComponent<RuleType2Script>().Setup(ruleType.getValue());
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                Destroy(gameObject);

                break;

            default :
                break;
        }
    }
}
