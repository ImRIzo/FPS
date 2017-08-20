using UnityEngine;

public class WeaponSwitching : MonoBehaviour {
    public int SelectedWeapon = 0;

	void Start () {
        SelectWeapon();
	}


    void Update()
    {
        int PreviousSelectedWeapon = SelectedWeapon;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectedWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            SelectedWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            SelectedWeapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4)
        {
            SelectedWeapon = 3;
        }

        if (PreviousSelectedWeapon != SelectedWeapon)
        {
            SelectWeapon();
        }
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if(i == SelectedWeapon)
                gameObject.SetActive(true);
            else
                gameObject.SetActive(false);
            i++;
        }
    }
}
