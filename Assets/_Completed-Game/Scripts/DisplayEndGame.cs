using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class DisplayEndGame
{
    private Text _finishGameLabel;

    public DisplayEndGame(GameObject endGame)
    {
        _finishGameLabel = endGame.GetComponentInChildren<Text>();
        _finishGameLabel.text = string.Empty;
    }

    public void GameOver(string name, Color color)
    {
        _finishGameLabel.text = $"Вы проиграли. Вас убил {name} {color} цвета";
    }
}
