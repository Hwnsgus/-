using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text allClearText;

    private bool isGame1Complete = false; // ���� �±� ���� ������
    private bool isGame2Complete = false; // ���� ���ſ� �ڵ��� ������
    private bool isGame3Complete = false; // ���� ������Ʈ ���ֱ�

    void Start()
    {
        if (allClearText != null)
            allClearText.gameObject.SetActive(false); // �ʱ� ���¿��� ��Ȱ��ȭ
    }

    // ��� ������ �������� Ȯ���ϴ� �޼���
    private void CheckAllGamesComplete()
    {
        if (isGame1Complete && isGame2Complete && isGame3Complete)
        {
            ShowAllClearText();
        }
    }

    // "All Clear!" UI�� ǥ��
    private void ShowAllClearText()
    {
        if (allClearText != null)
        {
            allClearText.gameObject.SetActive(true);
            allClearText.text = "All Clear!";
        }
    }

    // �� ���� �Ϸ� ���¸� ������Ʈ�ϴ� �޼���
    public void CompleteGame1()
    {
        isGame1Complete = true;
        CheckAllGamesComplete();
    }

    public void CompleteGame2()
    {
        isGame2Complete = true;
        CheckAllGamesComplete();
    }

    public void CompleteGame3()
    {
        isGame3Complete = true;
        CheckAllGamesComplete();
    }
}
