using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opponentAI : MonoBehaviour
{
    //Styr motståndarens beteende

    public fightManager FightManager;
    public defendHeadManager DefendHeadManager;
    public defendBodyManager DefendBodyManager;
    public player Opponent;
    public int guardAreaExtraLimit; //Gräns då motståndaren börjar skydda ett område mer

    private void Start()
    {
        FightManager = GetComponent<fightManager>();
        DefendHeadManager = GetComponentInChildren<defendHeadManager>();
        DefendBodyManager = GetComponentInChildren<defendBodyManager>();
    }

    public void getOpponentStart()
    {
        Opponent = FightManager.PlayerTwo;
       
    }

    //Kontrollerar om gräns för att skydda sig extra aktiveras
    public void defenceGuardPoints(player Opponent)
    {
        //Kontrollera om något område är under gränsen för extra guard

        //Debug.Log("Gräns Skydd: " + guardAreaExtraLimit * Opponent.headHealthStart / 100);

        if (Opponent.headHealthNow <= guardAreaExtraLimit * Opponent.headHealthStart/100)
        {
            //Debug.Log("Skydda Huvud");
            Opponent.guardHead = Opponent.guardHeadStatAfterLastFight + Opponent.guardFlexibleDuringFight;
            //Mindre skydd Kropp
            Opponent.guardBody = Opponent.guardBodyStatAfterLastFight - Opponent.guardFlexibleDuringFight;

            //Visualisera skydd
            DefendHeadManager.playerTwoExtraGuardHeadActive();
            DefendBodyManager.playerTwoExtraGuardBodyInactive();
        }

        if (Opponent.bodyHealthNow<= guardAreaExtraLimit * Opponent.bodyHealthStart / 100)
        {
            Debug.Log("Skydda Kropp");
            Opponent.guardBody = Opponent.guardBodyStatAfterLastFight + Opponent.guardFlexibleDuringFight;
            //Mindre skydd Huvud
            Opponent.guardHead = Opponent.guardHeadStatAfterLastFight - Opponent.guardFlexibleDuringFight;

            //Visualisera skydd
            DefendBodyManager.playerTwoExtraGuardActive();
            DefendHeadManager.playerTwoExtraGuardHeadInactive();
        }

        if (Opponent.headHealthNow <= guardAreaExtraLimit * Opponent.headHealthStart / 100 && Opponent.bodyHealthNow <= guardAreaExtraLimit * Opponent.bodyHealthStart / 100)
        {
            Debug.Log("Båda delarna lika utsatta");
            Opponent.guardBody = Opponent.guardBodyStatAfterLastFight;
            Opponent.guardHead = Opponent.guardHeadStatAfterLastFight;

            //Visualisera skydd
            DefendHeadManager.playerTwoExtraGuardHeadInactive();
            DefendBodyManager.playerTwoExtraGuardBodyInactive();
        }

        /*
        if (Opponent.headHealthNow >= guardAreaExtraLimit * Opponent.headHealthStart / 100)
        {
            //Visualisera skydd
            DefendHeadManager.playerTwoExtraGuardHeadInactive();
            //DefendBodyManager.playerTwoExtraGuardBodyInactive();
        }
        */
    }
}
