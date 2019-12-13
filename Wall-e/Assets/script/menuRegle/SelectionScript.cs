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
    public Text num;
    public Dropdown dd;
    public Transform contentPanel;
    public GameObject type1;
    public GameObject type2;
    public List<string> memo = new List<string>();
    

    // Start is called before the first frame update

    public void Setup(int num)
    {
        this.num.text = num.ToString();
    }

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
            case "aucune":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());

                break;

            case "nePasTuer":
                //Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type2);
                spawnedGameObject.GetComponent<RuleType2Script>().Setup(ruleType.getValue(), this.num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "nePasBlesser":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type2);
                spawnedGameObject.GetComponent<RuleType2Script>().Setup(ruleType.getValue(),this.num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "nePasEtreDetruit":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), this.num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "ecoute":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type2);
                spawnedGameObject.GetComponent<RuleType2Script>().Setup(ruleType.getValue(), this.num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "tuer":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "etreDetruit":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "respecterLaLoi":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "ProtegerHumanite":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "agirCrime":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "agirAccident":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "autorite":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
<<<<<<< HEAD
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

            case "sauver":
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
=======
>>>>>>> 211e14e41debe52b5c11390b0012681fea20bb23
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;

<<<<<<< HEAD


            case "aucune" :
=======
            case "sauver":
>>>>>>> 211e14e41debe52b5c11390b0012681fea20bb23
                Debug.Log(ruleType.getValue().getTag());
                spawnedGameObject = (GameObject)GameObject.Instantiate(type1);
                spawnedGameObject.GetComponent<RuleType1Script>().Setup(ruleType.getValue(), num.text);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                memo.Add(ruleType.getValue().getTag());
                Destroy(gameObject);

                break;



            

            default:
                break; 

            

            
        }
    }
}
