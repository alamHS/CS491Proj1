﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonClick : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject turnPage;
    public GameObject cover;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
<<<<<<< HEAD


    public AudioSource PIKA;
    public AudioClip pika;

    public int pageToDisplay = -1;
=======
    public int pageToDisplay;
>>>>>>> a68ac46f34ffa571d7dfc1642e978682d656000f

    void Start()
    {

        turnPage = GameObject.Find("ClickMe");
        turnPage.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //GAME OBject. active thing
        cover = GameObject.Find("Cover");
        cover.SetActive(true);



        page1 = GameObject.Find("Art1");
        page1.SetActive(false);

        page2 = GameObject.Find("Art2");
        page2.SetActive(false);

        page3 = GameObject.Find("Art3");
        page3.SetActive(false);
        pageToDisplay = 0;
    }

    public void OnButtonPressed(VirtualButtonBehaviour turn)
    {
        Debug.Log("Gotcha");
<<<<<<< HEAD
        cover.SetActive(false);
        page1.SetActive(true);
        PIKA.Play();
=======
        Debug.Log(pageToDisplay);
        if (pageToDisplay < 4 && pageToDisplay >= 0)
        {
            pageToDisplay = pageToDisplay + 1;
        }
        if(pageToDisplay == 0)
        {
            Debug.Log(pageToDisplay);
            cover.SetActive(true);
            page1.SetActive(false);
        }
        if (pageToDisplay == 1)
        {
            Debug.Log(pageToDisplay);
            page1.SetActive(true);
            cover.SetActive(false);
        }
        if(pageToDisplay == 2)
        {
            page1.SetActive(false);
            page2.SetActive(true);
        }
        if(pageToDisplay == 3)
        {
            page2.SetActive(false);
            page3.SetActive(true);
        }
      
>>>>>>> a68ac46f34ffa571d7dfc1642e978682d656000f
       

    }

    public void OnButtonReleased(VirtualButtonBehaviour turn)
    {

    }
    void Update()
    {

    }

}
