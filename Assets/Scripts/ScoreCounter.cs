using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static float score;
    public Text ScoreText;
    public static float totalscore;


    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        

    }

    void FixedUpdate()
    {
        score = Mathf.Ceil(Time.timeSinceLevelLoad / 2);
        totalscore = score + PlusTen.plus;
        ScoreText.text = totalscore.ToString();
    }

    // Update is called once per frame
    public void Update()
    {
        

    }

  

   
}
