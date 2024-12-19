using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // UI ���ӽ����̽� �߰�

public class TargetChecker : MonoBehaviour
{
    public List<string> correctOrderTags = new List<string> { "Disk1", "Disk2", "Disk3", "Disk4", "Disk5" };
    private int currentIndex = 0; // ���� Ȯ�� ���� �±� �ε���

    // UI �ؽ�Ʈ ����
    public TMP_Text debugText;

    void OnTriggerEnter(Collider other)
    {
   
        if (other.CompareTag(correctOrderTags[currentIndex]))
        {
            UpdateDebugText($"Disk{correctOrderTags[currentIndex]} has been placed correctly.");
            currentIndex++;

            if (currentIndex >= correctOrderTags.Count)
            {
                UpdateDebugText("Clear!!!");
                ClearLevel();
                FindObjectOfType<GameManager>().CompleteGame1();
            }
        }
        else
        {
            UpdateDebugText("Wrong disk. Please check the order again!");
        }
    }

    void UpdateDebugText(string message)
    {
        Debug.Log($"UI ������Ʈ �õ�: {message}"); // ����� �޽��� �߰�
        if (debugText != null)
        {
            debugText.text = message;
        }
        else
        {
            Debug.LogError("DebugText�� ������� �ʾҽ��ϴ�!");
        }
    }


    void ClearLevel()
    {
        UpdateDebugText("Level Cleared!");
    }
}
