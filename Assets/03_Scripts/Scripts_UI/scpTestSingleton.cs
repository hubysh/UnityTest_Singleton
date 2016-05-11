using UnityEngine;
using System.Collections;

public class scpTestSingleton : MonoBehaviour
{
	bool isActive = true;

	void TestSingleton()
	{
		if (isActive)
		{
			Singleton.Instance.txtResult.SetActive(isActive);
			isActive = false;
		}
		else
		{
			Singleton.Instance.txtResult.SetActive(isActive);
			isActive = true;
		}
		
	}
}
