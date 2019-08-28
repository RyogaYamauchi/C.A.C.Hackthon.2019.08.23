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
            string bigStr = "";
            string smallStr = "";
            bigStr = big.ToString();
            smallStr = small.ToString();
            if (small < 10)
            {
                smallStr = $"0{small.ToString()}";
            }

            Text.text = bigStr + ":" + smallStr;
        }
    }
}