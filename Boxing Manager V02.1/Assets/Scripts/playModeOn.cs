using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playModeOn : MonoBehaviour
{
    //Scriptet ska vara aktiv när spelet ska köras i skarpt-läge

    public GameObject champChoosePanelGO;
    public player PlayerOne;


    private void Start()
    {
        GetComponent<rankingManager>().playerRanked = false;
        champChoosePanelGO.SetActive(false);


        //Player One. Nollstäl till grundinställningar
        PlayerOne.oneTwoUnlocked = false;
    }

}
