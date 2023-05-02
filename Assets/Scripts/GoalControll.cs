using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalControll : MonoBehaviour
{

    public TMP_Text MyScoreText;
    private int ScoreNum;
    private DefaultPosition[] defaultPositions;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "" + 0;
        defaultPositions = FindObjectsOfType<DefaultPosition>();
    }



    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Mic")
        {

            ScoreNum += 1;
            MyScoreText.text = "" + ScoreNum;
            for (int i = 0; i < defaultPositions.Length; i++)
            {
                defaultPositions[i].ResetToDefaultPosition();

            }
            col.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Pause();
        }
    }

    public float pauseTime = 2f;

    public void Pause()
    {
        Time.timeScale = 0f; // Zastaven� �asu v h�e
        StartCoroutine(ResumeAfterDelay()); // Spu�t�n� Coroutine pro obnoven� hry po 2 sekund�ch
    }

    IEnumerator ResumeAfterDelay()
    {
        yield return new WaitForSecondsRealtime(pauseTime); // �ek�n� po dobu zastaven� hry
        Time.timeScale = 1f; // Obnoven� �asu v h�e
    }
}
