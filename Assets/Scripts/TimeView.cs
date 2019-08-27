using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class TimeView : MonoBehaviour
    {
        [SerializeField] private Text Text;

        public void Updatetime(int num)
        {
            int big = num / 60;
            int small = num % 60;
            Text.text = $"{big}:{small}";
        }
    }
}