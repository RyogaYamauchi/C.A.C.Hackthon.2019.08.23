using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class DestoryWithTime4 : MonoBehaviour
    {
        private int time = 0;
        private int limitTime = 4;
        private void Start()
        {
            StartCoroutine(Count10time());
        }

        private IEnumerator Count10time()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.0f);
                time++;
                if (time > limitTime)
                {
                    gameObject.SetActive(false);
                    yield break;
                }
            }
        }
    }
}