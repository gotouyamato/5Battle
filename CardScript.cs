using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CardScript : MonoBehaviour
{
    BattleScript BattleScript;
    [SerializeField] GameObject BattleSystem;
    public bool numberFlag;
    public bool jobFlag;

    public AudioClip carsol;
    public AudioClip cancel;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        BattleScript = BattleSystem.GetComponent<BattleScript>();
        numberFlag = false;
        jobFlag = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // カード1を場に出す
    public void DownImage1() {
        if (BattleScript.FieldImage1.activeSelf == false && BattleScript.FieldImage2.activeSelf == false && BattleScript.FieldImage3.activeSelf == false && BattleScript.FieldImage4.activeSelf == false && BattleScript.FieldImage5.activeSelf == false) {
            if (BattleScript.Image1.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.Image1.SetActive(false);
                    BattleScript.FieldImage1.SetActive(true);
                    numberFlag = true;
                    
                });
            }
        }
    }
    // カード2を場に出す
    public void DownImage2() {
        if (BattleScript.FieldImage1.activeSelf == false && BattleScript.FieldImage2.activeSelf == false && BattleScript.FieldImage3.activeSelf == false && BattleScript.FieldImage4.activeSelf == false && BattleScript.FieldImage5.activeSelf == false) {
            if (BattleScript.Image2.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.Image2.SetActive(false);
                    BattleScript.FieldImage2.SetActive(true);
                    numberFlag = true;
                });
                
            }
        }
    }
    // カード3を場に出す
    public void DownImage3() {
        if (BattleScript.FieldImage1.activeSelf == false && BattleScript.FieldImage2.activeSelf == false && BattleScript.FieldImage3.activeSelf == false && BattleScript.FieldImage4.activeSelf == false && BattleScript.FieldImage5.activeSelf == false) {
            if (BattleScript.Image3.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.Image3.SetActive(false);
                    BattleScript.FieldImage3.SetActive(true);
                    numberFlag = true;
                });
            }
        }
    }
    // カード4を場に出す
    public void DownImage4() {
        if (BattleScript.FieldImage1.activeSelf == false && BattleScript.FieldImage2.activeSelf == false && BattleScript.FieldImage3.activeSelf == false && BattleScript.FieldImage4.activeSelf == false && BattleScript.FieldImage5.activeSelf == false) {
            if (BattleScript.Image4.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.Image4.SetActive(false);
                    BattleScript.FieldImage4.SetActive(true);
                    numberFlag = true;
                });
            }
        }
    }
    // カード5を場に出す
    public void DownImage5() {
        if (BattleScript.FieldImage1.activeSelf == false && BattleScript.FieldImage2.activeSelf == false && BattleScript.FieldImage3.activeSelf == false && BattleScript.FieldImage4.activeSelf == false && BattleScript.FieldImage5.activeSelf == false) {
            if (BattleScript.Image5.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.Image5.SetActive(false);
                    BattleScript.FieldImage5.SetActive(true);
                    numberFlag = true;
                });
            }
        }
    }
    // カード人間1を場に出す
    public void DownHuman1() {
        if (BattleScript.FieldImageHuman1.activeSelf == false && BattleScript.FieldImageHuman2.activeSelf == false && BattleScript.FieldImageHuman3.activeSelf == false && BattleScript.FieldImageDevil.activeSelf == false && BattleScript.FieldImageAngel.activeSelf == false) {
            if (BattleScript.ImageHuman1.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.ImageHuman1.SetActive(false);
                    BattleScript.FieldImageHuman1.SetActive(true);
                    jobFlag = true;
                });
            }
        }
    }
    // カード人間2を場に出す
    public void DownHuman2() {
        if (BattleScript.FieldImageHuman1.activeSelf == false && BattleScript.FieldImageHuman2.activeSelf == false && BattleScript.FieldImageHuman3.activeSelf == false && BattleScript.FieldImageDevil.activeSelf == false && BattleScript.FieldImageAngel.activeSelf == false) {
        // ImageHuman2がtrueだったらという条件をif文で書く
            if (BattleScript.ImageHuman2.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.ImageHuman2.SetActive(false);
                    BattleScript.FieldImageHuman2.SetActive(true);
                    jobFlag = true;
                });
            }
        }
    }
    // カード人間3を場に出す
    public void DownHuman3() {
        if (BattleScript.FieldImageHuman1.activeSelf == false && BattleScript.FieldImageHuman2.activeSelf == false && BattleScript.FieldImageHuman3.activeSelf == false && BattleScript.FieldImageDevil.activeSelf == false && BattleScript.FieldImageAngel.activeSelf == false) {
        // ImageHuman3がtrueだったらという条件をif文で書く
            if (BattleScript.ImageHuman3.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.ImageHuman3.SetActive(false);
                    BattleScript.FieldImageHuman3.SetActive(true);
                    jobFlag = true;
                });
            }
        }
    }
    // カード悪魔を場に出す
    public void DownDevil() {
        if (BattleScript.FieldImageHuman1.activeSelf == false && BattleScript.FieldImageHuman2.activeSelf == false && BattleScript.FieldImageHuman3.activeSelf == false && BattleScript.FieldImageDevil.activeSelf == false && BattleScript.FieldImageAngel.activeSelf == false) {
        // ImageDevilがtrueだったらという条件をif文で書く
            if (BattleScript.ImageDevil.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.ImageDevil.SetActive(false);
                    BattleScript.FieldImageDevil.SetActive(true);
                    jobFlag = true;
                });
            }
        }
    }
    // カード天使を場に出す
    public void DownAngel() {
        if (BattleScript.FieldImageHuman1.activeSelf == false && BattleScript.FieldImageHuman2.activeSelf == false && BattleScript.FieldImageHuman3.activeSelf == false && BattleScript.FieldImageDevil.activeSelf == false && BattleScript.FieldImageAngel.activeSelf == false) {
        // ImageAngelがtrueだったらという条件をif文で書く
            if (BattleScript.ImageAngel.activeSelf == true) {
                audioSource.PlayOneShot(carsol, 1.0F);
                DOVirtual.DelayedCall(0.17f, () => {
                    BattleScript.ImageAngel.SetActive(false);
                    BattleScript.FieldImageAngel.SetActive(true);
                    jobFlag = true;
                });
            }
        }
    }

    // カード1を手札に戻す
    public void DownFieldImage1() {
        if (BattleScript.FieldImage1.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImage1.SetActive(false);
                BattleScript.Image1.SetActive(true);
                numberFlag = false;
            });
        }
    }
    // カード2を手札に戻す
    public void DownFieldImage2() {
        // FieldImage2がtrueだったらという条件をif文で書く
        if (BattleScript.FieldImage2.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImage2.SetActive(false);
                BattleScript.Image2.SetActive(true);
                numberFlag = false;
            });
        }
    }
    // カード3を手札に戻す
    public void DownFieldImage3() {
        // FieldImage3がtrueだったらという条件をif文で書く
        if (BattleScript.FieldImage3.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImage3.SetActive(false);
                BattleScript.Image3.SetActive(true);
                numberFlag = false;
            });
        }
    }
    // カード4を手札に戻す
    public void DownFieldImage4() {
        // FieldImage4がtrueだったらという条件をif文で書く
        if (BattleScript.FieldImage4.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImage4.SetActive(false);
                BattleScript.Image4.SetActive(true);
                numberFlag = false;
            });
        }
    }
    // カード5を手札に戻す
    public void DownFieldImage5() {
        // FieldImage5がtrueだったらという条件をif文で書く
        if (BattleScript.FieldImage5.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImage5.SetActive(false);
                BattleScript.Image5.SetActive(true);
                numberFlag = false;
            });
        }
    }
    // カード人間1を手札に戻す
    public void DownFieldImageHuman1() {
        if (BattleScript.FieldImageHuman1.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImageHuman1.SetActive(false);
                BattleScript.ImageHuman1.SetActive(true);
                jobFlag = false;
            });
        }
    }
    // カード人間2を手札に戻す
    public void DownFieldImageHuman2() {
        // FieldImageHuman2がtrueだったらという条件をif文で書く
        if (BattleScript.FieldImageHuman2.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImageHuman2.SetActive(false);
                BattleScript.ImageHuman2.SetActive(true);
                jobFlag = false;
            });
        }
    }
    // カード人間3を手札に戻す
    public void DownFieldImageHuman3() {
        // FieldImageHuman3がtrueだったらという条件をif文で書く
        if (BattleScript.FieldImageHuman3.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImageHuman3.SetActive(false);
                BattleScript.ImageHuman3.SetActive(true);
                jobFlag = false;
            });
        }
    }
    // カード悪魔を手札に戻す
    public void DownFieldImageDevil() {
        // FieldImageDevilがtrueだったらという条件をif文で書く
        if (BattleScript.FieldImageDevil.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImageDevil.SetActive(false);
                BattleScript.ImageDevil.SetActive(true);
                jobFlag = false;
            });
        }
    }
    // カード天使を手札に戻す
    public void DownFieldImageAngel() {
        // FieldImageAngelがtrueだったらという条件をif文で書く
        if (BattleScript.FieldImageAngel.activeSelf == true) {
            audioSource.PlayOneShot(cancel, 1.0F);
            DOVirtual.DelayedCall(0.17f, () => {
                BattleScript.FieldImageAngel.SetActive(false);
                BattleScript.ImageAngel.SetActive(true);
                jobFlag = false;
            });
        }
    }

    

}
