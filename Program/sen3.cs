using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sen3 : MonoBehaviour
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
        SceneManager.LoadScene(5);
}

    IEnumerator fill1(){
        progressBar.fillAmount=0f;
        progressBar1.fillAmount=0f;
        progressBar2.fillAmount=1f;
         
           scoreText.text="Hello I am DD your virtual space assistant";
           lf=0f;
            while(lf<0.6f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}

 IEnumerator fill2(){
        progressBar.fillAmount=0f;
        progressBar2.fillAmount=0f;
        progressBar1.fillAmount=1f;
         
           scoreText.text="Where is woody";
           lf=0f;
            while(lf<0.3f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
IEnumerator fill3(){
        progressBar.fillAmount=0f;
        progressBar1.fillAmount=0f;
        progressBar2.fillAmount=1f;
         
           scoreText.text="He is watching Power Rangers";
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
         
           scoreText.text="Hope I could join him";
           lf=0f;
            while(lf<0.35f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }i++;}
}
