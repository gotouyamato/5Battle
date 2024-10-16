using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class NextTurnButtonScript : MonoBehaviour
{
    GameObject BattleSystem;
    BattleScript BattleScript;

    [SerializeField] public GameObject PlayerStar1;
    [SerializeField] public GameObject PlayerStar2;
    [SerializeField] public GameObject PlayerStar3;
    [SerializeField] public GameObject EnemyStar1;
    [SerializeField] public GameObject EnemyStar2;
    [SerializeField] public GameObject EnemyStar3;

    public AudioClip impact;
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        BattleSystem = GameObject.Find("BattleSystem");
        BattleScript = BattleSystem.GetComponent<BattleScript>();
        // BattleScript = BattleSystem.GetComponent<BattleScript>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    int pstar = 0;
    int cpstar = 0;
    bool pstarflag1 = false;
    bool pstarflag2 = false;
    bool pstarflag3 = false;
    bool cpstarflag1 = false;
    bool cpstarflag2 = false;
    bool cpstarflag3 = false;


    public void NextTurn(){
        
        audioSource.PlayOneShot(impact, 1.0F);
        DOVirtual.DelayedCall(0.17f, () => {
            BattleScript.DeleteCard(); //前のターンで出したカードを手持ちから削除
            // 場の初期化
            BattleScript.ResultWindow.SetActive(false);
            BattleScript.WinMessage.SetActive(false);
            BattleScript.LoseMessage.SetActive(false);
            BattleScript.DrawMessage.SetActive(false);

            BattleScript.EnemyFieldImage1.SetActive(false);
            BattleScript.EnemyFieldImage2.SetActive(false);
            BattleScript.EnemyFieldImage3.SetActive(false);
            BattleScript.EnemyFieldImage4.SetActive(false);
            BattleScript.EnemyFieldImage5.SetActive(false);
            BattleScript.EnemyFieldImageHuman1.SetActive(false);
            BattleScript.EnemyFieldImageHuman2.SetActive(false);
            BattleScript.EnemyFieldImageHuman3.SetActive(false);
            BattleScript.EnemyFieldImageDevil.SetActive(false);
            BattleScript.EnemyFieldImageAngel.SetActive(false);

            BattleScript.BlackImage1.SetActive(true);
            BattleScript.BlackImage2.SetActive(true);

            
            BattleScript.turn = BattleScript.turn + 1;

            //勝利数の処理
            if(PlayerStar1.activeSelf == true && pstarflag1 == false){
                pstar = pstar + 1;
                pstarflag1 = true;
            }
            if(PlayerStar2.activeSelf == true && pstarflag2 == false){
                pstar = pstar + 1;
                pstarflag2 = true;
            }
            if(PlayerStar3.activeSelf == true && pstarflag3 == false){
                pstar = pstar + 1;
                pstarflag3 = true;
            }
            if(EnemyStar1.activeSelf == true && cpstarflag1 == false){
                cpstar = cpstar + 1;
                cpstarflag1 = true;
            }
            if(EnemyStar2.activeSelf == true && cpstarflag2 == false){
                cpstar = cpstar + 1;
                cpstarflag2 = true;
            }
            if(EnemyStar3.activeSelf == true && cpstarflag3 == false){
                cpstar = cpstar + 1;
                cpstarflag3 = true;
            }

            //3勝したら勝利 or 5ターン経過後勝利数の多いほうが勝利
            if(pstar == 3){
                SceneManager.LoadScene("WinScene");
            }
            if(cpstar == 3){
                SceneManager.LoadScene("LoseScene");
            }
            if(BattleScript.turn == 6 && pstar > cpstar){
                SceneManager.LoadScene("WinScene");
            }
            if(BattleScript.turn == 6 && pstar < cpstar){
                SceneManager.LoadScene("LoseScene");
            }
            if(BattleScript.turn == 6 && pstar == cpstar){
                SceneManager.LoadScene("DrawScene");
            }

            if(BattleScript.turn > 5){
                BattleScript.TurnMessage.text = 5 + "ターン目";
            }else{
                BattleScript.TurnMessage.text = BattleScript.turn + "ターン目";
            }
        });
    } 
}
