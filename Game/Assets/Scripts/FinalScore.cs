using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text FinalScoreText;
    void Start()
    {
        int FinalScore = ScoreAmount.Instance.score;
        FinalScoreText.text = "최종 점수 :   " + FinalScore.ToString();
    }
}
