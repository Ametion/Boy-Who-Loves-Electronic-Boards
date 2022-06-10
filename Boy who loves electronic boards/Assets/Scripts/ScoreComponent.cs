using UnityEngine;
using UnityEngine.UI;

namespace Components
{
    public class ScoreComponent : MonoBehaviour
    {
        [SerializeField] private int score;
        [SerializeField] private Text scoreText;

        public int scoreBonus;

        public void ModifyScore()
        {
            score += scoreBonus;

            if (score >= 1000)
            {
                scoreText.text = ValueParser.Parse(score);
                return;
            }

            scoreText.text = score.ToString();
        }
    }
}