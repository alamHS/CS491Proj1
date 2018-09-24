using System.Collections;
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


    public AudioSource PIKA;
    public AudioClip pika;

    public int pageToDisplay = -1;

    void Start()
    {

        turnPage = GameObject.Find("ClickMe");
        turnPage.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //GAME OBject. active thing
        cover = GameObject.Find("Cover");
        cover.SetActive(true);



        page1 = GameObject.Find("Art1");
        page1.SetActive(false);
        /*page2 = GameObject.Find("Page2");
        page2.SetActive(false);

        page3 = GameObject.Find("Page3");
        page3.SetActive(false);*/

    }

    public void OnButtonPressed(VirtualButtonBehaviour turn)
    {
        Debug.Log("Gotcha");
        cover.SetActive(false);
        page1.SetActive(true);
        PIKA.Play();
       

    }

    public void OnButtonReleased(VirtualButtonBehaviour turn)
    {

    }
    void Update()
    {

    }

}
