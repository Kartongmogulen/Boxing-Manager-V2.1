using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "simulateFightDataSO", menuName = "ScriptableObject / simulateFightDataSO")]
public class simulateFightDataSO : ScriptableObject
{
    public List<bool> playerOneWinner;
    public List<string> howTheFightEnded;
    public List<int> endedInRound;
    public List<string> fightStylePlayerOne;
    public List<string> fightStylePlayerTwo;
    public List<string> attackFocus;
}
