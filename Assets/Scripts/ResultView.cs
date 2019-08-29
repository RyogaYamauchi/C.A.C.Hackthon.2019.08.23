using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ResultView : MonoBehaviour
    {
       [SerializeField] private Text text;
       [SerializeField] private Image image;
       [SerializeField] private GameObject obj;

       public void Show()
       {
           obj.SetActive(true);
           OnGameOver();
       }

       private void OnGameOver()
       {
           text.text = $"獲得したカロリー　：　{GameController.Instance.Score.ToString()}\n" ;
           var score = GameController.Instance.Score;
           if (score == 0)
           {
               text.text += "逆に動いて痩せちゃったかもね";
           }
           else if (score > 0 && score < 100)
           {
               text.text += "まだ動いてるからもっと飲んでも大丈夫";
           }
           else if (score > 100 && score < 500)
           {
               text.text += "ちょっとラーメン半分いくらいのカロリー取ったんじゃない？";
           }
           else if (score > 500 && score < 1000)
           {
               text.text += "もう普通のタピオカと同じくらいのカロリーだね、普通の方が鵜いいんじゃない？";
           }
       }

    }
}