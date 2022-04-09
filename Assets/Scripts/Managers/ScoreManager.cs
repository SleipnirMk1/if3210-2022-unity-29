using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static float score;

    public static bool isZen = true;


    Text text;


    void Awake ()
    {
        text = GetComponent <Text> ();
        score = 0;
        
    }


    void Update ()
    {
        text.text = "Score: " + ((int)score);

        if (isZen)
        {
            score += Time.deltaTime;
        }
    }

    public static void AddScore (int delta) 
    {
        if (!isZen)
        {
            score += delta;
        }
    }
}
