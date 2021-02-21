using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TShootPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 2f * Time.deltaTime);
    }

   void OnTriggerEnter2D(Collider2D other){
       if(other.tag=="Player"){
           Player player=other.GetComponent<Player>();
           if(player !=null){
             player.TShotUp();
           }
            sPlayer player1=other.GetComponent<sPlayer>();
           if(player1 !=null){
             player1.TShotUp();
           }
           Destroy(this.gameObject);
       }
   }

}
