using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sen4 : MonoBehaviour
{        public Image progressBar,progressBar1,progressBar2;
        public Text scoreText;
        float lf;
        int i;
    // Start is called before the first frame update
    void Start()
    {   i=0;
        StartCoroutine(fill());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator fill(){
  while(lf<0.5f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }
           
    }

public void callfill1(){
    if(i==0)
    StartCoroutine(fill1());
    if(i==1)
     StartCoroutine(fill2());
     if(i==2)
     StartCoroutine(fill3());
     if(i==3)
     StartCoroutine(fill4());
     if(i==4)
      SceneManager.LoadScene(6);
}


    IEnumerator fill1(){
        progressBar.fillAmount=0f;
        progressBar1.fillAmount=0f;
        progressBar2.fillAmount=1f;
         
           scoreText.text="He wanted to watch it in big screen";
           lf=0f;
            while(lf<0.5f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
public void movescr(){
    SceneManager.LoadScene(3);
}

 IEnumerator fill2(){
        progressBar.fillAmount=0f;
        progressBar2.fillAmount=0f;
        progressBar1.fillAmount=1f;
         
           scoreText.text="So";
           lf=0f;
            while(lf<0.1f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
IEnumerator fill3(){
        progressBar.fillAmount=0f;
        progressBar1.fillAmount=0f;
        progressBar2.fillAmount=1f;
         
           scoreText.text="He went to main station";
           lf=0f;
            while(lf<0.4f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
IEnumerator fill4(){
        progressBar.fillAmount=0f;
        progressBar2.fillAmount=0f;
        progressBar1.fillAmount=1f;
         
           scoreText.text="He left the ship to watch power rangers!!! ";
           lf=0f;
            while(lf<0.6){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
}
