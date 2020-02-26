using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : ScriptableObject
{
    [SerializeField] private int initialScore=150;
    //score del nivel, vida
    [SerializeField] private int initialShootingPoints=0;
    //puntos a cargarse para ataques especiales
    [SerializeField] private int initialGamePoints = 0;
    //puntos totales del juego

    [NonSerialized] public int score;
    [NonSerialized] public int shootingPoints;
    [NonSerialized] public int gamePoints;

    public void UpdateScore(int multiplier) {
        score += initialScore * multiplier;
    }
    public void UpdatePoints(int multiplier) {
        shootingPoints += initialShootingPoints * multiplier;
    }
    public void UpdateGamePoints(int multiplier) {
        gamePoints += initialGamePoints * multiplier;
    }

}
[Serializable]
public class SerializableScoreData {
    private int score;
}
[Serializable]
public class SerializableShootingPoints {
    private int shootingPoints;
}
[Serializable]
public class SerializableGamePoints {
    private int gamePoints;
}

public class GameData : ScriptableObject
{
    [SerializeField] private State currentState;

    [NonSerialized] public State actualState;

    public void SaveState()
    {
        actualState = currentState;
    }
}
