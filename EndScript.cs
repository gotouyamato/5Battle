using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    //　終了ボタンの処理
    public AudioClip impact;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }
    void Update()
    {
    }
    IEnumerator LoadSceneAfterSound()
    {
        // 効果音の長さだけ待つ
        yield return new WaitForSeconds(impact.length);
        // シーン移動する
        SceneManager.LoadScene("TitleScene");
    }
    public void MoveTitle(){
        audioSource.PlayOneShot(impact, 1.0F);
        StartCoroutine(LoadSceneAfterSound());
    }
}
