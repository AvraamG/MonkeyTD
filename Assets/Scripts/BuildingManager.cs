using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using ScriptableObjects;
using UnityEngine;

public class BuildingManager : MonoBehaviour {
    
   // [SerializeField] [CanBeNull] private Transform m_mouseVisualTransform=null;
    private Camera m_cameraMain;
    private BuildingTypeListSO m_buildingTypeList;
    private BuildingTypeSO m_currentBuildingType;
   
    // Start is called before the first frame update
    void Start() {
        m_cameraMain=Camera.main;
        m_buildingTypeList=Resources.Load<BuildingTypeListSO>(nameof(BuildingTypeListSO));
        m_currentBuildingType = m_buildingTypeList.list[0];
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(m_currentBuildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetMouseWorldPosition() {
        Vector3 mouseWorldPosition = m_cameraMain.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        return mouseWorldPosition;
    }
    
    
}
