using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.down*Time.deltaTime*3.0f);
          if(transform.position.y<-1.50f){
                 Destroy(this.gameObject);
          }
    }
    void OnTriggerEnter2D(Collider2D other){
       if(other.tag=="Player"){
               Destroy(this.gameObject);
              sPlayer player=other.GetComponent<sPlayer>();
              if(player==null){
               Player player1=other.GetComponent<Player>();
               player1.Damage();}
              player.Damage();}
       
       
}
}
