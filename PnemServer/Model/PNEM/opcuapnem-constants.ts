
export enum DataTypeIds {
   AccuracyClassEnumeration = 'i=3009',
   AccuracyDomainEnumeration = 'i=3010',
   PeClassEnumeration = 'i=3007',
   PeSubclassEnumeration = 'i=3008',
   AcPeDataType = 'i=3005',
   AcPpDataType = 'i=3006',
   EnergyStateInformationDataType = 'i=3003',
   PeVersionDataType = 'i=3004',
   StandbyModeTransitionDataType = 'i=3002'
}

export enum MethodIds {
   EnergyDevicePowerOffType_SwitchOffWOL = 'i=7009',
   EnergyMeasurementType_ResetEnergyCounter = 'i=7008',
   EnergyStandbyManagementType_EndPause = 'i=7006',
   EnergyStandbyManagementType_Lock_InitLock = 'i=7003',
   EnergyStandbyManagementType_Lock_RenewLock = 'i=7004',
   EnergyStandbyManagementType_Lock_ExitLock = 'i=7002',
   EnergyStandbyManagementType_Lock_BreakLock = 'i=7001',
   EnergyStandbyManagementType_StartPause = 'i=7005',
   EnergyStandbyManagementType_SwitchToEnergySavingMode = 'i=7007',
,
,
,

}

export enum ObjectTypeIds {
   IEnergyProfileD0Type = 'i=1011',
   IEnergyProfileE0Type = 'i=1007',
   IEnergyProfileE1Type = 'i=1008',
   IEnergyProfileE2Type = 'i=1009',
   IEnergyProfileE3Type = 'i=1010',
   EnergyDevicePowerOffType = 'i=1012',
   EnergyMeasurementType = 'i=1006',
   EnergySavingModesContainerType = 'i=1004',
   EnergySavingModeStatusType = 'i=1002',
   EnergySavingModeType = 'i=1003',
   EnergyStandbyManagementType = 'i=1005',
   PeServiceAccessPointType = 'i=1013'
}

export enum ReferenceTypeIds {
   HasEnergyMeasurement = 'i=4004',
   HasEnergyPowerOff = 'i=4005',
   HasEnergyStandbyManagement = 'i=4003',
   Represents = 'i=4002'
}

export enum VariableIds {
   AccuracyClassEnumeration_EnumValues = 'i=6111',
   AccuracyDomainEnumeration_EnumValues = 'i=6130',
   PeClassEnumeration_EnumValues = 'i=6015',
   PeSubclassEnumeration_EnumValues = 'i=6017'
}

export enum VariableTypeIds {
   MeasurementValueType = 'i=2002'
}

export class StatusCode {
   public static isGood(code?: number): boolean {
      return !code || (code & 0xD0000000) === 0;
   }
   public static isUncertain(code?: number): boolean {
      return (code ?? 0 & 0x40000000) !== 0;
   }
   public static isBad(code?: number): boolean {
      return (code ?? 0 & 0x80000000) !== 0;
   }
}