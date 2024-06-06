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
using Opc.Ua.PnEm;

namespace nortura.no.amspnemmodel
{
    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint EnergyManagement = 5003;

        /// <remarks />
        public const uint MeteringPoint__1 = 5006;

        /// <remarks />
        public const uint MeteringPoint__2 = 5009;

        /// <remarks />
        public const uint MeteringPoint__3 = 5012;

        /// <remarks />
        public const uint MeteringPoint__4 = 5015;

        /// <remarks />
        public const uint MeteringPoint__5 = 5018;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint MeteringPoint__1_DcCurrent = 6001;

        /// <remarks />
        public const uint MeteringPoint__1_DcCurrent_AccuracyClass = 6002;

        /// <remarks />
        public const uint MeteringPoint__1_DcCurrent_AccuracyDomain = 6003;

        /// <remarks />
        public const uint MeteringPoint__1_DcCurrent_PeMeasurementID = 6004;

        /// <remarks />
        public const uint MeteringPoint__2_AcCurrent = 6005;

        /// <remarks />
        public const uint MeteringPoint__2_AcCurrent_AccuracyClass = 6006;

        /// <remarks />
        public const uint MeteringPoint__2_AcCurrent_AccuracyDomain = 6007;

        /// <remarks />
        public const uint MeteringPoint__2_AcCurrent_PeMeasurementID = 6008;

        /// <remarks />
        public const uint MeteringPoint__3_AcActivePowerTotal = 6009;

        /// <remarks />
        public const uint MeteringPoint__3_AcActivePowerTotal_AccuracyClass = 6010;

        /// <remarks />
        public const uint MeteringPoint__3_AcActivePowerTotal_AccuracyDomain = 6011;

        /// <remarks />
        public const uint MeteringPoint__3_AcActivePowerTotal_PeMeasurementID = 6012;

        /// <remarks />
        public const uint MeteringPoint__4_AcActiveEnergyTotalExportLp = 6013;

        /// <remarks />
        public const uint MeteringPoint__4_AcActiveEnergyTotalExportLp_AccuracyClass = 6014;

        /// <remarks />
        public const uint MeteringPoint__4_AcActiveEnergyTotalExportLp_AccuracyDomain = 6015;

        /// <remarks />
        public const uint MeteringPoint__4_AcActiveEnergyTotalExportLp_PeMeasurementID = 6016;

        /// <remarks />
        public const uint MeteringPoint__4_AcActiveEnergyTotalImportLp = 6017;

        /// <remarks />
        public const uint MeteringPoint__4_AcActiveEnergyTotalImportLp_AccuracyClass = 6018;

        /// <remarks />
        public const uint MeteringPoint__4_AcActiveEnergyTotalImportLp_AccuracyDomain = 6019;

        /// <remarks />
        public const uint MeteringPoint__4_AcActiveEnergyTotalImportLp_PeMeasurementID = 6020;

        /// <remarks />
        public const uint MeteringPoint__4_AcActivePowerTotal = 6021;

        /// <remarks />
        public const uint MeteringPoint__4_AcActivePowerTotal_AccuracyClass = 6022;

        /// <remarks />
        public const uint MeteringPoint__4_AcActivePowerTotal_AccuracyDomain = 6023;

        /// <remarks />
        public const uint MeteringPoint__4_AcActivePowerTotal_PeMeasurementID = 6024;

        /// <remarks />
        public const uint MeteringPoint__5_AcActiveEnergyTotalExportHp = 6025;

        /// <remarks />
        public const uint MeteringPoint__5_AcActiveEnergyTotalExportHp_AccuracyClass = 6026;

        /// <remarks />
        public const uint MeteringPoint__5_AcActiveEnergyTotalExportHp_AccuracyDomain = 6027;

        /// <remarks />
        public const uint MeteringPoint__5_AcActiveEnergyTotalExportHp_PeMeasurementID = 6028;

        /// <remarks />
        public const uint MeteringPoint__5_AcActiveEnergyTotalImportHp = 6029;

        /// <remarks />
        public const uint MeteringPoint__5_AcActiveEnergyTotalImportHp_AccuracyClass = 6030;

        /// <remarks />
        public const uint MeteringPoint__5_AcActiveEnergyTotalImportHp_AccuracyDomain = 6031;

        /// <remarks />
        public const uint MeteringPoint__5_AcActiveEnergyTotalImportHp_PeMeasurementID = 6032;

        /// <remarks />
        public const uint MeteringPoint__5_AcActivePower = 6033;

        /// <remarks />
        public const uint MeteringPoint__5_AcActivePower_AccuracyClass = 6034;

        /// <remarks />
        public const uint MeteringPoint__5_AcActivePower_AccuracyDomain = 6035;

        /// <remarks />
        public const uint MeteringPoint__5_AcActivePower_PeMeasurementID = 6036;

        /// <remarks />
        public const uint MeteringPoint__5_AcCurrent = 6037;

        /// <remarks />
        public const uint MeteringPoint__5_AcCurrent_AccuracyClass = 6038;

        /// <remarks />
        public const uint MeteringPoint__5_AcCurrent_AccuracyDomain = 6039;

        /// <remarks />
        public const uint MeteringPoint__5_AcCurrent_PeMeasurementID = 6040;

        /// <remarks />
        public const uint MeteringPoint__5_AcPowerFactor = 6041;

        /// <remarks />
        public const uint MeteringPoint__5_AcPowerFactor_AccuracyClass = 6042;

        /// <remarks />
        public const uint MeteringPoint__5_AcPowerFactor_AccuracyDomain = 6043;

        /// <remarks />
        public const uint MeteringPoint__5_AcPowerFactor_PeMeasurementID = 6044;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactiveEnergyTotalExportHp = 6045;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactiveEnergyTotalExportHp_AccuracyClass = 6046;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactiveEnergyTotalExportHp_AccuracyDomain = 6047;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactiveEnergyTotalExportHp_PeMeasurementID = 6048;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactiveEnergyTotalImportHp = 6049;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactiveEnergyTotalImportHp_AccuracyClass = 6050;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactiveEnergyTotalImportHp_AccuracyDomain = 6051;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactiveEnergyTotalImportHp_PeMeasurementID = 6052;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactivePower = 6053;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactivePower_AccuracyClass = 6054;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactivePower_AccuracyDomain = 6055;

        /// <remarks />
        public const uint MeteringPoint__5_AcReactivePower_PeMeasurementID = 6056;

        /// <remarks />
        public const uint MeteringPoint__5_AcVoltagePe = 6057;

        /// <remarks />
        public const uint MeteringPoint__5_AcVoltagePe_AccuracyClass = 6058;

        /// <remarks />
        public const uint MeteringPoint__5_AcVoltagePe_AccuracyDomain = 6059;

        /// <remarks />
        public const uint MeteringPoint__5_AcVoltagePe_PeMeasurementID = 6060;

        /// <remarks />
        public const uint MeteringPoint__5_AcVoltagePp = 6061;

        /// <remarks />
        public const uint MeteringPoint__5_AcVoltagePp_AccuracyClass = 6062;

        /// <remarks />
        public const uint MeteringPoint__5_AcVoltagePp_AccuracyDomain = 6063;

        /// <remarks />
        public const uint MeteringPoint__5_AcVoltagePp_PeMeasurementID = 6064;
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId EnergyManagement = new ExpandedNodeId(nortura.no.amspnemmodel.Objects.EnergyManagement, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__1 = new ExpandedNodeId(nortura.no.amspnemmodel.Objects.MeteringPoint__1, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__2 = new ExpandedNodeId(nortura.no.amspnemmodel.Objects.MeteringPoint__2, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__3 = new ExpandedNodeId(nortura.no.amspnemmodel.Objects.MeteringPoint__3, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4 = new ExpandedNodeId(nortura.no.amspnemmodel.Objects.MeteringPoint__4, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5 = new ExpandedNodeId(nortura.no.amspnemmodel.Objects.MeteringPoint__5, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__1_DcCurrent = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__1_DcCurrent, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__1_DcCurrent_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__1_DcCurrent_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__1_DcCurrent_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__1_DcCurrent_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__1_DcCurrent_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__1_DcCurrent_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__2_AcCurrent = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__2_AcCurrent, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__2_AcCurrent_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__2_AcCurrent_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__2_AcCurrent_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__2_AcCurrent_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__2_AcCurrent_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__2_AcCurrent_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__3_AcActivePowerTotal = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__3_AcActivePowerTotal, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__3_AcActivePowerTotal_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__3_AcActivePowerTotal_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__3_AcActivePowerTotal_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__3_AcActivePowerTotal_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__3_AcActivePowerTotal_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__3_AcActivePowerTotal_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActiveEnergyTotalExportLp = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActiveEnergyTotalExportLp, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActiveEnergyTotalExportLp_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActiveEnergyTotalExportLp_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActiveEnergyTotalExportLp_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActiveEnergyTotalExportLp_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActiveEnergyTotalExportLp_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActiveEnergyTotalExportLp_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActiveEnergyTotalImportLp = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActiveEnergyTotalImportLp, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActiveEnergyTotalImportLp_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActiveEnergyTotalImportLp_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActiveEnergyTotalImportLp_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActiveEnergyTotalImportLp_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActiveEnergyTotalImportLp_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActiveEnergyTotalImportLp_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActivePowerTotal = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActivePowerTotal, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActivePowerTotal_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActivePowerTotal_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActivePowerTotal_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActivePowerTotal_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__4_AcActivePowerTotal_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__4_AcActivePowerTotal_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActiveEnergyTotalExportHp = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActiveEnergyTotalExportHp, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActiveEnergyTotalExportHp_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActiveEnergyTotalExportHp_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActiveEnergyTotalExportHp_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActiveEnergyTotalExportHp_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActiveEnergyTotalExportHp_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActiveEnergyTotalExportHp_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActiveEnergyTotalImportHp = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActiveEnergyTotalImportHp, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActiveEnergyTotalImportHp_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActiveEnergyTotalImportHp_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActiveEnergyTotalImportHp_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActiveEnergyTotalImportHp_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActiveEnergyTotalImportHp_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActiveEnergyTotalImportHp_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActivePower = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActivePower, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActivePower_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActivePower_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActivePower_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActivePower_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcActivePower_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcActivePower_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcCurrent = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcCurrent, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcCurrent_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcCurrent_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcCurrent_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcCurrent_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcCurrent_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcCurrent_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcPowerFactor = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcPowerFactor, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcPowerFactor_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcPowerFactor_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcPowerFactor_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcPowerFactor_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcPowerFactor_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcPowerFactor_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactiveEnergyTotalExportHp = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactiveEnergyTotalExportHp, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactiveEnergyTotalExportHp_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactiveEnergyTotalExportHp_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactiveEnergyTotalExportHp_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactiveEnergyTotalExportHp_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactiveEnergyTotalExportHp_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactiveEnergyTotalExportHp_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactiveEnergyTotalImportHp = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactiveEnergyTotalImportHp, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactiveEnergyTotalImportHp_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactiveEnergyTotalImportHp_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactiveEnergyTotalImportHp_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactiveEnergyTotalImportHp_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactiveEnergyTotalImportHp_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactiveEnergyTotalImportHp_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactivePower = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactivePower, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactivePower_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactivePower_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactivePower_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactivePower_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcReactivePower_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcReactivePower_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcVoltagePe = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcVoltagePe, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcVoltagePe_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcVoltagePe_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcVoltagePe_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcVoltagePe_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcVoltagePe_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcVoltagePe_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcVoltagePp = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcVoltagePp, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcVoltagePp_AccuracyClass = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcVoltagePp_AccuracyClass, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcVoltagePp_AccuracyDomain = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcVoltagePp_AccuracyDomain, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);

        /// <remarks />
        public static readonly ExpandedNodeId MeteringPoint__5_AcVoltagePp_PeMeasurementID = new ExpandedNodeId(nortura.no.amspnemmodel.Variables.MeteringPoint__5_AcVoltagePp_PeMeasurementID, nortura.no.amspnemmodel.Namespaces.norturanoamspnemmodel);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string EnergyManagement = "EnergyManagement";

        /// <remarks />
        public const string MeteringPoint__1 = "MeteringPoint #1";

        /// <remarks />
        public const string MeteringPoint__2 = "MeteringPoint #2";

        /// <remarks />
        public const string MeteringPoint__3 = "MeteringPoint #3";

        /// <remarks />
        public const string MeteringPoint__4 = "MeteringPoint #4";

        /// <remarks />
        public const string MeteringPoint__5 = "MeteringPoint #5";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the norturanoamspnemmodel namespace (.NET code namespace is 'nortura.no.amspnemmodel').
        /// </summary>
        public const string norturanoamspnemmodel = "http://nortura.no/amspnemmodel/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the DI namespace (.NET code namespace is 'Opc.Ua.DI').
        /// </summary>
        public const string DI = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the PnEm namespace (.NET code namespace is 'Opc.Ua.PnEm').
        /// </summary>
        public const string PnEm = "http://opcfoundation.org/UA/PNEM/";
    }
    #endregion
}