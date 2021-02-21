using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sen6 : MonoBehaviour
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

    public void callfill1(){
    if(i==1)
    SceneManager.LoadScene(8);}
    IEnumerator fill(){
  while(lf<0.4f){
          lf=lf+0.02f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }
           
   i++; }


}
