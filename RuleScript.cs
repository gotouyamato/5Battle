using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleScript : MonoBehaviour
{
    [SerializeField] GameObject Rule;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RuleClick(){
        Rule.SetActive(true);
        Debug.Log("押された");
    }
    public void CloseClick(){
        Rule.SetActive(false);
    }
}
