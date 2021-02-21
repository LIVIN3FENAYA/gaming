using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ public GameObject Enemy_Explosionprefab;
public GameObject ELaserprefab;
    // Start is called before the first frame update
    public int a;
    public bool caneshoot;
    void Start()
    {  a=2;
        caneshoot=true;
    }
  
void Movement(){
    if(a==1){
 transform.Translate(Vector3.left*Time.deltaTime*1.5f);}
 if(a==2){
 transform.Translate(Vector3.down*Time.deltaTime*1.5f);}
 if(a==3){
 transform.Translate(Vector3.right*Time.deltaTime*1.5f);}
 if(a==4){
 transform.Translate(Vector3.up*Time.deltaTime*1.5f);}

if(transform.position.x>=3.9f){
     transform.position=new Vector3(3.89f,transform.position.y,0);
       a=Random.Range(1,3); 
}
else if(transform.position.x<=-3.9f) {
         transform.position=new Vector3(-3.89f,transform.position.y,0);
       a=Random.Range(2,5);
}
else if (transform.position.y<=0.5f){
          transform.position=new Vector3(transform.position.x,0.51f,0);
        a= Random.Range(3,5);} 
else if (transform.position.y>=1.8f){
     transform.position=new Vector3(transform.position.x,1.79f,0);
        a=Random.Range(1,4);
    }


}

public IEnumerator EnemyShoot(){
    yield return new WaitForSeconds(2.0f);
    caneshoot=true;
}
    // Update is called once per frame
    void Update()
    {
        Movement();
        if(caneshoot==true){
           StartCoroutine (EnemyShoot());
               Instantiate(ELaserprefab,transform.position,Quaternion.identity);
        caneshoot=false;
        }
    }
    
   void OnTriggerEnter2D(Collider2D other){
        UIManager  uiManager=GameObject.Find("Canvas").GetComponent<UIManager>();
    
       if(other.tag=="Player"){
               Destroy(this.gameObject);
               Instantiate(Enemy_Explosionprefab,transform.position,Quaternion.identity);
              Player player=other.GetComponent<Player>();
              player.Damage();
              if(uiManager!=null){
        uiManager.UpdateNScore(10);
    } if(uiManager!=null){
        uiManager.UpdateScore(10);
    } }
       
       if(other.tag=="laser"){
           Destroy(this.gameObject);
            Instantiate(Enemy_Explosionprefab,transform.position,Quaternion.identity);
            Destroy(other.gameObject);
             if(uiManager!=null){
        uiManager.UpdateScore(10);
    } }
       }
 
}
