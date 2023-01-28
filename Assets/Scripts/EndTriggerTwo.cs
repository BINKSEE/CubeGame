using UnityEngine;

public class EndTriggerTwo : MonoBehaviour{

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
