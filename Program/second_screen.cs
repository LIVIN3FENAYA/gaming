using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class second_screen : MonoBehaviour
{
    public Image progressBar,progressBar1,progressBar2,progressBar3,progressBar4;
    public float lf;
    bool th;
    // Start is called before the first frame update
    void Start()
    {
        lf=0.00f;
        th=false;
         StartCoroutine(fill());
      //  StartCoroutine(LoadAsyncOperation());
    }


    // Update is called once per frame
      void Update()
    {
     
}

IEnumerator fill(){
  while(lf<1.0f){
          lf=lf+0.05f;
           progressBar.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }
    lf=0f;
     while(lf<1.0f){
          lf=lf+0.03f;
           progressBar1.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }
   
}

     

public void calltouched(){
  if(th==true){
    changescr();
  }
else
  StartCoroutine(touched());

}

 IEnumerator touched(){
   lf=0f;
 Debug.Log("hi");
 while(lf<1.0f){
          lf=lf+0.1f;
           progressBar2.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }
    lf=0f;
     while(lf<1.0f){
          lf=lf+0.03f;
           progressBar3.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }
    lf=0f;
     while(lf<1.0f){
          lf=lf+0.1f;
           progressBar4.fillAmount=lf;
           yield return new WaitForSeconds(0.1f);
           }
if(lf>1.0f)
  th=true;
 
        }

public void changescr(){
SceneManager.LoadScene(2);
}
public void movescr(){
  SceneManager.LoadScene(9);
}
}