using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sen2 : MonoBehaviour
{
    // Start is called before the first frame update
    int pas;
    int i=0;
    public Text pa;
    void Start()
    {
        pas=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(i==1){
         pa.text="*";
        }
        else if(i==2){
            pa.text="**";
        }
        else if(i==3){
            pa.text="***";
        }
        else if(i==4){
                if(pas==1303){
                    SceneManager.LoadScene(4);
                }
                       
                  else    {SceneManager.LoadScene(3);}
                  Debug.Log(pas);
        }
    }
    public void call_1(){
            i++;
            pas=pas*10+1;
    }
    public void call_2(){
         i++;
         pas=pas*10+2;
    }
    public void call_3(){
         i++;
         pas=pas*10+3;
    }
    public void call_4(){
         i++;
         pas=pas*10+4;
    }

    public void call_5(){
         i++;
         pas=pas*10+5;
    }
    public void call_6(){
        i++;
        pas=pas*10+6;
    }
    public void call_7(){
         i++;
         pas=pas*10+7;
    }

    public void call_8(){
         i++;
         pas=pas*10+8;
    }
    public void call_9(){
         i++;
         pas=pas*10+9;
    }

    public void call_0(){
         i++;
         pas=pas*10+0;
    }
}
