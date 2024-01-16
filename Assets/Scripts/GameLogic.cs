using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public ScoreManager scoreManager;

    void Start()
    {
        // Cập nhật điểm số (ví dụ: 123)
        scoreManager.UpdateScore(0);
    }
}
