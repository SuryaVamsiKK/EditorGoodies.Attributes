using UnityEditor;
using UnityEngine;

namespace EGAttributes
{
    [CustomPropertyDrawer(typeof(HideAttribute))]
    public class HidePropertyDrawer : PropertyDrawer
    {
        HideAttribute target => attribute as HideAttribute;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (CanShow(property))
            {
                EditorGUI.BeginDisabledGroup(!target.editable);
                EditorGUI.PropertyField(position, property, label, true);
                EditorGUI.EndDisabledGroup();
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float targetHeight = CanShow(property) ? EditorGUI.GetPropertyHeight(property, label) : -EditorGUIUtility.standardVerticalSpacing;
            return targetHeight;
        }

        private bool CanShow(SerializedProperty property)
        {
            bool enabled = true;
            string propertyPath = property.propertyPath;
            string conditionPath = propertyPath.Replace(property.name, target.boolName);
            SerializedProperty sourcePropertyValue = property.serializedObject.FindProperty(conditionPath);

            if (sourcePropertyValue != null)
            {
                enabled = sourcePropertyValue.boolValue;
            }
            else
            {
                Debug.LogWarning("Attempting to use a HideAttribute but no matching SourcePropertyValue found in object: <color=yellow>" + target.boolName + "</color>");
            }

            return enabled;
        }
    }
}
