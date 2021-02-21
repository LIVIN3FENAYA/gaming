using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sen1 : MonoBehaviour
{        public Image progressBar;
        public Text scoreText;
        float lf;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fill());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator fill(){
  while(lf<1.0f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }
           
    }

public void callfill1(){
    StartCoroutine(fill1());
}

    IEnumerator fill1(){
        progressBar.fillAmount=0f;
           scoreText.text="Let's check woody ,Hope he got success in his new experiment";
           lf=0f;
            while(lf<1.0f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }}
public void movescr(){
    SceneManager.LoadScene(3);
}

}
