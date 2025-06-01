#if UNITY_RUNTIME
using UnityEngine;
#endif
namespace DSLApp1.Model
{
    public interface ICharacterDefinition
    {
        public ICharacterBaseState BaseState { get; }
#if UNITY_RUNTIME
        public ICharacterAssetSet AssetSet { get; }
#endif
        public BoardState BoardState { get; }
        
#if UNITY_RUNTIME
        GameObject GetCharacterPrefab(Transform transform);
#endif
    }
}