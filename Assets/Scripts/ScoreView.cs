using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private Text Text;

        public void UpdateScore()
        {
            Text.text = GameController.Instance.Score.ToString();
        }
        
    }
}