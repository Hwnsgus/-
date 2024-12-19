using UnityEngine;
using TMPro; // TextMeshPro ���ӽ����̽� �߰�

public class AnimalManager : MonoBehaviour
{
    public TMP_Text resultText; // Clear! �޽����� ǥ���� UI �ؽ�Ʈ
    private int totalAnimals = 6; // �� ���� ��
    private int removedAnimals = 0; // ����� ���� ��

    // ������ ����� �� ȣ��Ǵ� �޼���
    public void OnAnimalGrabbed(GameObject animal)
    {
        // ���� ������Ʈ�� ����
        Destroy(animal);
        removedAnimals++;

        // ��� ������ ������� Clear! �޽��� ǥ��
        if (removedAnimals >= totalAnimals)
        {
            resultText.text = "Clear!";
            Debug.Log("All animals are removed. Clear!");
            FindObjectOfType<GameManager>().CompleteGame3();
        }
    }
}
