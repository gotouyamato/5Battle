using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionScript : MonoBehaviour
{
    // 決定ボタンの処理
    BattleScript BattleScript;
    [SerializeField] GameObject BattleSystem;
    [SerializeField] public GameObject Decision;

    void Start()
    {
        BattleScript = BattleSystem.GetComponent<BattleScript>();
    }

    void Update()
    {
        Decision.SetActive(false);
        // BattleScript.FieldImage1からBattleScript.FieldImage5のうちのどれかがアクティブでかつ、BattleScript.FieldImageHuman1からBattleScript.FieldImageAngelのうちのどれかがアクティブのとき、処理を行う
        if ((BattleScript.FieldImage1.activeSelf == true || BattleScript.FieldImage2.activeSelf == true || BattleScript.FieldImage3.activeSelf == true || BattleScript.FieldImage4.activeSelf == true || BattleScript.FieldImage5.activeSelf == true) && (BattleScript.FieldImageHuman1.activeSelf == true || BattleScript.FieldImageHuman2.activeSelf == true || BattleScript.FieldImageHuman3.activeSelf == true || BattleScript.FieldImageDevil.activeSelf == true || BattleScript.FieldImageAngel.activeSelf == true)) {
            Decision.SetActive(true);
        }  
    }
}
