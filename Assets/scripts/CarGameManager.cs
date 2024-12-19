using UnityEngine;
using TMPro;

public class CarGameManager : MonoBehaviour
{
    public TMP_Text resultText; // Clear! �޽����� ǥ���� UI �ؽ�Ʈ
    private string heaviestCarTag = "Car6"; // ���� ���ſ� �ڵ����� �±�

    public void OnCarButtonClicked(string carTag)
    {
        if (carTag == heaviestCarTag)
        {
            resultText.text = "Clear!"; // ������ �� �޽��� ǥ��
            Debug.Log("You guessed the heaviest car!");
            FindObjectOfType<GameManager>().CompleteGame2();
        }
        else
        {
            resultText.text = "Try Again!"; // ������ �� �޽��� ǥ��
            Debug.Log("Wrong car. Try again.");
        }
    }
}
