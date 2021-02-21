using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newjoystick : MonoBehaviour
{ public GameObject dot;
public GameObject upv,downv,leftv,rightv;
public Player player=null;
public Collider2D collu,colld,colll,collr;
int i;
    // Start is called before the first frame update
    void Start()
    {
         i=0;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.touchCount>0){
           movement();
      }
    }
    public void shoot(){
        player.shoot();
    }
    void movement(){

  for( i=0;i<Input.touchCount;i++){
           
           Debug.Log(i);
           Vector3 touchPosition =new Vector3(Input.touches[i].position.x,Input.touches[i].position.y,0f);

           dot.transform.position=touchPosition;
 
        
if(collu.OverlapPoint(touchPosition)){
     player.move_up();
}
if(colld.OverlapPoint(touchPosition)){
     player.move_down();
}
if(colll.OverlapPoint(touchPosition)){
     player.move_left();
}
if(collr.OverlapPoint(touchPosition)){
     player.move_right();
}
        


        }
    }
}
