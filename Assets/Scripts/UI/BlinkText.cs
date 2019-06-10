using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
    private Text blinkText;
    [SerializeField][Range(0,1)]
    private float speedTextBlink=1;
    
    // Start is called before the first frame update
    void Start()
    {
        blinkText = GetComponent<Text>();
        StartBlinking();
    }

    private void StartBlinking()
    {
        StopCoroutine(Blink());
        StartCoroutine(Blink());
    }

    private void StopBlinking()
    {
        StopCoroutine(Blink());
    }
    
    // Update is called once per frame
    IEnumerator Blink()
    {
        while (true)
        {
            switch (blinkText.color.a.ToString())
            {
                case "0":
                    blinkText.color = new Color(blinkText.color.r, blinkText.color.g, blinkText.color.b,1);
                    yield return new  WaitForSeconds(speedTextBlink);
                    break;
                case "1":
                    blinkText.color = new Color(blinkText.color.r, blinkText.color.g, blinkText.color.b,0);
                    yield return new  WaitForSeconds(0.7f);
                    break;
            }
        }   
    }
}
