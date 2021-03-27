using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "ScriptableObjects/BuildingTypeList")]
    public class BuildingTypeListSO : ScriptableObject
    {
        [FormerlySerializedAs("buildings")] public List<BuildingTypeSO> list;
    }
}

