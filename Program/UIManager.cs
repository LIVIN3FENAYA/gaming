using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] lives;
    public Image livesDisplay;
    public Text scoreText;
    public int score=0;
    public int nscore=0;



   public void UpdateLives(int currentLives)
    {
              livesDisplay.sprite=lives[currentLives];   
    }

    // Update is called once per frame
    public void UpdateScore(int s)
    {
         score +=s;
         scoreText.text="Score: "+(score-nscore);
    }
    public void UpdateNScore(int s)
    {
         nscore +=s;
}
}
