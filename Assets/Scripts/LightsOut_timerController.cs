using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LightsOut_timerController : MonoBehaviour
{

    public Slider slider;
    public TextMeshProUGUI timer_text;
    public static float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowSliderValue();
    }

    public void Clicked()
    {
        timer = slider.value;
        SceneManager.LoadScene("LightsOut_Game");
        
    }


    public void ShowSliderValue()
    {
        string sliderMessage = "Timer value = " + slider.value;
        timer_text.text = sliderMessage;
    }

}
