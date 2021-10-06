using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class DisplayEndGame
{
    private Text _finishGameLabel;

    public DisplayEndGame(Text finishGameLabel)
    {
        _finishGameLabel = finishGameLabel;
        _finishGameLabel.text = string.Empty;
    }

    public void GameOver()
    {
        _finishGameLabel.text = "Вы проиграли";
    }
}
