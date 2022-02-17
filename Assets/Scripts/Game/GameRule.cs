using UnityEngine;
using UnityEngine.Events;


public class GameRule : MonoBehaviour
{

   [SerializeField] private Cube cube1;
   [SerializeField] private Cube cube2;
   [SerializeField] private ScoreCounter scoreCounterPlayer1;
   [SerializeField] private ScoreCounter scoreCounterPlayer2;

   public UnityEvent player1WinEvent;
   public UnityEvent player2WinEvent;


   private int numberOfGame = 0;



   public void CompareResult()
   {
      if (numberOfGame % 2 == 0)
      {
         AddScorePlayer1();
      }
      else
      {
         AddScorePlayer2();
      }

      numberOfGame++;
   }

   public void AddScorePlayer1()
   {
      scoreCounterPlayer1.Add(cube1.CurrentSideAbove.Number);
      scoreCounterPlayer1.Add(cube2.CurrentSideAbove.Number);
      player1WinEvent?.Invoke();
   }
   public void AddScorePlayer2()
   {
      scoreCounterPlayer2.Add(cube1.CurrentSideAbove.Number);
      scoreCounterPlayer2.Add(cube2.CurrentSideAbove.Number);
      player2WinEvent?.Invoke();
   }
}
