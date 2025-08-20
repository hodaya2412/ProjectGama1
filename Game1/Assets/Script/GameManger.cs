using UnityEngine;

public class GameManger : MonoBehaviour
{
    GameObject [] target;
    bool hasWon = false;
    void Start()
    {
        
    }


    void Update()
    {
        if (!hasWon)
        {
            target = GameObject.FindGameObjectsWithTag("Target");

            if (target.Length == 0)
            {
                PlayerWin();
            }

        }
    }
    void PlayerWin()
    {
        hasWon = true;
        Debug.Log("Congratulations, you won!");
    }
    
}
