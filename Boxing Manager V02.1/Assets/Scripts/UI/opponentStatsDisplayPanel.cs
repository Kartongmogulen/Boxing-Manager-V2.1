using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opponentStatsDisplayPanel : MonoBehaviour
{
    //Visar info om motst�ndaren i meny

    public GameObject fightScriptsGO;
    public GameObject playerListRandomGO;
    public GameObject opponentListRankedGO;
    //public GameObject playerListFixedGO;
    public player Opponent;

    public Text nameOpponentText;
    public Text fightStyleText;
    public Text accuracyText;
    public Text StrengthText;
    public Text knockDownText;
    public Text BodySnatcherText;
    public Text guardHeadText;
    public Text guardBodyText;
    public Text HealthHeadText;
    public Text HealthBodyText;
    public Text staminaHealthMaxText;
    public Text staminaRecoveryHealthText;

    /*
    private void Start()
    {
        Opponent = fightScriptsGO.GetComponent<fightManager>().opponentListRandomGO.PlayerList[fightScriptsGO.GetComponent<fightManager>().opponentIndex];
        nameOpponentText.text = "Name: " + Opponent.name;
        fightStyleText.text = "Fightstyle: " + Opponent.fightStyleNow;
        accuracyText.text = "Accuracy: " + Opponent.accuracy;
        StrengthText.text = "Strength: " + Opponent.strength;
        knockDownText.text = "Knockdown: " + Opponent.knockdownChance;
        BodySnatcherText.text = "Bodysnatcher: " + Opponent.crossStaminaRecoveryDamageBody;
        guardHeadText.text = "Guard (Head): " + Opponent.guardHead;
        guardBodyText.text = "Guard (Body): " + Opponent.guardBody;
        HealthHeadText.text = "Health (Head): " + Opponent.headHealthStart;
        HealthBodyText.text = "Health (Body): " + Opponent.bodyHealthStart;
        staminaHealthMaxText.text = "Stamina, Max: " + Opponent.staminaHealthStart;
        staminaRecoveryHealthText.text = "Stamina, Recovery: " + Opponent.staminaRecoveryBetweenRounds;
    }
    */

    public void updateOpponent()
    {
        Opponent = fightScriptsGO.GetComponent<fightManager>().opponentListGO.PlayerList[fightScriptsGO.GetComponent<fightManager>().opponentIndex];
        nameOpponentText.text = "Name: " + Opponent.name;
        fightStyleText.text = "Fightstyle: " + Opponent.fightStyleNow;
        accuracyText.text = "Accuracy: " + Opponent.accuracy;
        StrengthText.text = "Strength: " + Opponent.strength;
        knockDownText.text = "Knockdown: " + Opponent.knockdownChance;
        BodySnatcherText.text = "Bodysnatcher: " + Opponent.crossStaminaRecoveryDamageBody;
        guardHeadText.text = "Guard (Head): " + Opponent.guardHead;
        guardBodyText.text = "Guard (Body): " + Opponent.guardBody;
        HealthHeadText.text = "Health (Head): " + Opponent.headHealthStart;
        HealthBodyText.text = "Health (Body): " + Opponent.bodyHealthStart;
        staminaHealthMaxText.text = "Stamina, Max: " + Opponent.staminaHealthStart;
        staminaRecoveryHealthText.text = "Stamina, Recovery: " + Opponent.staminaRecoveryBetweenRounds;
    }

    public void updateOpponentRandom(int index)
    {
        Opponent = playerListRandomGO.GetComponent<playerList>().PlayerList[index].GetComponent<player>();
        nameOpponentText.text = "Name: " + Opponent.name;
        fightStyleText.text = "Fightstyle: " + Opponent.fightStyleNow;
        accuracyText.text = "Accuracy: " + Opponent.accuracy;
        StrengthText.text = "Strength: " + Opponent.strength;
        knockDownText.text = "Knockdown: " + Opponent.knockdownChance;
        BodySnatcherText.text = "Bodysnatcher: " + Opponent.crossStaminaRecoveryDamageBody;
        guardHeadText.text = "Guard (Head): " + Opponent.guardHead;
        guardBodyText.text = "Guard (Body): " + Opponent.guardBody;
        HealthHeadText.text = "Health (Head): " + Opponent.headHealthStart;
        HealthBodyText.text = "Health (Body): " + Opponent.bodyHealthStart;
        staminaHealthMaxText.text = "Stamina, Max: " + Opponent.staminaHealthStart;
        staminaRecoveryHealthText.text = "Stamina, Recovery: " + Opponent.staminaRecoveryBetweenRounds;
    }

    public void updateOpponentFixed(int index)
    {
        Opponent = fightScriptsGO.GetComponent<fightManager>().opponentListRankedGO.GetComponent<playerList>().PlayerList[index].GetComponent<player>();
        nameOpponentText.text = "Name: " + Opponent.name;
        fightStyleText.text = "Fightstyle: " + Opponent.fightStyleNow;
        accuracyText.text = "Accuracy: " + Opponent.accuracy;
        StrengthText.text = "Strength: " + Opponent.strength;
        knockDownText.text = "Knockdown: " + Opponent.knockdownChance;
        BodySnatcherText.text = "Bodysnatcher: " + Opponent.crossStaminaRecoveryDamageBody;
        guardHeadText.text = "Guard (Head): " + Opponent.guardHead;
        guardBodyText.text = "Guard (Body): " + Opponent.guardBody;
        HealthHeadText.text = "Health (Head): " + Opponent.headHealthStart;
        HealthBodyText.text = "Health (Body): " + Opponent.bodyHealthStart;
        staminaHealthMaxText.text = "Stamina, Max: " + Opponent.staminaHealthStart;
        staminaRecoveryHealthText.text = "Stamina, Recovery: " + Opponent.staminaRecoveryBetweenRounds;
    }

    public void updateChampion(int index)
    {
        Opponent = opponentListRankedGO.GetComponent<playerList>().PlayerList[index].GetComponent<player>();
        nameOpponentText.text = "Name: " + Opponent.name;
        fightStyleText.text = "Fightstyle: " + Opponent.fightStyleNow;
        accuracyText.text = "Accuracy: " + Opponent.accuracy;
        StrengthText.text = "Strength: " + Opponent.strength;
        knockDownText.text = "Knockdown: " + Opponent.knockdownChance;
        BodySnatcherText.text = "Bodysnatcher: " + Opponent.crossStaminaRecoveryDamageBody;
        guardHeadText.text = "Guard (Head): " + Opponent.guardHead;
        guardBodyText.text = "Guard (Body): " + Opponent.guardBody;
        HealthHeadText.text = "Health (Head): " + Opponent.headHealthStart;
        HealthBodyText.text = "Health (Body): " + Opponent.bodyHealthStart;
        staminaHealthMaxText.text = "Stamina, Max: " + Opponent.staminaHealthStart;
        staminaRecoveryHealthText.text = "Stamina, Recovery: " + Opponent.staminaRecoveryBetweenRounds;
    }
}