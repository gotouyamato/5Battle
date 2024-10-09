using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = System.Random; // System.RandomをRandomという別名で参照する
using DG.Tweening;

public class BattleScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Message;
    [SerializeField] public TextMeshProUGUI TurnMessage;
    [SerializeField] public GameObject Image1;
    [SerializeField] public GameObject Image2;
    [SerializeField] public GameObject Image3;
    [SerializeField] public GameObject Image4;
    [SerializeField] public GameObject Image5;
    [SerializeField] public GameObject ImageHuman1;
    [SerializeField] public GameObject ImageHuman2;
    [SerializeField] public GameObject ImageHuman3;
    [SerializeField] public GameObject ImageDevil;
    [SerializeField] public GameObject ImageAngel;
    [SerializeField] public GameObject FieldImage1;
    [SerializeField] public GameObject FieldImage2;
    [SerializeField] public GameObject FieldImage3;
    [SerializeField] public GameObject FieldImage4;
    [SerializeField] public GameObject FieldImage5;
    [SerializeField] public GameObject FieldImageHuman1;
    [SerializeField] public GameObject FieldImageHuman2;
    [SerializeField] public GameObject FieldImageHuman3;
    [SerializeField] public GameObject FieldImageDevil;
    [SerializeField] public GameObject FieldImageAngel;
    [SerializeField] public GameObject EnemyFieldImage1;
    [SerializeField] public GameObject EnemyFieldImage2;
    [SerializeField] public GameObject EnemyFieldImage3;
    [SerializeField] public GameObject EnemyFieldImage4;
    [SerializeField] public GameObject EnemyFieldImage5;
    [SerializeField] public GameObject EnemyFieldImageHuman1;
    [SerializeField] public GameObject EnemyFieldImageHuman2;
    [SerializeField] public GameObject EnemyFieldImageHuman3;
    [SerializeField] public GameObject EnemyFieldImageDevil;
    [SerializeField] public GameObject EnemyFieldImageAngel;
    [SerializeField] public GameObject BlackImage1;
    [SerializeField] public GameObject BlackImage2;
    [SerializeField] public GameObject ResultWindow;
    [SerializeField] public GameObject WinMessage;
    [SerializeField] public GameObject LoseMessage;
    [SerializeField] public GameObject DrawMessage;
    [SerializeField] public GameObject NextTurnButton;
    // [SerializeField] public GameObject PlayerBlackStar1;
    [SerializeField] public GameObject PlayerStar1;
    // [SerializeField] public GameObject PlayerBlackStar2;
    [SerializeField] public GameObject PlayerStar2;
    // [SerializeField] public GameObject PlayerBlackStar3;
    [SerializeField] public GameObject PlayerStar3;
    // [SerializeField] public GameObject EnemyBlackStar1;
    [SerializeField] public GameObject EnemyStar1;
    // [SerializeField] public GameObject EnemyBlackStar2;
    [SerializeField] public GameObject EnemyStar2;
    // [SerializeField] public GameObject EnemyBlackStar3;
    [SerializeField] public GameObject EnemyStar3;
    List<int> CPHandCards = new List<int>();
    List<string> CPJobCards = new List<string>();
    public AudioClip card;
    AudioSource audioSource;

    public int numberchoice;
    public string jobchoice;
    public int turn;
    // Start is called before the first frame update
    void Awake(){
        turn=1;
    }
    void Start()
    {
        int[] CPHandCard = {1,2,3,4,5};
        CPHandCards.AddRange(CPHandCard);
        string[] CPJobCard = {"人間","人間","人間","悪魔","天使"};
        CPJobCards.AddRange(CPJobCard); 
        Message.text = "カードを選んでください";
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void DeleteCard(){
        if(FieldImage1.activeSelf == true){
            FieldImage1.SetActive(false);
        }
        if(FieldImage2.activeSelf == true){
            FieldImage2.SetActive(false);
        }
        if(FieldImage3.activeSelf == true){
            FieldImage3.SetActive(false);
        }
        if(FieldImage4.activeSelf == true){
            FieldImage4.SetActive(false);
        }
        if(FieldImage5.activeSelf == true){
            FieldImage5.SetActive(false);
        }
        if(FieldImageHuman1.activeSelf == true){
            FieldImageHuman1.SetActive(false);
        }
        if(FieldImageHuman2.activeSelf == true){
            FieldImageHuman2.SetActive(false);
        }
        if(FieldImageHuman3.activeSelf == true){
            FieldImageHuman3.SetActive(false);
        }
        if(FieldImageDevil.activeSelf == true){
            FieldImageDevil.SetActive(false);
        }
        if(FieldImageAngel.activeSelf == true){
            FieldImageAngel.SetActive(false);
        }
    }

    public int NumChoice(){
        if(FieldImage1.activeSelf == true){
            numberchoice = 1;
        }
        if(FieldImage2.activeSelf == true){
            numberchoice = 2;
        }
        if(FieldImage3.activeSelf == true){
            numberchoice = 3;
        }
        if(FieldImage4.activeSelf == true){
            numberchoice = 4;
        }
        if(FieldImage5.activeSelf == true){
            numberchoice = 5;
        }
        return numberchoice; 
    }
    public string JobChoice(){
        if(FieldImageHuman1.activeSelf == true){
            jobchoice = "人間";
        }
        if(FieldImageHuman2.activeSelf == true){
            jobchoice = "人間";
        }
        if(FieldImageHuman3.activeSelf == true){
            jobchoice = "人間";
        }
        if(FieldImageDevil.activeSelf == true){
            jobchoice = "悪魔";
        }
        if(FieldImageAngel.activeSelf == true){
            jobchoice = "天使";
        }
        return jobchoice;
    }
    public int CPNumChoice(){
        // Randomというクラスのインスタンスを作る
        Random random = new Random();

        // リストからランダムにインデックスを取得する
        int index = random.Next(CPHandCards.Count);

        // リストからインデックスに対応する要素を取得する
        int hand = CPHandCards[index];
        // リストからインデックスに対応する要素を削除する
        CPHandCards.RemoveAt(index);
        return hand;
    }
    public string CPJobChoice(){
        Random random = new Random();
        // リストからランダムにインデックスを取得する
        int index = random.Next(CPJobCards.Count);

        // リストからインデックスに対応する要素を取得する
        string job = CPJobCards[index];
        // リストからインデックスに対応する要素を削除する
        CPJobCards.RemoveAt(index);
        return job;
    }


    int cpnum;
    string cpjob;
    int jobflag;
    public int JobChecker(string playerjob, string cpjob){

        if(playerjob == "人間" && cpjob == "悪魔" || playerjob == "天使" && cpjob == "人間"){
            jobflag = 0;

        }else if(cpjob == "人間" && playerjob == "悪魔" || cpjob == "天使" && playerjob == "人間"){
            jobflag = 1;
        }else if(playerjob == "悪魔" && cpjob == "天使"){
            jobflag = 2;
        }else if(cpjob == "悪魔" && playerjob == "天使"){
            jobflag = 3;
        }else{
            jobflag = 4;
        }
        return jobflag;
    }
    public void CPTurn(int cpnum, string cpjob){
        audioSource.PlayOneShot(card, 1.0F);
                
        if(cpnum == 1){
            EnemyFieldImage1.SetActive(true);
            BlackImage1.SetActive(false);
        }else if(cpnum == 2){
            EnemyFieldImage2.SetActive(true);
            BlackImage1.SetActive(false);
        }else if(cpnum == 3){
            EnemyFieldImage3.SetActive(true);
            BlackImage1.SetActive(false);
        }else if(cpnum == 4){
            EnemyFieldImage4.SetActive(true);
            BlackImage1.SetActive(false);
        }else{
            EnemyFieldImage5.SetActive(true);
            BlackImage1.SetActive(false);
        }
        DOVirtual.DelayedCall(1.5f, () => {
            audioSource.PlayOneShot(card, 1.0F);
            if(cpjob == "人間"){
                EnemyFieldImageHuman1.SetActive(true);
                BlackImage2.SetActive(false);
            }else if(cpjob == "悪魔"){
                EnemyFieldImageDevil.SetActive(true);
                BlackImage2.SetActive(false);
            }else{
                EnemyFieldImageAngel.SetActive(true);
                BlackImage2.SetActive(false);
            }
            
        });
        
        
    }
    public int psyouri = 0;

    public void Result(int player, int npc){
        if(player > npc){
            WinResult();
            psyouri++;
        }else if(player < npc){
            LoseResult();
        }else{
            DrawResult();
        }

    }
    [HideInInspector]
    public int playerpoint = 0;
    [HideInInspector]
    public int cppoint = 0;
    
    public void WinResult(){
        ResultWindow.SetActive(true);
        WinMessage.SetActive(true);
        playerpoint = playerpoint + 1;
        if(playerpoint == 1){
            PlayerStar1.SetActive(true);
        }else if(playerpoint == 2){
            PlayerStar2.SetActive(true);
        }else if(playerpoint == 3){
            PlayerStar3.SetActive(true);
        }
    }
    public void LoseResult(){
        ResultWindow.SetActive(true);
        LoseMessage.SetActive(true);
        cppoint = cppoint+1;
        if(cppoint == 1){
            EnemyStar1.SetActive(true);
        }else if(cppoint == 2){
            EnemyStar2.SetActive(true);
        }else if(cppoint == 3){
            EnemyStar3.SetActive(true);
        }

    }
    public void DrawResult(){
        ResultWindow.SetActive(true);
        DrawMessage.SetActive(true);
    }


    public int lastnumberchoice;
    public int lastcpnum;
    public void Battle(){
        jobchoice = JobChoice();
        numberchoice = NumChoice();
        cpnum = CPNumChoice();
        cpjob = CPJobChoice();
        Message.text = "バトル開始！";
        jobflag = JobChecker(jobchoice,cpjob); //jobflag 0:プレイヤーの有利 1:CPの有利 2:プレイヤーの即勝ち 3:CPの即勝ち 4:ドロー 
        if(jobflag == 0){
            lastnumberchoice = numberchoice + 1;
            lastcpnum = cpnum;
        }else if(jobflag == 1){
            lastnumberchoice = numberchoice;
            lastcpnum = cpnum + 1;
        }else if(jobflag == 2){
            // WinResult();
            lastnumberchoice = numberchoice + 10;
            lastcpnum = cpnum;
        }else if(jobflag == 3){
            // LoseResult();
            lastnumberchoice = numberchoice;
            lastcpnum = cpnum + 10;
        }else{
            lastnumberchoice = numberchoice;
            lastcpnum = cpnum;
        }
        // if(turn < 5){
        //     turn = turn + 1;
        // }


        CPTurn(cpnum,cpjob);
        DOVirtual.DelayedCall(3.0f, () => {
            Result(lastnumberchoice, lastcpnum);
        });
        
        // TurnMessage.text = turn + "ターン目";



    }

    
}
