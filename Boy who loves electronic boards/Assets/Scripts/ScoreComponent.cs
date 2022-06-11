using UnityEngine;
using UnityEngine.UI;

namespace Components
{
    public class ScoreComponent : MonoBehaviour
    {
        [SerializeField] private decimal score;
        [SerializeField] private Text scoreText;

        public int scoreBonus;

        public void ModifyScore()
        {
            score += scoreBonus;

            scoreText.text = ValueParser.Parse(score);
        }
    }
}