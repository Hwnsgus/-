using UnityEngine;

public class AnimalGrabInteractable : MonoBehaviour
{
    public AnimalManager animalManager; // AnimalManager ����

    // ������Ʈ�� Grab�Ǿ��� �� ȣ��
    public void OnGrab()
    {
        if (animalManager != null)
        {
            animalManager.OnAnimalGrabbed(gameObject);
        }
    }
}
