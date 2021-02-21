using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{  public int ecount=3;
 public GameObject Enemy_prefab,Master_prefab,pprefab;
   public int thresholdscore=0;
   int i;
    // Start is called before the first frame update
    void Start()
    { i=0;
         spawn();
    }

    // Update is called once per frame
    void Update()
    {   UIManager  uiManager=GameObject.Find("Canvas").GetComponent<UIManager>();
           if(thresholdscore<=uiManager.score && thresholdscore>0 && i<1){
           spawn();
             
        }
        if(uiManager.score==250 && i==0){
          i++;
          Instantiate(Master_prefab,new Vector3(Random.Range(-3.9f,3.9f),1.8f,0),Quaternion.identity);
        }
        
    }
    void spawn(){
         thresholdscore=thresholdscore+ecount*10;
              for(int i=0;i<ecount;i++)
              Instantiate(Enemy_prefab,new Vector3(Random.Range(-3.9f,3.9f),1.8f,0),Quaternion.identity);
                ecount++;
           if(thresholdscore%60==0)
               Instantiate(pprefab,new Vector3(Random.Range(-3.9f,3.9f),1.8f,0),Quaternion.identity);  
    }
}
