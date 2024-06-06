/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.DI;

namespace Opc.Ua.PnEm
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint AccuracyClassEnumeration = 3009;

        /// <remarks />
        public const uint AccuracyDomainEnumeration = 3010;

        /// <remarks />
        public const uint PeClassEnumeration = 3007;

        /// <remarks />
        public const uint PeSubclassEnumeration = 3008;

        /// <remarks />
        public const uint AcPeDataType = 3005;

        /// <remarks />
        public const uint AcPpDataType = 3006;

        /// <remarks />
        public const uint EnergyStateInformationDataType = 3003;

        /// <remarks />
        public const uint PeVersionDataType = 3004;

        /// <remarks />
        public const uint StandbyModeTransitionDataType = 3002;
    }
    #endregion

    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint EnergyDevicePowerOffType_SwitchOffWOL = 7009;

        /// <remarks />
        public const uint EnergyMeasurementType_ResetEnergyCounter = 7008;

        /// <remarks />
        public const uint EnergyStandbyManagementType_EndPause = 7006;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_InitLock = 7003;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_RenewLock = 7004;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_ExitLock = 7002;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_BreakLock = 7001;

        /// <remarks />
        public const uint EnergyStandbyManagementType_StartPause = 7005;

        /// <remarks />
        public const uint EnergyStandbyManagementType_SwitchToEnergySavingMode = 7007;

        /// <remarks />
        public const string EnergyDevicePowerOffType_SwitchOffWOLMethodType = "";

        /// <remarks />
        public const string EnergyStandbyManagementType_EndPauseMethodType = "";

        /// <remarks />
        public const string EnergyStandbyManagementType_StartPauseMethodType = "";

        /// <remarks />
        public const string EnergyStandbyManagementType_SwitchToEnergySavingModeMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes = 5016;

        /// <remarks />
        public const uint EnergyStandbyManagementType_EnergySavingModes = 5018;

        /// <remarks />
        public const uint EnergyStandbyManagementType_EnergySavingModeStatus = 5017;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock = 5020;

        /// <remarks />
        public const uint StandbyModeTransitionDataType_Encoding_DefaultBinary = 5001;

        /// <remarks />
        public const uint StandbyModeTransitionDataType_Encoding_DefaultXml = 5002;

        /// <remarks />
        public const uint StandbyModeTransitionDataType_Encoding_DefaultJson = 5003;

        /// <remarks />
        public const uint EnergyStateInformationDataType_Encoding_DefaultBinary = 5004;

        /// <remarks />
        public const uint EnergyStateInformationDataType_Encoding_DefaultXml = 5005;

        /// <remarks />
        public const uint EnergyStateInformationDataType_Encoding_DefaultJson = 5006;

        /// <remarks />
        public const uint PeVersionDataType_Encoding_DefaultBinary = 5007;

        /// <remarks />
        public const uint PeVersionDataType_Encoding_DefaultXml = 5008;

        /// <remarks />
        public const uint PeVersionDataType_Encoding_DefaultJson = 5009;

        /// <remarks />
        public const uint AcPeDataType_Encoding_DefaultBinary = 5010;

        /// <remarks />
        public const uint AcPeDataType_Encoding_DefaultXml = 5011;

        /// <remarks />
        public const uint AcPeDataType_Encoding_DefaultJson = 5012;

        /// <remarks />
        public const uint AcPpDataType_Encoding_DefaultBinary = 5013;

        /// <remarks />
        public const uint AcPpDataType_Encoding_DefaultXml = 5014;

        /// <remarks />
        public const uint AcPpDataType_Encoding_DefaultJson = 5015;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint IEnergyProfileD0Type = 1011;

        /// <remarks />
        public const uint IEnergyProfileE0Type = 1007;

        /// <remarks />
        public const uint IEnergyProfileE1Type = 1008;

        /// <remarks />
        public const uint IEnergyProfileE2Type = 1009;

        /// <remarks />
        public const uint IEnergyProfileE3Type = 1010;

        /// <remarks />
        public const uint EnergyDevicePowerOffType = 1012;

        /// <remarks />
        public const uint EnergyMeasurementType = 1006;

        /// <remarks />
        public const uint EnergySavingModesContainerType = 1004;

        /// <remarks />
        public const uint EnergySavingModeStatusType = 1002;

        /// <remarks />
        public const uint EnergySavingModeType = 1003;

        /// <remarks />
        public const uint EnergyStandbyManagementType = 1005;

        /// <remarks />
        public const uint PeServiceAccessPointType = 1013;
    }
    #endregion

    #region ReferenceType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypes
    {
        /// <remarks />
        public const uint HasEnergyMeasurement = 4004;

        /// <remarks />
        public const uint HasEnergyPowerOff = 4005;

        /// <remarks />
        public const uint HasEnergyStandbyManagement = 4003;

        /// <remarks />
        public const uint Represents = 4002;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint AccuracyClassEnumeration_EnumValues = 6111;

        /// <remarks />
        public const uint AccuracyDomainEnumeration_EnumValues = 6130;

        /// <remarks />
        public const uint PeClassEnumeration_EnumValues = 6015;

        /// <remarks />
        public const uint PeSubclassEnumeration_EnumValues = 6017;

        /// <remarks />
        public const uint MeasurementValueType_AccuracyClass = 6020;

        /// <remarks />
        public const uint MeasurementValueType_AccuracyDomain = 6019;

        /// <remarks />
        public const uint MeasurementValueType_EngineeringUnits = 6021;

        /// <remarks />
        public const uint MeasurementValueType_PeMeasurementID = 6018;

        /// <remarks />
        public const uint MeasurementValueType_ValueBeforeReset = 6022;

        /// <remarks />
        public const uint IEnergyProfileD0Type_DcCurrent = 6102;

        /// <remarks />
        public const uint IEnergyProfileD0Type_DcCurrent_AccuracyClass = 6103;

        /// <remarks />
        public const uint IEnergyProfileD0Type_DcCurrent_AccuracyDomain = 6104;

        /// <remarks />
        public const uint IEnergyProfileD0Type_DcCurrent_EngineeringUnits = 6105;

        /// <remarks />
        public const uint IEnergyProfileD0Type_DcCurrent_PeMeasurementID = 6168;

        /// <remarks />
        public const uint IEnergyProfileE0Type_AcCurrent = 6060;

        /// <remarks />
        public const uint IEnergyProfileE0Type_AcCurrent_AccuracyClass = 6061;

        /// <remarks />
        public const uint IEnergyProfileE0Type_AcCurrent_AccuracyDomain = 6062;

        /// <remarks />
        public const uint IEnergyProfileE0Type_AcCurrent_EngineeringUnits = 6063;

        /// <remarks />
        public const uint IEnergyProfileE0Type_AcCurrent_PeMeasurementID = 6153;

        /// <remarks />
        public const uint IEnergyProfileE1Type_AcActivePowerTotal = 6064;

        /// <remarks />
        public const uint IEnergyProfileE1Type_AcActivePowerTotal_AccuracyClass = 6065;

        /// <remarks />
        public const uint IEnergyProfileE1Type_AcActivePowerTotal_AccuracyDomain = 6066;

        /// <remarks />
        public const uint IEnergyProfileE1Type_AcActivePowerTotal_EngineeringUnits = 6067;

        /// <remarks />
        public const uint IEnergyProfileE1Type_AcActivePowerTotal_PeMeasurementID = 6154;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalExportLp = 6076;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_AccuracyClass = 6077;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_AccuracyDomain = 6078;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_EngineeringUnits = 6079;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_PeMeasurementID = 6157;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalImportLp = 6072;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_AccuracyClass = 6073;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_AccuracyDomain = 6074;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_EngineeringUnits = 6075;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_PeMeasurementID = 6156;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActivePowerTotal = 6068;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActivePowerTotal_AccuracyClass = 6069;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActivePowerTotal_AccuracyDomain = 6070;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActivePowerTotal_EngineeringUnits = 6071;

        /// <remarks />
        public const uint IEnergyProfileE2Type_AcActivePowerTotal_PeMeasurementID = 6155;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalExportHp = 6086;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_AccuracyClass = 6087;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_AccuracyDomain = 6088;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_EngineeringUnits = 6089;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_PeMeasurementID = 6161;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalImportHp = 6082;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_AccuracyClass = 6083;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_AccuracyDomain = 6084;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_EngineeringUnits = 6085;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_PeMeasurementID = 6160;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActivePower = 6080;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActivePower_AccuracyClass = 6122;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActivePower_AccuracyDomain = 6123;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActivePower_EngineeringUnits = 6124;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcActivePower_PeMeasurementID = 6158;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcCurrent = 6100;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcCurrent_AccuracyClass = 6125;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcCurrent_AccuracyDomain = 6126;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcCurrent_EngineeringUnits = 6127;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcCurrent_PeMeasurementID = 6166;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcPowerFactor = 6101;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcPowerFactor_AccuracyClass = 6128;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcPowerFactor_AccuracyDomain = 6129;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcPowerFactor_PeMeasurementID = 6167;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp = 6094;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_AccuracyClass = 6095;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_AccuracyDomain = 6096;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_EngineeringUnits = 6097;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_PeMeasurementID = 6163;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp = 6090;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_AccuracyClass = 6091;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_AccuracyDomain = 6092;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_EngineeringUnits = 6093;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_PeMeasurementID = 6162;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactivePower = 6081;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactivePower_AccuracyClass = 6131;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactivePower_AccuracyDomain = 6132;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactivePower_EngineeringUnits = 6133;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcReactivePower_PeMeasurementID = 6159;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePe = 6098;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePe_AccuracyClass = 6134;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePe_AccuracyDomain = 6135;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePe_EngineeringUnits = 6136;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePe_PeMeasurementID = 6164;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePp = 6099;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePp_AccuracyClass = 6137;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePp_AccuracyDomain = 6138;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePp_EngineeringUnits = 6139;

        /// <remarks />
        public const uint IEnergyProfileE3Type_AcVoltagePp_PeMeasurementID = 6165;

        /// <remarks />
        public const uint EnergyDevicePowerOffType_ModePowerConsumption = 6108;

        /// <remarks />
        public const uint EnergyDevicePowerOffType_RegularTimeToOperate = 6106;

        /// <remarks />
        public const uint EnergyDevicePowerOffType_SwitchOffWOL_OutputArguments = 6110;

        /// <remarks />
        public const uint EnergyDevicePowerOffType_TimeMinPause = 6107;

        /// <remarks />
        public const uint EnergyDevicePowerOffType_WOLMagicPacket = 6109;

        /// <remarks />
        public const uint EnergyMeasurementType_MeasurementValue = 6056;

        /// <remarks />
        public const uint EnergyMeasurementType_MeasurementValue_AccuracyClass = 6057;

        /// <remarks />
        public const uint EnergyMeasurementType_MeasurementValue_AccuracyDomain = 6058;

        /// <remarks />
        public const uint EnergyMeasurementType_MeasurementValue_EngineeringUnits = 6059;

        /// <remarks />
        public const uint EnergyMeasurementType_MeasurementValue_PeMeasurementID = 6152;

        /// <remarks />
        public const uint EnergyMeasurementType_PeObjectNumber = 6055;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_DynamicData = 6140;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToOperate = 6141;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToOperate_EngineeringUnits = 6142;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToPause = 6143;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToPause_EngineeringUnits = 6144;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_ModePowerConsumption = 6145;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_ModePowerConsumption_EngineeringUnits = 6146;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_RegularTimeToOperate = 6147;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_TimeMaxLengthOfStay = 6148;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_TimeMinLengthOfStay = 6149;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_TimeMinPause = 6150;

        /// <remarks />
        public const uint EnergySavingModesContainerType_EnergySavingModes_TimeToPause = 6151;

        /// <remarks />
        public const uint EnergySavingModeStatusType_CurrentTransitionData = 6023;

        /// <remarks />
        public const uint EnergySavingModeStatusType_StateInformation = 6024;

        /// <remarks />
        public const uint EnergySavingModeType_DynamicData = 6026;

        /// <remarks />
        public const uint EnergySavingModeType_EnergyConsumptionToOperate = 6036;

        /// <remarks />
        public const uint EnergySavingModeType_EnergyConsumptionToOperate_EngineeringUnits = 6037;

        /// <remarks />
        public const uint EnergySavingModeType_EnergyConsumptionToPause = 6034;

        /// <remarks />
        public const uint EnergySavingModeType_EnergyConsumptionToPause_EngineeringUnits = 6035;

        /// <remarks />
        public const uint EnergySavingModeType_ID = 6025;

        /// <remarks />
        public const uint EnergySavingModeType_ModePowerConsumption = 6032;

        /// <remarks />
        public const uint EnergySavingModeType_ModePowerConsumption_EngineeringUnits = 6033;

        /// <remarks />
        public const uint EnergySavingModeType_RegularTimeToOperate = 6031;

        /// <remarks />
        public const uint EnergySavingModeType_TimeMaxLengthOfStay = 6030;

        /// <remarks />
        public const uint EnergySavingModeType_TimeMinLengthOfStay = 6029;

        /// <remarks />
        public const uint EnergySavingModeType_TimeMinPause = 6027;

        /// <remarks />
        public const uint EnergySavingModeType_TimeToPause = 6028;

        /// <remarks />
        public const uint EnergyStandbyManagementType_EndPause_OutputArguments = 6054;

        /// <remarks />
        public const uint EnergyStandbyManagementType_EnergySavingModeStatus_StateInformation = 6039;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_Locked = 6045;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_LockingClient = 6046;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_LockingUser = 6047;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_RemainingLockTime = 6048;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_InitLock_InputArguments = 6043;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_InitLock_OutputArguments = 6044;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_RenewLock_OutputArguments = 6049;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_ExitLock_OutputArguments = 6042;

        /// <remarks />
        public const uint EnergyStandbyManagementType_Lock_BreakLock_OutputArguments = 6041;

        /// <remarks />
        public const uint EnergyStandbyManagementType_PauseTime = 6040;

        /// <remarks />
        public const uint EnergyStandbyManagementType_StandbyManagementStatus = 6016;

        /// <remarks />
        public const uint EnergyStandbyManagementType_StandbyManagementStatus_EnumStrings = 6038;

        /// <remarks />
        public const uint EnergyStandbyManagementType_StartPause_InputArguments = 6050;

        /// <remarks />
        public const uint EnergyStandbyManagementType_StartPause_OutputArguments = 6051;

        /// <remarks />
        public const uint EnergyStandbyManagementType_SwitchToEnergySavingMode_InputArguments = 6052;

        /// <remarks />
        public const uint EnergyStandbyManagementType_SwitchToEnergySavingMode_OutputArguments = 6053;

        /// <remarks />
        public const uint PeServiceAccessPointType_PeClass = 6112;

        /// <remarks />
        public const uint PeServiceAccessPointType_PeSubclass = 6113;

        /// <remarks />
        public const uint PeServiceAccessPointType_PeVersion = 6114;
    }
    #endregion

    #region VariableType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <remarks />
        public const uint MeasurementValueType = 2002;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AccuracyClassEnumeration = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.AccuracyClassEnumeration, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AccuracyDomainEnumeration = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.AccuracyDomainEnumeration, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeClassEnumeration = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.PeClassEnumeration, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeSubclassEnumeration = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.PeSubclassEnumeration, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AcPeDataType = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.AcPeDataType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AcPpDataType = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.AcPpDataType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStateInformationDataType = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.EnergyStateInformationDataType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeVersionDataType = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.PeVersionDataType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId StandbyModeTransitionDataType = new ExpandedNodeId(Opc.Ua.PnEm.DataTypes.StandbyModeTransitionDataType, Opc.Ua.PnEm.Namespaces.PnEm);
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId EnergyDevicePowerOffType_SwitchOffWOL = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyDevicePowerOffType_SwitchOffWOL, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyMeasurementType_ResetEnergyCounter = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyMeasurementType_ResetEnergyCounter, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_EndPause = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_EndPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_Lock_InitLock, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_Lock_RenewLock, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_Lock_ExitLock, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_Lock_BreakLock, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_StartPause = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_StartPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_SwitchToEnergySavingMode = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_SwitchToEnergySavingMode, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyDevicePowerOffType_SwitchOffWOLMethodType = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyDevicePowerOffType_SwitchOffWOLMethodType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_EndPauseMethodType = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_EndPauseMethodType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_StartPauseMethodType = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_StartPauseMethodType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_SwitchToEnergySavingModeMethodType = new ExpandedNodeId(Opc.Ua.PnEm.Methods.EnergyStandbyManagementType_SwitchToEnergySavingModeMethodType, Opc.Ua.PnEm.Namespaces.PnEm);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes = new ExpandedNodeId(Opc.Ua.PnEm.Objects.EnergySavingModesContainerType_EnergySavingModes, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_EnergySavingModes = new ExpandedNodeId(Opc.Ua.PnEm.Objects.EnergyStandbyManagementType_EnergySavingModes, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_EnergySavingModeStatus = new ExpandedNodeId(Opc.Ua.PnEm.Objects.EnergyStandbyManagementType_EnergySavingModeStatus, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock = new ExpandedNodeId(Opc.Ua.PnEm.Objects.EnergyStandbyManagementType_Lock, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId StandbyModeTransitionDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.PnEm.Objects.StandbyModeTransitionDataType_Encoding_DefaultBinary, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId StandbyModeTransitionDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.PnEm.Objects.StandbyModeTransitionDataType_Encoding_DefaultXml, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId StandbyModeTransitionDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.PnEm.Objects.StandbyModeTransitionDataType_Encoding_DefaultJson, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStateInformationDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.PnEm.Objects.EnergyStateInformationDataType_Encoding_DefaultBinary, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStateInformationDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.PnEm.Objects.EnergyStateInformationDataType_Encoding_DefaultXml, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStateInformationDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.PnEm.Objects.EnergyStateInformationDataType_Encoding_DefaultJson, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeVersionDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.PnEm.Objects.PeVersionDataType_Encoding_DefaultBinary, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeVersionDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.PnEm.Objects.PeVersionDataType_Encoding_DefaultXml, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeVersionDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.PnEm.Objects.PeVersionDataType_Encoding_DefaultJson, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AcPeDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.PnEm.Objects.AcPeDataType_Encoding_DefaultBinary, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AcPeDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.PnEm.Objects.AcPeDataType_Encoding_DefaultXml, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AcPeDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.PnEm.Objects.AcPeDataType_Encoding_DefaultJson, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AcPpDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.PnEm.Objects.AcPpDataType_Encoding_DefaultBinary, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AcPpDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.PnEm.Objects.AcPpDataType_Encoding_DefaultXml, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AcPpDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.PnEm.Objects.AcPpDataType_Encoding_DefaultJson, Opc.Ua.PnEm.Namespaces.PnEm);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileD0Type = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileD0Type, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE0Type = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileE0Type, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE1Type = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileE1Type, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileE2Type, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileE3Type, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyDevicePowerOffType = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.EnergyDevicePowerOffType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyMeasurementType = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.EnergyMeasurementType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.EnergySavingModesContainerType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeStatusType = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.EnergySavingModeStatusType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.EnergySavingModeType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.EnergyStandbyManagementType, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeServiceAccessPointType = new ExpandedNodeId(Opc.Ua.PnEm.ObjectTypes.PeServiceAccessPointType, Opc.Ua.PnEm.Namespaces.PnEm);
    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId HasEnergyMeasurement = new ExpandedNodeId(Opc.Ua.PnEm.ReferenceTypes.HasEnergyMeasurement, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId HasEnergyPowerOff = new ExpandedNodeId(Opc.Ua.PnEm.ReferenceTypes.HasEnergyPowerOff, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId HasEnergyStandbyManagement = new ExpandedNodeId(Opc.Ua.PnEm.ReferenceTypes.HasEnergyStandbyManagement, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId Represents = new ExpandedNodeId(Opc.Ua.PnEm.ReferenceTypes.Represents, Opc.Ua.PnEm.Namespaces.PnEm);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AccuracyClassEnumeration_EnumValues = new ExpandedNodeId(Opc.Ua.PnEm.Variables.AccuracyClassEnumeration_EnumValues, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId AccuracyDomainEnumeration_EnumValues = new ExpandedNodeId(Opc.Ua.PnEm.Variables.AccuracyDomainEnumeration_EnumValues, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeClassEnumeration_EnumValues = new ExpandedNodeId(Opc.Ua.PnEm.Variables.PeClassEnumeration_EnumValues, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeSubclassEnumeration_EnumValues = new ExpandedNodeId(Opc.Ua.PnEm.Variables.PeSubclassEnumeration_EnumValues, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementValueType_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.MeasurementValueType_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementValueType_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.MeasurementValueType_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementValueType_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.MeasurementValueType_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementValueType_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.MeasurementValueType_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId MeasurementValueType_ValueBeforeReset = new ExpandedNodeId(Opc.Ua.PnEm.Variables.MeasurementValueType_ValueBeforeReset, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileD0Type_DcCurrent = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileD0Type_DcCurrent, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileD0Type_DcCurrent_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileD0Type_DcCurrent_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileD0Type_DcCurrent_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileD0Type_DcCurrent_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileD0Type_DcCurrent_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileD0Type_DcCurrent_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileD0Type_DcCurrent_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileD0Type_DcCurrent_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE0Type_AcCurrent = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE0Type_AcCurrent, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE0Type_AcCurrent_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE0Type_AcCurrent_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE0Type_AcCurrent_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE0Type_AcCurrent_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE0Type_AcCurrent_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE0Type_AcCurrent_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE0Type_AcCurrent_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE0Type_AcCurrent_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE1Type_AcActivePowerTotal = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE1Type_AcActivePowerTotal, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE1Type_AcActivePowerTotal_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE1Type_AcActivePowerTotal_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE1Type_AcActivePowerTotal_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE1Type_AcActivePowerTotal_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE1Type_AcActivePowerTotal_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE1Type_AcActivePowerTotal_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE1Type_AcActivePowerTotal_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE1Type_AcActivePowerTotal_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalExportLp = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalExportLp, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalExportLp_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalImportLp = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalImportLp, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActiveEnergyTotalImportLp_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActivePowerTotal = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActivePowerTotal, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActivePowerTotal_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActivePowerTotal_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActivePowerTotal_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActivePowerTotal_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActivePowerTotal_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActivePowerTotal_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE2Type_AcActivePowerTotal_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE2Type_AcActivePowerTotal_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalExportHp = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalExportHp, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalExportHp_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalImportHp = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalImportHp, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActiveEnergyTotalImportHp_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActivePower = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActivePower, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActivePower_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActivePower_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActivePower_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActivePower_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActivePower_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActivePower_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcActivePower_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcActivePower_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcCurrent = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcCurrent, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcCurrent_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcCurrent_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcCurrent_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcCurrent_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcCurrent_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcCurrent_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcCurrent_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcCurrent_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcPowerFactor = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcPowerFactor, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcPowerFactor_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcPowerFactor_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcPowerFactor_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcPowerFactor_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcPowerFactor_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcPowerFactor_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalExportHp_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactiveEnergyTotalImportHp_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactivePower = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactivePower, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactivePower_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactivePower_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactivePower_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactivePower_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactivePower_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactivePower_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcReactivePower_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcReactivePower_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePe = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePe, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePe_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePe_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePe_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePe_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePe_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePe_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePe_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePe_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePp = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePp, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePp_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePp_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePp_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePp_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePp_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePp_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId IEnergyProfileE3Type_AcVoltagePp_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.IEnergyProfileE3Type_AcVoltagePp_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyDevicePowerOffType_ModePowerConsumption = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyDevicePowerOffType_ModePowerConsumption, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyDevicePowerOffType_RegularTimeToOperate = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyDevicePowerOffType_RegularTimeToOperate, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyDevicePowerOffType_SwitchOffWOL_OutputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyDevicePowerOffType_SwitchOffWOL_OutputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyDevicePowerOffType_TimeMinPause = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyDevicePowerOffType_TimeMinPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyDevicePowerOffType_WOLMagicPacket = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyDevicePowerOffType_WOLMagicPacket, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyMeasurementType_MeasurementValue = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyMeasurementType_MeasurementValue, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyMeasurementType_MeasurementValue_AccuracyClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyMeasurementType_MeasurementValue_AccuracyClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyMeasurementType_MeasurementValue_AccuracyDomain = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyMeasurementType_MeasurementValue_AccuracyDomain, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyMeasurementType_MeasurementValue_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyMeasurementType_MeasurementValue_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyMeasurementType_MeasurementValue_PeMeasurementID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyMeasurementType_MeasurementValue_PeMeasurementID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyMeasurementType_PeObjectNumber = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyMeasurementType_PeObjectNumber, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_DynamicData = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_DynamicData, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToOperate = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToOperate, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToOperate_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToOperate_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToPause = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToPause_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_EnergyConsumptionToPause_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_ModePowerConsumption = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_ModePowerConsumption, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_ModePowerConsumption_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_ModePowerConsumption_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_RegularTimeToOperate = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_RegularTimeToOperate, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_TimeMaxLengthOfStay = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_TimeMaxLengthOfStay, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_TimeMinLengthOfStay = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_TimeMinLengthOfStay, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_TimeMinPause = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_TimeMinPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModesContainerType_EnergySavingModes_TimeToPause = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModesContainerType_EnergySavingModes_TimeToPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeStatusType_CurrentTransitionData = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeStatusType_CurrentTransitionData, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeStatusType_StateInformation = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeStatusType_StateInformation, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_DynamicData = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_DynamicData, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_EnergyConsumptionToOperate = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_EnergyConsumptionToOperate, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_EnergyConsumptionToOperate_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_EnergyConsumptionToOperate_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_EnergyConsumptionToPause = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_EnergyConsumptionToPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_EnergyConsumptionToPause_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_EnergyConsumptionToPause_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_ID = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_ID, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_ModePowerConsumption = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_ModePowerConsumption, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_ModePowerConsumption_EngineeringUnits = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_ModePowerConsumption_EngineeringUnits, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_RegularTimeToOperate = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_RegularTimeToOperate, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_TimeMaxLengthOfStay = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_TimeMaxLengthOfStay, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_TimeMinLengthOfStay = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_TimeMinLengthOfStay, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_TimeMinPause = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_TimeMinPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergySavingModeType_TimeToPause = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergySavingModeType_TimeToPause, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_EndPause_OutputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_EndPause_OutputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_EnergySavingModeStatus_StateInformation = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_EnergySavingModeStatus_StateInformation, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_Locked = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_Locked, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_LockingClient, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_LockingUser, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_RemainingLockTime, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_InitLock_InputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_InitLock_OutputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_RenewLock_OutputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_ExitLock_OutputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_Lock_BreakLock_OutputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_PauseTime = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_PauseTime, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_StandbyManagementStatus = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_StandbyManagementStatus, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_StandbyManagementStatus_EnumStrings = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_StandbyManagementStatus_EnumStrings, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_StartPause_InputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_StartPause_InputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_StartPause_OutputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_StartPause_OutputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_SwitchToEnergySavingMode_InputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_SwitchToEnergySavingMode_InputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId EnergyStandbyManagementType_SwitchToEnergySavingMode_OutputArguments = new ExpandedNodeId(Opc.Ua.PnEm.Variables.EnergyStandbyManagementType_SwitchToEnergySavingMode_OutputArguments, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeServiceAccessPointType_PeClass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.PeServiceAccessPointType_PeClass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeServiceAccessPointType_PeSubclass = new ExpandedNodeId(Opc.Ua.PnEm.Variables.PeServiceAccessPointType_PeSubclass, Opc.Ua.PnEm.Namespaces.PnEm);

        /// <remarks />
        public static readonly ExpandedNodeId PeServiceAccessPointType_PeVersion = new ExpandedNodeId(Opc.Ua.PnEm.Variables.PeServiceAccessPointType_PeVersion, Opc.Ua.PnEm.Namespaces.PnEm);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MeasurementValueType = new ExpandedNodeId(Opc.Ua.PnEm.VariableTypes.MeasurementValueType, Opc.Ua.PnEm.Namespaces.PnEm);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AcActiveEnergyTotalExportHp = "AcActiveEnergyTotalExportHp";

        /// <remarks />
        public const string AcActiveEnergyTotalExportLp = "AcActiveEnergyTotalExportLp";

        /// <remarks />
        public const string AcActiveEnergyTotalImportHp = "AcActiveEnergyTotalImportHp";

        /// <remarks />
        public const string AcActiveEnergyTotalImportLp = "AcActiveEnergyTotalImportLp";

        /// <remarks />
        public const string AcActivePower = "AcActivePower";

        /// <remarks />
        public const string AcActivePowerTotal = "AcActivePowerTotal";

        /// <remarks />
        public const string AccuracyClass = "AccuracyClass";

        /// <remarks />
        public const string AccuracyClassEnumeration = "AccuracyClassEnumeration";

        /// <remarks />
        public const string AccuracyDomain = "AccuracyDomain";

        /// <remarks />
        public const string AccuracyDomainEnumeration = "AccuracyDomainEnumeration";

        /// <remarks />
        public const string AcCurrent = "AcCurrent";

        /// <remarks />
        public const string AcPeDataType = "AcPeDataType";

        /// <remarks />
        public const string AcPowerFactor = "AcPowerFactor";

        /// <remarks />
        public const string AcPpDataType = "AcPpDataType";

        /// <remarks />
        public const string AcReactiveEnergyTotalExportHp = "AcReactiveEnergyTotalExportHp";

        /// <remarks />
        public const string AcReactiveEnergyTotalImportHp = "AcReactiveEnergyTotalImportHp";

        /// <remarks />
        public const string AcReactivePower = "AcReactivePower";

        /// <remarks />
        public const string AcVoltagePe = "AcVoltagePe";

        /// <remarks />
        public const string AcVoltagePp = "AcVoltagePp";

        /// <remarks />
        public const string CurrentTransitionData = "CurrentTransitionData";

        /// <remarks />
        public const string DcCurrent = "DcCurrent";

        /// <remarks />
        public const string DynamicData = "DynamicData";

        /// <remarks />
        public const string EndPause = "EndPause";

        /// <remarks />
        public const string EndPauseMethodType = "EndPauseMethodType";

        /// <remarks />
        public const string EnergyConsumptionToOperate = "EnergyConsumptionToOperate";

        /// <remarks />
        public const string EnergyConsumptionToPause = "EnergyConsumptionToPause";

        /// <remarks />
        public const string EnergyDevicePowerOffType = "EnergyDevicePowerOffType";

        /// <remarks />
        public const string EnergyMeasurementType = "EnergyMeasurementType";

        /// <remarks />
        public const string EnergySavingModes = "EnergySavingModes";

        /// <remarks />
        public const string EnergySavingModesContainerType = "EnergySavingModesContainerType";

        /// <remarks />
        public const string EnergySavingModeStatus = "EnergySavingModeStatus";

        /// <remarks />
        public const string EnergySavingModeStatusType = "EnergySavingModeStatusType";

        /// <remarks />
        public const string EnergySavingModeType = "EnergySavingModeType";

        /// <remarks />
        public const string EnergyStandbyManagementType = "EnergyStandbyManagementType";

        /// <remarks />
        public const string EnergyStateInformationDataType = "EnergyStateInformationDataType";

        /// <remarks />
        public const string HasEnergyMeasurement = "HasEnergyMeasurement";

        /// <remarks />
        public const string HasEnergyPowerOff = "HasEnergyPowerOff";

        /// <remarks />
        public const string HasEnergyStandbyManagement = "HasEnergyStandbyManagement";

        /// <remarks />
        public const string ID = "ID";

        /// <remarks />
        public const string IEnergyProfileD0Type = "IEnergyProfileD0Type";

        /// <remarks />
        public const string IEnergyProfileE0Type = "IEnergyProfileE0Type";

        /// <remarks />
        public const string IEnergyProfileE1Type = "IEnergyProfileE1Type";

        /// <remarks />
        public const string IEnergyProfileE2Type = "IEnergyProfileE2Type";

        /// <remarks />
        public const string IEnergyProfileE3Type = "IEnergyProfileE3Type";

        /// <remarks />
        public const string Lock = "Lock";

        /// <remarks />
        public const string MeasurementValue = "<MeasurementValue>";

        /// <remarks />
        public const string MeasurementValueType = "MeasurementValueType";

        /// <remarks />
        public const string ModePowerConsumption = "ModePowerConsumption";

        /// <remarks />
        public const string PauseTime = "PauseTime";

        /// <remarks />
        public const string PeClass = "PeClass";

        /// <remarks />
        public const string PeClassEnumeration = "PeClassEnumeration";

        /// <remarks />
        public const string PeMeasurementID = "PeMeasurementID";

        /// <remarks />
        public const string PeObjectNumber = "PeObjectNumber";

        /// <remarks />
        public const string PeServiceAccessPointType = "PeServiceAccessPointType";

        /// <remarks />
        public const string PeSubclass = "PeSubclass";

        /// <remarks />
        public const string PeSubclassEnumeration = "PeSubclassEnumeration";

        /// <remarks />
        public const string PeVersion = "PeVersion";

        /// <remarks />
        public const string PeVersionDataType = "PeVersionDataType";

        /// <remarks />
        public const string RegularTimeToOperate = "RegularTimeToOperate";

        /// <remarks />
        public const string Represents = "Represents";

        /// <remarks />
        public const string ResetEnergyCounter = "ResetEnergyCounter";

        /// <remarks />
        public const string StandbyManagementStatus = "StandbyManagementStatus";

        /// <remarks />
        public const string StandbyModeTransitionDataType = "StandbyModeTransitionDataType";

        /// <remarks />
        public const string StartPause = "StartPause";

        /// <remarks />
        public const string StartPauseMethodType = "StartPauseMethodType";

        /// <remarks />
        public const string StateInformation = "StateInformation";

        /// <remarks />
        public const string SwitchOffWOL = "SwitchOffWOL";

        /// <remarks />
        public const string SwitchOffWOLMethodType = "SwitchOffWOLMethodType";

        /// <remarks />
        public const string SwitchToEnergySavingMode = "SwitchToEnergySavingMode";

        /// <remarks />
        public const string SwitchToEnergySavingModeMethodType = "SwitchToEnergySavingModeMethodType";

        /// <remarks />
        public const string TimeMaxLengthOfStay = "TimeMaxLengthOfStay";

        /// <remarks />
        public const string TimeMinLengthOfStay = "TimeMinLengthOfStay";

        /// <remarks />
        public const string TimeMinPause = "TimeMinPause";

        /// <remarks />
        public const string TimeToPause = "TimeToPause";

        /// <remarks />
        public const string ValueBeforeReset = "ValueBeforeReset";

        /// <remarks />
        public const string WOLMagicPacket = "WOLMagicPacket";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the PnEm namespace (.NET code namespace is 'Opc.Ua.PnEm').
        /// </summary>
        public const string PnEm = "http://opcfoundation.org/UA/PNEM/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the DI namespace (.NET code namespace is 'Opc.Ua.DI').
        /// </summary>
        public const string DI = "http://opcfoundation.org/UA/DI/";
    }
    #endregion
}