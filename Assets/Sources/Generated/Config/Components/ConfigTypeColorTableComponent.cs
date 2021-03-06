//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity typeColorTableEntity { get { return GetGroup(ConfigMatcher.TypeColorTable).GetSingleEntity(); } }
    public TypeColorTableComponent typeColorTable { get { return typeColorTableEntity.typeColorTable; } }
    public bool hasTypeColorTable { get { return typeColorTableEntity != null; } }

    public ConfigEntity SetTypeColorTable(System.Collections.Generic.List<UnityEngine.Color> newValue) {
        if (hasTypeColorTable) {
            throw new Entitas.EntitasException("Could not set TypeColorTable!\n" + this + " already has an entity with TypeColorTableComponent!",
                "You should check if the context already has a typeColorTableEntity before setting it or use context.ReplaceTypeColorTable().");
        }
        var entity = CreateEntity();
        entity.AddTypeColorTable(newValue);
        return entity;
    }

    public void ReplaceTypeColorTable(System.Collections.Generic.List<UnityEngine.Color> newValue) {
        var entity = typeColorTableEntity;
        if (entity == null) {
            entity = SetTypeColorTable(newValue);
        } else {
            entity.ReplaceTypeColorTable(newValue);
        }
    }

    public void RemoveTypeColorTable() {
        typeColorTableEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigEntity {

    public TypeColorTableComponent typeColorTable { get { return (TypeColorTableComponent)GetComponent(ConfigComponentsLookup.TypeColorTable); } }
    public bool hasTypeColorTable { get { return HasComponent(ConfigComponentsLookup.TypeColorTable); } }

    public void AddTypeColorTable(System.Collections.Generic.List<UnityEngine.Color> newValue) {
        var index = ConfigComponentsLookup.TypeColorTable;
        var component = CreateComponent<TypeColorTableComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTypeColorTable(System.Collections.Generic.List<UnityEngine.Color> newValue) {
        var index = ConfigComponentsLookup.TypeColorTable;
        var component = CreateComponent<TypeColorTableComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTypeColorTable() {
        RemoveComponent(ConfigComponentsLookup.TypeColorTable);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ConfigMatcher {

    static Entitas.IMatcher<ConfigEntity> _matcherTypeColorTable;

    public static Entitas.IMatcher<ConfigEntity> TypeColorTable {
        get {
            if (_matcherTypeColorTable == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.TypeColorTable);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherTypeColorTable = matcher;
            }

            return _matcherTypeColorTable;
        }
    }
}
