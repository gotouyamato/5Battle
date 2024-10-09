using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionScript : MonoBehaviour
{
    BattleScript BattleScript;
    [SerializeField] GameObject BattleSystem;
    [SerializeField] public GameObject Decision;

    // Start is called before the first frame update
    void Start()
    {
        BattleScript = BattleSystem.GetComponent<BattleScript>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Decision.SetActive(false);
        // BattleScript.FieldImage1からBattleScript.FieldImage5のうちのどれかがアクティブでかつ、BattleScript.FieldImageHuman1からBattleScript.FieldImageAngelのうちのどれかがアクティブのとき、処理を行う
    // 論理演算子 || (or) と && (and) を使って条件を組み合わせる
    if ((BattleScript.FieldImage1.activeSelf == true || BattleScript.FieldImage2.activeSelf == true || BattleScript.FieldImage3.activeSelf == true || BattleScript.FieldImage4.activeSelf == true || BattleScript.FieldImage5.activeSelf == true) && (BattleScript.FieldImageHuman1.activeSelf == true || BattleScript.FieldImageHuman2.activeSelf == true || BattleScript.FieldImageHuman3.activeSelf == true || BattleScript.FieldImageDevil.activeSelf == true || BattleScript.FieldImageAngel.activeSelf == true)) {
        Decision.SetActive(true);
    }

        
    }
}
