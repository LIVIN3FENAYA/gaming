using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sen5 : MonoBehaviour
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
  while(lf<0.3f){
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
      StartCoroutine(fill5());
       if(i==5)
       StartCoroutine(fill6());
       if(i==6)
      SceneManager.LoadScene(7);
}


    IEnumerator fill1(){
        progressBar.fillAmount=0f;
        progressBar1.fillAmount=0f;
        progressBar2.fillAmount=1f;
         
           scoreText.text="They are the vilgax ships";
           lf=0f;
            while(lf<0.45f){
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
         
           scoreText.text="DD call woody as an emergency";
           lf=0f;
            while(lf<0.5f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
IEnumerator fill3(){
        progressBar.fillAmount=0f;
        progressBar1.fillAmount=0f;
        progressBar2.fillAmount=1f;
         
           scoreText.text="Ok..............Got a message";
           lf=0f;
            while(lf<0.5f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
IEnumerator fill4(){
        progressBar.fillAmount=0f;
        progressBar2.fillAmount=0f;
        progressBar1.fillAmount=1f;
         
           scoreText.text="what?";
           lf=0f;
            while(lf<0.15f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
   IEnumerator fill5(){
        progressBar.fillAmount=0f;
        progressBar1.fillAmount=0f;
        progressBar2.fillAmount=1f;
         
           scoreText.text="(woody) You went to 'Master' without me.... I am angry";
           lf=0f;
            while(lf<0.75f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;} 
           IEnumerator fill6(){
        progressBar.fillAmount=0f;
        progressBar2.fillAmount=0f;
        progressBar1.fillAmount=1f;
         
           scoreText.text="Errr......patttti";
           lf=0f;
            while(lf<0.25f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}       
}
