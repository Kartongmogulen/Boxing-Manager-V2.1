using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playModeOn : MonoBehaviour
{
    //Scriptet ska vara aktiv n�r spelet ska k�ras i skarpt-l�ge

    public GameObject champChoosePanelGO;
    public player PlayerOne;


    private void Start()
    {
        GetComponent<rankingManager>().playerRanked = false;
        champChoosePanelGO.SetActive(false);


        //Player One. Nollst�l till grundinst�llningar
        PlayerOne.oneTwoUnlocked = false;
    }

}
