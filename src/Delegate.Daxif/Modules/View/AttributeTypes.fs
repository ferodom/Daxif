﻿module internal DG.Daxif.Modules.View.AttributeTypes
let convertionMap = 
  Map.ofList [
    "BigInt", ("int64","NumberCondition")
    "Boolean", ("bool", "BoolCondition")
    "CalendarRules", ("EntityCollection", "CollectionCondition")
    "Customer", ("System.Guid", "GuidCondition")
    "DateTime", ("System.DateTime", "DateTimeCondition")
    "Decimal", ("decimal", "NumberCondition")
    "Double", ("double", "NumberCondition")
    "EntityName", ("string", "StringCondition")
    "Integer", ("int", "NumberCondition")
    "Lookup", ("System.Guid", "GuidCondition")
    "ManagedProperty", ("BooleanManagedProperty", "BoolCondition")
    "Memo", ("string", "StringCondition")
    "Money", ("decimal", "NumberCondition")
    "Owner", ("System.Guid", "GuidCondition")
    "PartyList", ("EntityCollection", "CollectionCondition")
    "Picklist", ("OptionSetValue", "OptionCondition")
    "Uniqueidentifier", ("System.Guid", "GuidCondition")
    "String", ("string", "StringCondition")
    "State", ("int", "OptionCondition")
    "Status", ("int", "OptionCondition")
    "Uniqueidentifier", ("System.Guid", "GuidCondition")
    "Virtual", ("string", "StringCondition")
  ]
