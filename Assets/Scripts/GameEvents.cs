using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static Action<bool> GameOver;

    public static Action<int> AddScores; 
    
    public static Action checkIfShapeCanBePlaced;

    public static Action MoveShapeToStartPosition;

    public static Action RequestNewShapes;

    public static Action SetShapeInactive;
}
