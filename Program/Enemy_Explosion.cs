using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Explosion : MonoBehaviour
{
     public bool candestroy;
    // Start is called before the first frame update
    void Start()
    {
        candestroy=false;

       StartCoroutine(canDestroy());
    }
public IEnumerator canDestroy(){
    yield return new WaitForSeconds(4.0f);
    candestroy=true;
}
    // Update is called once per frame
    void Update()
    {      
        if(candestroy==true)
          Destroy(this.gameObject);
    }
}
