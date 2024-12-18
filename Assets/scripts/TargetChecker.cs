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
            UpdateDebugText($"���� {correctOrderTags[currentIndex]} ��(��) �ùٸ� ��ġ�� �����ϴ�.");
            currentIndex++;

            if (currentIndex >= correctOrderTags.Count)
            {
                UpdateDebugText("Ŭ����! ��� ������ �ùٸ� ������ �����ϴ�.");
                ClearLevel();
            }
        }
        else
        {
            UpdateDebugText("�߸��� �����Դϴ�. ������ �ٽ� Ȯ���ϼ���!");
        }
    }

    void UpdateDebugText(string message)
    {
        // UI �ؽ�Ʈ�� �޽��� ǥ��
        if (debugText != null)
        {
            debugText.text = message;
        }
    }

    void ClearLevel()
    {
        UpdateDebugText("���� Ŭ����!");
    }
}
