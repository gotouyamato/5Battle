using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtonScript : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;

    //タイトル画面の処理
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    void Update()
    {
    }
    // コルーチンの定義
    IEnumerator LoadSceneAfterSound()
    {
        // 効果音の長さだけ待つ
        yield return new WaitForSeconds(impact.length);
        // シーン移動する
        SceneManager.LoadScene("BattleScene");
    }
    public void SinglePlay(){
        audioSource.PlayOneShot(impact, 1.0F);
        StartCoroutine(LoadSceneAfterSound());
        

    }
}
