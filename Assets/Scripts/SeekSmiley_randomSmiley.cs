using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Text;

public class SeekSmiley_randomSmiley : MonoBehaviour
{
    public Sprite[] images;
    public Image smiley;
    public static string correctSmiley;


    private void Awake()
    {
        int randomize = UnityEngine.Random.Range(0, images.Length);
        smiley.sprite = images[randomize];
        correctSmiley = smiley.sprite.name;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
