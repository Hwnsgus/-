using System.Collections.Generic;
using UnityEngine;

public class TargetChecker : MonoBehaviour
{
    // ������ ����� �ϴ� �±� ���
    public List<string> correctOrderTags = new List<string> { "Disk1", "Disk2", "Disk3", "Disk4", "Disk5" };

    private int currentIndex = 0; // ���� Ȯ�� ���� �±� �ε���

    void OnTriggerEnter(Collider other)
    {
        // ���� ������Ʈ�� �±� Ȯ��
        if (other.CompareTag(correctOrderTags[currentIndex]))
        {
            Debug.Log($"���� {correctOrderTags[currentIndex]} ��(��) �ùٸ� ��ġ�� �����ϴ�.");
            currentIndex++;

            // ��� ������ ���� �� Ŭ���� ó��
            if (currentIndex >= correctOrderTags.Count)
            {
                Debug.Log("Ŭ����! ��� ������ �ùٸ� ������ �����ϴ�.");
                ClearLevel();
            }
        }
        else
        {
            Debug.Log("�߸��� �����Դϴ�. ������ �ٽ� Ȯ���ϼ���!");
            ResetProgress();
        }
    }

    void ClearLevel()
    {
        // Ŭ���� ���� ó�� (��: ���� ������ �̵�, �޽��� ��� ��)
        Debug.Log("���� Ŭ����!");
    }

    void ResetProgress()
    {
        // ���� �� ���� ��Ȳ �ʱ�ȭ
        Debug.Log("���� ��Ȳ�� �ʱ�ȭ�Ǿ����ϴ�.");
        currentIndex = 0;
    }
}
