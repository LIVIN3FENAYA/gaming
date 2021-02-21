using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick : MonoBehaviour
{
public Player player=null;
public bool touc=false;
public bool upv,downv,leftv,rightv;
    // Start is called before the first frame update
    void Start()
    {
        upv=false;
        downv=false;
        leftv=false;
        rightv=false;
        
    }

    // Update is called once per frame
    void Update()
    { 
          if(upv==true){
              player.move_up();
          }
          if(downv==true){
              player.move_down();
          }
          if(leftv==true){
              player.move_left();
          }
          if(rightv==true){
              player.move_right();
          }





    }
    public void up(){
        upv=true;
    }
    public void down(){
    downv=true;
    }
  public void left(){
        leftv=true;
    }
     public void right(){
        rightv=true;
    }
     public void lup(){
        upv=false;
    }
    public void ldown(){
    downv=false;
    }
  public void lleft(){
        leftv=false;
    }
     public void lright(){
        rightv=false;
    }

}
