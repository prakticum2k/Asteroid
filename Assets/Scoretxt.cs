using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text counterText;
    int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       showScore();
    }
    private void showScore ()
    {
        counterText.text = counter.ToString();
    }
    public void addScore()
    {
        counter++;
    }
}
