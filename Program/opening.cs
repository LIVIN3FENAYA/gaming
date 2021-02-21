using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opening : MonoBehaviour
{       public GameObject Textprefab;
    // Start is called before the first frame update
     public IEnumerator Start()
     {     
         yield return new WaitForSeconds(2.2f);
        SceneManager.LoadScene(1);
     }




}
