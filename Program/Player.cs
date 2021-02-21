using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject TLaserprefab;
    public GameObject Player_explosionprefab;
    public bool cantshot=false; 
    public GameObject Laserprefab;
    public int lives;
    void Start()
    {   lives=3;
        transform.position=new Vector3(0,-1,0);
       Application.targetFrameRate=1000;
    }

    // Update is called once per frame
    void Update()
    {        /* float hInput=Input.GetAxis("Horizontal");
                 transform.Translate(Vector3.left*Time.deltaTime*hInput);     
           
               float vInput=Input.GetAxis("Vertical");
               transform.Translate(Vector3.up*Time.deltaTime*vInput);*/

     // Movement();
   
    
    }
    void Movement(){
       

    if(transform.position.x>3.9f){
        transform.position=new Vector3(3.9f,transform.position.y,0);
    }
     if(transform.position.x<-3.9f){
        transform.position=new Vector3(-3.9f,transform.position.y,0);
    }
     if(transform.position.y>1.0f){
        transform.position=new Vector3(transform.position.x,1.0f,0);
    }
     if(transform.position.y<-1.2f){
        transform.position=new Vector3(transform.position.x,-1.2f,0);
    }
    if(Input.GetKeyDown(KeyCode.Space)){
          if (cantshot==true)
          Instantiate(TLaserprefab,transform.position,Quaternion.identity);
          else
        Instantiate(Laserprefab,transform.position,Quaternion.identity);
    }
    }
public void TShotUp(){

    cantshot=true;
    StartCoroutine(TShotDown());
}
public IEnumerator TShotDown(){
    yield return new WaitForSeconds(5.0f);
    cantshot=false;
}
public void Damage(){
    lives--;
  UIManager  uiManager=GameObject.Find("Canvas").GetComponent<UIManager>();
    if(uiManager!=null){
        uiManager.UpdateLives(lives);
    }
    
    if(lives==0){
    Instantiate(Player_explosionprefab,transform.position,Quaternion.identity);
    Destroy(this.gameObject); 
     SceneManager.LoadScene(13);}
    
}
public void move_up(){
   transform.Translate(Vector3.up*Time.deltaTime);
}
public void move_down(){
 transform.Translate(Vector3.down*Time.deltaTime);
}
public void move_right(){
    transform.Translate(Vector3.right*Time.deltaTime);
}
public void move_left(){
    transform.Translate(Vector3.left*Time.deltaTime);
}
public void shoot(){
 if (cantshot==true)
          Instantiate(TLaserprefab,transform.position,Quaternion.identity);
          else
        Instantiate(Laserprefab,transform.position,Quaternion.identity);
}
}

