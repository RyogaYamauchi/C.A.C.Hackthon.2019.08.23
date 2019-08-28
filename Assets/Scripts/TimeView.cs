using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class TimeView : MonoBehaviour
    {
        private void Start()
        {
            StartTime();
        }
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
        public void StartTime()
        {
            StartCoroutine(CountDownTime());
        }
        public IEnumerator CountDownTime()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.0f);
                GameController.Instance.Time++;
                Updatetime(GameController.Instance.Time);
                if (GameController.Instance.Time % 3 ==0)
                {
                    StartCoroutine(SpawnTapioka());
                }
            }
        }
        private IEnumerator SpawnTapioka()
        {
            var obj = Resources.LoadAsync("Tapioka");
            yield return obj;
            var instance = (GameObject) Instantiate(obj.asset,
                new Vector3(0.5f,1,-6.8f), Quaternion.identity);
        }
    }
}