using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuleScript : MonoBehaviour 
{ 

    private EnumRules rule;
    public Text ruleLabel;
    public Button button;
    public GameObject selection;

    public void Setup(EnumRules r,string label)
    {
        this.rule = r;
        this.ruleLabel.text = label;
    }
    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("start");
        button.onClick.AddListener(delegate
        {
            Remove();
        }
            );
    }

    // Update is called once per frame  
    public void Remove()
    {
        GameObject spawnedGameObject = (GameObject)GameObject.Instantiate(selection);
        spawnedGameObject.SetActive(true);
        spawnedGameObject.transform.SetParent(this.transform.parent);
        spawnedGameObject.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
        Destroy(gameObject);
    }

    public Button getButton()
    {
        return this.button;
    }
    
}
