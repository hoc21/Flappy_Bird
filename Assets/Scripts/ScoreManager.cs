using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Sprite[] digitSprites; // Mảng chứa sprite từ 0 đến 9
    private int score = 0;

    // Hàm này được gọi khi cần cập nhật điểm số
    public void UpdateScore(int newScore)
    {
        score = newScore;

        // Lấy mỗi chữ số trong điểm số
        char[] scoreDigits = score.ToString().ToCharArray();

        // Xóa các số hiện tại nếu có
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Hiển thị các sprite số tương ứng
        float offsetX = 0f;
        foreach (char digit in scoreDigits)
        {
            int digitValue = int.Parse(digit.ToString());
            GameObject digitObject = new GameObject("Digit");
            digitObject.transform.parent = transform;
            digitObject.transform.localPosition = new Vector3(offsetX, 0, 0);
            digitObject.AddComponent<SpriteRenderer>().sprite = digitSprites[digitValue];
            offsetX += 1f; // Dịch chuyển vị trí cho chữ số tiếp theo
        }
    }
}
