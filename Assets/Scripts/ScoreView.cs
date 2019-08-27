using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private Text Text;

        public void SetScoreText(string text)
        {
            Text.text = text;
        }
    }
}