# EditorGoodies.Attributes

This package consists of some handy attributes that unity otherwise doest have,
please note this git Repo can be directly used in the package manager through the repo URL

## Usage

Make sure you are using the namespace EGAttributes before using the attribures.
```csharp
using EGAttributes;
```

### 1. Readonly Attribute

This attribute doesnt take any inputs and is pretty much can be used directly.

**Example**
```csharp
[ReadOnly] public bool TestBoolean = true;
```
![ReadOnly_Usage_Result](https://github.com/SuryaVamsiKK/EditorGoodies.Attributes/blob/main/Documentation/ReadOnlyUsageResualt.PNG?raw=true)


### 2. Hide

This attribute takes 2 inputs
*   **string** which should be the name of the vairable that is already present in the same class or a parent class.
*   **bool** which indicates is if the field itself is a editable or no even if it is displayed.

**Example**
```csharp
public bool showVariables;
[Hide("showVariables", true)] public bool testBoolean;
[Hide("showVariables", true)] public string testString;
[Hide("showVariables", false)] public int testInteger = 10;
[Hide("showVariables", false)] public float testFloat = 8.36f;
```
![Hide_Usage_Result](https://github.com/SuryaVamsiKK/EditorGoodies.Attributes/blob/main/Documentation/HideUsageResult.gif?raw=true)
