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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.DI;

namespace Opc.Ua.PnEm
{
    #region MeasurementValueTypeState Class
    #if (!OPCUA_EXCLUDE_MeasurementValueTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MeasurementValueTypeState : BaseDataVariableState
    {
        #region Constructors
        /// <remarks />
        public MeasurementValueTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.VariableTypes.MeasurementValueType, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Any;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (EngineeringUnits != null)
            {
                EngineeringUnits.Initialize(context, EngineeringUnits_InitializationString);
            }

            if (ValueBeforeReset != null)
            {
                ValueBeforeReset.Initialize(context, ValueBeforeReset_InitializationString);
            }
        }

        #region Initialization String
        private const string EngineeringUnits_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8VYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAYUXAC4ARIUX" +
           "AAABAHcD/////wEB/////wAAAAA=";

        private const string ValueBeforeReset_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8VYIkKAgAAAAEAEAAAAFZhbHVlQmVmb3JlUmVzZXQBAYYXAC4ARIYX" +
           "AAAAGP////8BAf////8AAAAA";

        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8VYIECAgAAAAEAHAAAAE1lYXN1cmVtZW50VmFsdWVUeXBlSW5zdGFu" +
           "Y2UBAdIHAQHSB9IHAAAAGAEB/////wUAAAAVYIkKAgAAAAEADQAAAEFjY3VyYWN5Q2xhc3MBAYQXAC4A" +
           "RIQXAAABAcEL/////wEB/////wAAAAAVYIkKAgAAAAEADgAAAEFjY3VyYWN5RG9tYWluAQGDFwAuAESD" +
           "FwAAAQHCC/////8BAf////8AAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQGFFwAuAESF" +
           "FwAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABQZU1lYXN1cmVtZW50SUQBAYIXAC4ARIIX" +
           "AAAABf////8BAf////8AAAAAFWCJCgIAAAABABAAAABWYWx1ZUJlZm9yZVJlc2V0AQGGFwAuAESGFwAA" +
           "ABj/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<AccuracyClassEnumeration> AccuracyClass
        {
            get
            {
                return m_accuracyClass;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accuracyClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accuracyClass = value;
            }
        }

        /// <remarks />
        public PropertyState<AccuracyDomainEnumeration> AccuracyDomain
        {
            get
            {
                return m_accuracyDomain;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accuracyDomain, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accuracyDomain = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> EngineeringUnits
        {
            get
            {
                return m_engineeringUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_engineeringUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_engineeringUnits = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> PeMeasurementID
        {
            get
            {
                return m_peMeasurementID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_peMeasurementID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_peMeasurementID = value;
            }
        }

        /// <remarks />
        public PropertyState ValueBeforeReset
        {
            get
            {
                return m_valueBeforeReset;
            }

            set
            {
                if (!Object.ReferenceEquals(m_valueBeforeReset, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_valueBeforeReset = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_accuracyClass != null)
            {
                children.Add(m_accuracyClass);
            }

            if (m_accuracyDomain != null)
            {
                children.Add(m_accuracyDomain);
            }

            if (m_engineeringUnits != null)
            {
                children.Add(m_engineeringUnits);
            }

            if (m_peMeasurementID != null)
            {
                children.Add(m_peMeasurementID);
            }

            if (m_valueBeforeReset != null)
            {
                children.Add(m_valueBeforeReset);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.AccuracyClass:
                {
                    if (createOrReplace)
                    {
                        if (AccuracyClass == null)
                        {
                            if (replacement == null)
                            {
                                AccuracyClass = new PropertyState<AccuracyClassEnumeration>(this);
                            }
                            else
                            {
                                AccuracyClass = (PropertyState<AccuracyClassEnumeration>)replacement;
                            }
                        }
                    }

                    instance = AccuracyClass;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AccuracyDomain:
                {
                    if (createOrReplace)
                    {
                        if (AccuracyDomain == null)
                        {
                            if (replacement == null)
                            {
                                AccuracyDomain = new PropertyState<AccuracyDomainEnumeration>(this);
                            }
                            else
                            {
                                AccuracyDomain = (PropertyState<AccuracyDomainEnumeration>)replacement;
                            }
                        }
                    }

                    instance = AccuracyDomain;
                    break;
                }

                case Opc.Ua.BrowseNames.EngineeringUnits:
                {
                    if (createOrReplace)
                    {
                        if (EngineeringUnits == null)
                        {
                            if (replacement == null)
                            {
                                EngineeringUnits = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                EngineeringUnits = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = EngineeringUnits;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.PeMeasurementID:
                {
                    if (createOrReplace)
                    {
                        if (PeMeasurementID == null)
                        {
                            if (replacement == null)
                            {
                                PeMeasurementID = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                PeMeasurementID = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = PeMeasurementID;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.ValueBeforeReset:
                {
                    if (createOrReplace)
                    {
                        if (ValueBeforeReset == null)
                        {
                            if (replacement == null)
                            {
                                ValueBeforeReset = new PropertyState(this);
                            }
                            else
                            {
                                ValueBeforeReset = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = ValueBeforeReset;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<AccuracyClassEnumeration> m_accuracyClass;
        private PropertyState<AccuracyDomainEnumeration> m_accuracyDomain;
        private PropertyState<EUInformation> m_engineeringUnits;
        private PropertyState<ushort> m_peMeasurementID;
        private PropertyState m_valueBeforeReset;
        #endregion
    }

    #region MeasurementValueTypeState<T> Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MeasurementValueTypeState<T> : MeasurementValueTypeState
    {
        #region Constructors
        /// <remarks />
        public MeasurementValueTypeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region IEnergyProfileD0TypeState Class
    #if (!OPCUA_EXCLUDE_IEnergyProfileD0TypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IEnergyProfileD0TypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IEnergyProfileD0TypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileD0Type, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAHAAAAElFbmVyZ3lQcm9maWxlRDBUeXBlSW5zdGFu" +
           "Y2UBAfMDAQHzA/MDAAD/////AQAAABVgiQoCAAAAAQAJAAAARGNDdXJyZW50AQHWFwAvAQHSB9YXAAAA" +
           "Cv////8DA/////8EAAAAFWCJCgIAAAABAA0AAABBY2N1cmFjeUNsYXNzAQHXFwAuAETXFwAAAQHBC///" +
           "//8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY2N1cmFjeURvbWFpbgEB2BcALgBE2BcAAAEBwgv/////" +
           "AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEB2RcALgBE2RcAABYBAHkDAUgA" +
           "AAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZhY3RQTUEAAgEA" +
           "AABBAgYAAABhbXBlcmUBAHcD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBlTWVhc3VyZW1lbnRJ" +
           "RAEBGBgALgBEGBgAAAAF/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MeasurementValueTypeState<float> DcCurrent
        {
            get
            {
                return m_dcCurrent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dcCurrent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dcCurrent = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_dcCurrent != null)
            {
                children.Add(m_dcCurrent);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.DcCurrent:
                {
                    if (createOrReplace)
                    {
                        if (DcCurrent == null)
                        {
                            if (replacement == null)
                            {
                                DcCurrent = new MeasurementValueTypeState<float>(this);
                            }
                            else
                            {
                                DcCurrent = (MeasurementValueTypeState<float>)replacement;
                            }
                        }
                    }

                    instance = DcCurrent;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MeasurementValueTypeState<float> m_dcCurrent;
        #endregion
    }
    #endif
    #endregion

    #region IEnergyProfileE0TypeState Class
    #if (!OPCUA_EXCLUDE_IEnergyProfileE0TypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IEnergyProfileE0TypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IEnergyProfileE0TypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileE0Type, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAHAAAAElFbmVyZ3lQcm9maWxlRTBUeXBlSW5zdGFu" +
           "Y2UBAe8DAQHvA+8DAAD/////AQAAABVgqQoCAAAAAQAJAAAAQWNDdXJyZW50AQGsFwAvAQHSB6wXAAAW" +
           "AQGTEwJoAAAAPEFjUGVEYXRhVHlwZSB4bWxucz0iaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1BO" +
           "RU0vVHlwZXMueHNkIj48QT4wPC9BPjxCPjA8L0I+PEM+MDwvQz48L0FjUGVEYXRhVHlwZT4BAb0L////" +
           "/wMD/////wQAAAAVYIkKAgAAAAEADQAAAEFjY3VyYWN5Q2xhc3MBAa0XAC4ARK0XAAABAcEL/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEADgAAAEFjY3VyYWN5RG9tYWluAQGuFwAuAESuFwAAAQHCC/////8BAf//" +
           "//8AAAAAFWCpCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQGvFwAuAESvFwAAFgEAeQMBSAAAAC8A" +
           "AABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2NlZmFjdFBNQQACAQAAAEEC" +
           "BgAAAGFtcGVyZQEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUGVNZWFzdXJlbWVudElEAQEJ" +
           "GAAuAEQJGAAAAAX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MeasurementValueTypeState<AcPeDataType> AcCurrent
        {
            get
            {
                return m_acCurrent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acCurrent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acCurrent = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_acCurrent != null)
            {
                children.Add(m_acCurrent);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.AcCurrent:
                {
                    if (createOrReplace)
                    {
                        if (AcCurrent == null)
                        {
                            if (replacement == null)
                            {
                                AcCurrent = new MeasurementValueTypeState<AcPeDataType>(this);
                            }
                            else
                            {
                                AcCurrent = (MeasurementValueTypeState<AcPeDataType>)replacement;
                            }
                        }
                    }

                    instance = AcCurrent;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MeasurementValueTypeState<AcPeDataType> m_acCurrent;
        #endregion
    }
    #endif
    #endregion

    #region IEnergyProfileE1TypeState Class
    #if (!OPCUA_EXCLUDE_IEnergyProfileE1TypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IEnergyProfileE1TypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IEnergyProfileE1TypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileE1Type, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAHAAAAElFbmVyZ3lQcm9maWxlRTFUeXBlSW5zdGFu" +
           "Y2UBAfADAQHwA/ADAAD/////AQAAABVgiQoCAAAAAQASAAAAQWNBY3RpdmVQb3dlclRvdGFsAQGwFwAv" +
           "AQHSB7AXAAAACv////8DA/////8EAAAAFWCJCgIAAAABAA0AAABBY2N1cmFjeUNsYXNzAQGxFwAuAESx" +
           "FwAAAQHBC/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY2N1cmFjeURvbWFpbgEBshcALgBEshcA" +
           "AAEBwgv/////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBsxcALgBEsxcA" +
           "ABYBAHkDAUYAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZh" +
           "Y3RUVFcAAgEAAABXAgQAAAB3YXR0AQB3A/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABQZU1lYXN1" +
           "cmVtZW50SUQBAQoYAC4ARAoYAAAABf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MeasurementValueTypeState<float> AcActivePowerTotal
        {
            get
            {
                return m_acActivePowerTotal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acActivePowerTotal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acActivePowerTotal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_acActivePowerTotal != null)
            {
                children.Add(m_acActivePowerTotal);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.AcActivePowerTotal:
                {
                    if (createOrReplace)
                    {
                        if (AcActivePowerTotal == null)
                        {
                            if (replacement == null)
                            {
                                AcActivePowerTotal = new MeasurementValueTypeState<float>(this);
                            }
                            else
                            {
                                AcActivePowerTotal = (MeasurementValueTypeState<float>)replacement;
                            }
                        }
                    }

                    instance = AcActivePowerTotal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MeasurementValueTypeState<float> m_acActivePowerTotal;
        #endregion
    }
    #endif
    #endregion

    #region IEnergyProfileE2TypeState Class
    #if (!OPCUA_EXCLUDE_IEnergyProfileE2TypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IEnergyProfileE2TypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IEnergyProfileE2TypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileE2Type, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAHAAAAElFbmVyZ3lQcm9maWxlRTJUeXBlSW5zdGFu" +
           "Y2UBAfEDAQHxA/EDAAD/////AwAAABVgiQoCAAAAAQAbAAAAQWNBY3RpdmVFbmVyZ3lUb3RhbEV4cG9y" +
           "dExwAQG8FwAvAQHSB7wXAAAACv////8DA/////8EAAAAFWCJCgIAAAABAA0AAABBY2N1cmFjeUNsYXNz" +
           "AQG9FwAuAES9FwAAAQHBC/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY2N1cmFjeURvbWFpbgEB" +
           "vhcALgBEvhcAAAEBwgv/////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEB" +
           "vxcALgBEvxcAABYBAHkDAU4AAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0" +
           "cy91bi9jZWZhY3RSSFcAAgQAAABXwrdoAgkAAAB3YXR0IGhvdXIBAHcD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEADwAAAFBlTWVhc3VyZW1lbnRJRAEBDRgALgBEDRgAAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEAGwAAAEFjQWN0aXZlRW5lcmd5VG90YWxJbXBvcnRMcAEBuBcALwEB0ge4FwAAAAr/////AwP/////" +
           "BAAAABVgiQoCAAAAAQANAAAAQWNjdXJhY3lDbGFzcwEBuRcALgBEuRcAAAEBwQv/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAOAAAAQWNjdXJhY3lEb21haW4BAboXAC4ARLoXAAABAcIL/////wEB/////wAAAAAV" +
           "YKkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAbsXAC4ARLsXAAAWAQB5AwFOAAAALwAAAGh0dHA6" +
           "Ly93d3cub3BjZm91bmRhdGlvbi5vcmcvVUEvdW5pdHMvdW4vY2VmYWN0UkhXAAIEAAAAV8K3aAIJAAAA" +
           "d2F0dCBob3VyAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABQZU1lYXN1cmVtZW50SUQBAQwY" +
           "AC4ARAwYAAAABf////8BAf////8AAAAAFWCJCgIAAAABABIAAABBY0FjdGl2ZVBvd2VyVG90YWwBAbQX" +
           "AC8BAdIHtBcAAAAK/////wMD/////wQAAAAVYIkKAgAAAAEADQAAAEFjY3VyYWN5Q2xhc3MBAbUXAC4A" +
           "RLUXAAABAcEL/////wEB/////wAAAAAVYIkKAgAAAAEADgAAAEFjY3VyYWN5RG9tYWluAQG2FwAuAES2" +
           "FwAAAQHCC/////8BAf////8AAAAAFWCpCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQG3FwAuAES3" +
           "FwAAFgEAeQMBRgAAAC8AAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2Nl" +
           "ZmFjdFRUVwACAQAAAFcCBAAAAHdhdHQBAHcD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBlTWVh" +
           "c3VyZW1lbnRJRAEBCxgALgBECxgAAAAF/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MeasurementValueTypeState<float> AcActiveEnergyTotalExportLp
        {
            get
            {
                return m_acActiveEnergyTotalExportLp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acActiveEnergyTotalExportLp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acActiveEnergyTotalExportLp = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<float> AcActiveEnergyTotalImportLp
        {
            get
            {
                return m_acActiveEnergyTotalImportLp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acActiveEnergyTotalImportLp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acActiveEnergyTotalImportLp = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<float> AcActivePowerTotal
        {
            get
            {
                return m_acActivePowerTotal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acActivePowerTotal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acActivePowerTotal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_acActiveEnergyTotalExportLp != null)
            {
                children.Add(m_acActiveEnergyTotalExportLp);
            }

            if (m_acActiveEnergyTotalImportLp != null)
            {
                children.Add(m_acActiveEnergyTotalImportLp);
            }

            if (m_acActivePowerTotal != null)
            {
                children.Add(m_acActivePowerTotal);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.AcActiveEnergyTotalExportLp:
                {
                    if (createOrReplace)
                    {
                        if (AcActiveEnergyTotalExportLp == null)
                        {
                            if (replacement == null)
                            {
                                AcActiveEnergyTotalExportLp = new MeasurementValueTypeState<float>(this);
                            }
                            else
                            {
                                AcActiveEnergyTotalExportLp = (MeasurementValueTypeState<float>)replacement;
                            }
                        }
                    }

                    instance = AcActiveEnergyTotalExportLp;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcActiveEnergyTotalImportLp:
                {
                    if (createOrReplace)
                    {
                        if (AcActiveEnergyTotalImportLp == null)
                        {
                            if (replacement == null)
                            {
                                AcActiveEnergyTotalImportLp = new MeasurementValueTypeState<float>(this);
                            }
                            else
                            {
                                AcActiveEnergyTotalImportLp = (MeasurementValueTypeState<float>)replacement;
                            }
                        }
                    }

                    instance = AcActiveEnergyTotalImportLp;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcActivePowerTotal:
                {
                    if (createOrReplace)
                    {
                        if (AcActivePowerTotal == null)
                        {
                            if (replacement == null)
                            {
                                AcActivePowerTotal = new MeasurementValueTypeState<float>(this);
                            }
                            else
                            {
                                AcActivePowerTotal = (MeasurementValueTypeState<float>)replacement;
                            }
                        }
                    }

                    instance = AcActivePowerTotal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MeasurementValueTypeState<float> m_acActiveEnergyTotalExportLp;
        private MeasurementValueTypeState<float> m_acActiveEnergyTotalImportLp;
        private MeasurementValueTypeState<float> m_acActivePowerTotal;
        #endregion
    }
    #endif
    #endregion

    #region IEnergyProfileE3TypeState Class
    #if (!OPCUA_EXCLUDE_IEnergyProfileE3TypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IEnergyProfileE3TypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IEnergyProfileE3TypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.IEnergyProfileE3Type, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAHAAAAElFbmVyZ3lQcm9maWxlRTNUeXBlSW5zdGFu" +
           "Y2UBAfIDAQHyA/IDAAD/////CgAAABVgiQoCAAAAAQAbAAAAQWNBY3RpdmVFbmVyZ3lUb3RhbEV4cG9y" +
           "dEhwAQHGFwAvAQHSB8YXAAAAC/////8DA/////8EAAAAFWCJCgIAAAABAA0AAABBY2N1cmFjeUNsYXNz" +
           "AQHHFwAuAETHFwAAAQHBC/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY2N1cmFjeURvbWFpbgEB" +
           "yBcALgBEyBcAAAEBwgv/////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEB" +
           "yRcALgBEyRcAABYBAHkDAU4AAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0" +
           "cy91bi9jZWZhY3RSSFcAAgQAAABXwrdoAgkAAAB3YXR0IGhvdXIBAHcD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEADwAAAFBlTWVhc3VyZW1lbnRJRAEBERgALgBEERgAAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEAGwAAAEFjQWN0aXZlRW5lcmd5VG90YWxJbXBvcnRIcAEBwhcALwEB0gfCFwAAAAv/////AwP/////" +
           "BAAAABVgiQoCAAAAAQANAAAAQWNjdXJhY3lDbGFzcwEBwxcALgBEwxcAAAEBwQv/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAOAAAAQWNjdXJhY3lEb21haW4BAcQXAC4ARMQXAAABAcIL/////wEB/////wAAAAAV" +
           "YKkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAcUXAC4ARMUXAAAWAQB5AwFOAAAALwAAAGh0dHA6" +
           "Ly93d3cub3BjZm91bmRhdGlvbi5vcmcvVUEvdW5pdHMvdW4vY2VmYWN0UkhXAAIEAAAAV8K3aAIJAAAA" +
           "d2F0dCBob3VyAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAA8AAABQZU1lYXN1cmVtZW50SUQBARAY" +
           "AC4ARBAYAAAABf////8BAf////8AAAAAFWCpCgIAAAABAA0AAABBY0FjdGl2ZVBvd2VyAQHAFwAvAQHS" +
           "B8AXAAAWAQGTEwJoAAAAPEFjUGVEYXRhVHlwZSB4bWxucz0iaHR0cDovL29wY2ZvdW5kYXRpb24ub3Jn" +
           "L1VBL1BORU0vVHlwZXMueHNkIj48QT4wPC9BPjxCPjA8L0I+PEM+MDwvQz48L0FjUGVEYXRhVHlwZT4B" +
           "Ab0L/////wMD/////wQAAAAVYIkKAgAAAAEADQAAAEFjY3VyYWN5Q2xhc3MBAeoXAC4AROoXAAABAcEL" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEADgAAAEFjY3VyYWN5RG9tYWluAQHrFwAuAETrFwAAAQHCC///" +
           "//8BAf////8AAAAAFWCpCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQHsFwAuAETsFwAAFgEAeQMB" +
           "RgAAAC8AAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2NlZmFjdFRUVwAC" +
           "AQAAAFcCBAAAAHdhdHQBAHcD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBlTWVhc3VyZW1lbnRJ" +
           "RAEBDhgALgBEDhgAAAAF/////wEB/////wAAAAAVYKkKAgAAAAEACQAAAEFjQ3VycmVudAEB1BcALwEB" +
           "0gfUFwAAFgEBkxMCaAAAADxBY1BlRGF0YVR5cGUgeG1sbnM9Imh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9y" +
           "Zy9VQS9QTkVNL1R5cGVzLnhzZCI+PEE+MDwvQT48Qj4wPC9CPjxDPjA8L0M+PC9BY1BlRGF0YVR5cGU+" +
           "AQG9C/////8DA/////8EAAAAFWCJCgIAAAABAA0AAABBY2N1cmFjeUNsYXNzAQHtFwAuAETtFwAAAQHB" +
           "C/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY2N1cmFjeURvbWFpbgEB7hcALgBE7hcAAAEBwgv/" +
           "////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEB7xcALgBE7xcAABYBAHkD" +
           "AUgAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZhY3RQTUEA" +
           "AgEAAABBAgYAAABhbXBlcmUBAHcD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBlTWVhc3VyZW1l" +
           "bnRJRAEBFhgALgBEFhgAAAAF/////wEB/////wAAAAAVYKkKAgAAAAEADQAAAEFjUG93ZXJGYWN0b3IB" +
           "AdUXAC8BAdIH1RcAABYBAZMTAmgAAAA8QWNQZURhdGFUeXBlIHhtbG5zPSJodHRwOi8vb3BjZm91bmRh" +
           "dGlvbi5vcmcvVUEvUE5FTS9UeXBlcy54c2QiPjxBPjA8L0E+PEI+MDwvQj48Qz4wPC9DPjwvQWNQZURh" +
           "dGFUeXBlPgEBvQv/////AwP/////AwAAABVgiQoCAAAAAQANAAAAQWNjdXJhY3lDbGFzcwEB8BcALgBE" +
           "8BcAAAEBwQv/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAQWNjdXJhY3lEb21haW4BAfEXAC4ARPEX" +
           "AAABAcIL/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBlTWVhc3VyZW1lbnRJRAEBFxgALgBEFxgA" +
           "AAAF/////wEB/////wAAAAAVYIkKAgAAAAEAHQAAAEFjUmVhY3RpdmVFbmVyZ3lUb3RhbEV4cG9ydEhw" +
           "AQHOFwAvAQHSB84XAAAAC/////8DA/////8EAAAAFWCJCgIAAAABAA0AAABBY2N1cmFjeUNsYXNzAQHP" +
           "FwAuAETPFwAAAQHBC/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY2N1cmFjeURvbWFpbgEB0BcA" +
           "LgBE0BcAAAEBwgv/////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEB0RcA" +
           "LgBE0RcAABYBAHkDATkAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91" +
           "bi9jZWZhY3QAAAAAAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBlTWVhc3VyZW1lbnRJ" +
           "RAEBExgALgBEExgAAAAF/////wEB/////wAAAAAVYIkKAgAAAAEAHQAAAEFjUmVhY3RpdmVFbmVyZ3lU" +
           "b3RhbEltcG9ydEhwAQHKFwAvAQHSB8oXAAAAC/////8DA/////8EAAAAFWCJCgIAAAABAA0AAABBY2N1" +
           "cmFjeUNsYXNzAQHLFwAuAETLFwAAAQHBC/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY2N1cmFj" +
           "eURvbWFpbgEBzBcALgBEzBcAAAEBwgv/////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJp" +
           "bmdVbml0cwEBzRcALgBEzRcAABYBAHkDATkAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9y" +
           "Zy9VQS91bml0cy91bi9jZWZhY3QAAAAAAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBl" +
           "TWVhc3VyZW1lbnRJRAEBEhgALgBEEhgAAAAF/////wEB/////wAAAAAVYKkKAgAAAAEADwAAAEFjUmVh" +
           "Y3RpdmVQb3dlcgEBwRcALwEB0gfBFwAAFgEBkxMCaAAAADxBY1BlRGF0YVR5cGUgeG1sbnM9Imh0dHA6" +
           "Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9QTkVNL1R5cGVzLnhzZCI+PEE+MDwvQT48Qj4wPC9CPjxDPjA8" +
           "L0M+PC9BY1BlRGF0YVR5cGU+AQG9C/////8DA/////8EAAAAFWCJCgIAAAABAA0AAABBY2N1cmFjeUNs" +
           "YXNzAQHzFwAuAETzFwAAAQHBC/////8BAf////8AAAAAFWCJCgIAAAABAA4AAABBY2N1cmFjeURvbWFp" +
           "bgEB9BcALgBE9BcAAAEBwgv/////AQH/////AAAAABVgqQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0" +
           "cwEB9RcALgBE9RcAABYBAHkDAUcAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91" +
           "bml0cy91bi9jZWZhY3Q0NEQAAgMAAAB2YXICAwAAAHZhcgEAdwP/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAPAAAAUGVNZWFzdXJlbWVudElEAQEPGAAuAEQPGAAAAAX/////AQH/////AAAAABVgqQoCAAAAAQAL" +
           "AAAAQWNWb2x0YWdlUGUBAdIXAC8BAdIH0hcAABYBAZMTAmgAAAA8QWNQZURhdGFUeXBlIHhtbG5zPSJo" +
           "dHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS9UeXBlcy54c2QiPjxBPjA8L0E+PEI+MDwvQj48" +
           "Qz4wPC9DPjwvQWNQZURhdGFUeXBlPgEBvQv/////AwP/////BAAAABVgiQoCAAAAAQANAAAAQWNjdXJh" +
           "Y3lDbGFzcwEB9hcALgBE9hcAAAEBwQv/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAQWNjdXJhY3lE" +
           "b21haW4BAfcXAC4ARPcXAAABAcIL/////wEB/////wAAAAAVYKkKAgAAAAAAEAAAAEVuZ2luZWVyaW5n" +
           "VW5pdHMBAfgXAC4ARPgXAAAWAQB5AwFGAAAALwAAAGh0dHA6Ly93d3cub3BjZm91bmRhdGlvbi5vcmcv" +
           "VUEvdW5pdHMvdW4vY2VmYWN0VExWAAIBAAAAVgIEAAAAdm9sdAEAdwP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAPAAAAUGVNZWFzdXJlbWVudElEAQEUGAAuAEQUGAAAAAX/////AQH/////AAAAABVgqQoCAAAA" +
           "AQALAAAAQWNWb2x0YWdlUHABAdMXAC8BAdIH0xcAABYBAZYTAnQAAAA8QWNQcERhdGFUeXBlIHhtbG5z" +
           "PSJodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS9UeXBlcy54c2QiPjxBX2I+MDwvQV9iPjxC" +
           "X2M+MDwvQl9jPjxDX2E+MDwvQ19hPjwvQWNQcERhdGFUeXBlPgEBvgv/////AwP/////BAAAABVgiQoC" +
           "AAAAAQANAAAAQWNjdXJhY3lDbGFzcwEB+RcALgBE+RcAAAEBwQv/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAAQWNjdXJhY3lEb21haW4BAfoXAC4ARPoXAAABAcIL/////wEB/////wAAAAAVYKkKAgAAAAAA" +
           "EAAAAEVuZ2luZWVyaW5nVW5pdHMBAfsXAC4ARPsXAAAWAQB5AwFGAAAALwAAAGh0dHA6Ly93d3cub3Bj" +
           "Zm91bmRhdGlvbi5vcmcvVUEvdW5pdHMvdW4vY2VmYWN0VExWAAIBAAAAVgIEAAAAdm9sdAEAdwP/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAPAAAAUGVNZWFzdXJlbWVudElEAQEVGAAuAEQVGAAAAAX/////AQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MeasurementValueTypeState<double> AcActiveEnergyTotalExportHp
        {
            get
            {
                return m_acActiveEnergyTotalExportHp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acActiveEnergyTotalExportHp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acActiveEnergyTotalExportHp = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<double> AcActiveEnergyTotalImportHp
        {
            get
            {
                return m_acActiveEnergyTotalImportHp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acActiveEnergyTotalImportHp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acActiveEnergyTotalImportHp = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<AcPeDataType> AcActivePower
        {
            get
            {
                return m_acActivePower;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acActivePower, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acActivePower = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<AcPeDataType> AcCurrent
        {
            get
            {
                return m_acCurrent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acCurrent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acCurrent = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<AcPeDataType> AcPowerFactor
        {
            get
            {
                return m_acPowerFactor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acPowerFactor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acPowerFactor = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<double> AcReactiveEnergyTotalExportHp
        {
            get
            {
                return m_acReactiveEnergyTotalExportHp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acReactiveEnergyTotalExportHp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acReactiveEnergyTotalExportHp = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<double> AcReactiveEnergyTotalImportHp
        {
            get
            {
                return m_acReactiveEnergyTotalImportHp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acReactiveEnergyTotalImportHp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acReactiveEnergyTotalImportHp = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<AcPeDataType> AcReactivePower
        {
            get
            {
                return m_acReactivePower;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acReactivePower, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acReactivePower = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<AcPeDataType> AcVoltagePe
        {
            get
            {
                return m_acVoltagePe;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acVoltagePe, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acVoltagePe = value;
            }
        }

        /// <remarks />
        public MeasurementValueTypeState<AcPpDataType> AcVoltagePp
        {
            get
            {
                return m_acVoltagePp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acVoltagePp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acVoltagePp = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_acActiveEnergyTotalExportHp != null)
            {
                children.Add(m_acActiveEnergyTotalExportHp);
            }

            if (m_acActiveEnergyTotalImportHp != null)
            {
                children.Add(m_acActiveEnergyTotalImportHp);
            }

            if (m_acActivePower != null)
            {
                children.Add(m_acActivePower);
            }

            if (m_acCurrent != null)
            {
                children.Add(m_acCurrent);
            }

            if (m_acPowerFactor != null)
            {
                children.Add(m_acPowerFactor);
            }

            if (m_acReactiveEnergyTotalExportHp != null)
            {
                children.Add(m_acReactiveEnergyTotalExportHp);
            }

            if (m_acReactiveEnergyTotalImportHp != null)
            {
                children.Add(m_acReactiveEnergyTotalImportHp);
            }

            if (m_acReactivePower != null)
            {
                children.Add(m_acReactivePower);
            }

            if (m_acVoltagePe != null)
            {
                children.Add(m_acVoltagePe);
            }

            if (m_acVoltagePp != null)
            {
                children.Add(m_acVoltagePp);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.AcActiveEnergyTotalExportHp:
                {
                    if (createOrReplace)
                    {
                        if (AcActiveEnergyTotalExportHp == null)
                        {
                            if (replacement == null)
                            {
                                AcActiveEnergyTotalExportHp = new MeasurementValueTypeState<double>(this);
                            }
                            else
                            {
                                AcActiveEnergyTotalExportHp = (MeasurementValueTypeState<double>)replacement;
                            }
                        }
                    }

                    instance = AcActiveEnergyTotalExportHp;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcActiveEnergyTotalImportHp:
                {
                    if (createOrReplace)
                    {
                        if (AcActiveEnergyTotalImportHp == null)
                        {
                            if (replacement == null)
                            {
                                AcActiveEnergyTotalImportHp = new MeasurementValueTypeState<double>(this);
                            }
                            else
                            {
                                AcActiveEnergyTotalImportHp = (MeasurementValueTypeState<double>)replacement;
                            }
                        }
                    }

                    instance = AcActiveEnergyTotalImportHp;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcActivePower:
                {
                    if (createOrReplace)
                    {
                        if (AcActivePower == null)
                        {
                            if (replacement == null)
                            {
                                AcActivePower = new MeasurementValueTypeState<AcPeDataType>(this);
                            }
                            else
                            {
                                AcActivePower = (MeasurementValueTypeState<AcPeDataType>)replacement;
                            }
                        }
                    }

                    instance = AcActivePower;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcCurrent:
                {
                    if (createOrReplace)
                    {
                        if (AcCurrent == null)
                        {
                            if (replacement == null)
                            {
                                AcCurrent = new MeasurementValueTypeState<AcPeDataType>(this);
                            }
                            else
                            {
                                AcCurrent = (MeasurementValueTypeState<AcPeDataType>)replacement;
                            }
                        }
                    }

                    instance = AcCurrent;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcPowerFactor:
                {
                    if (createOrReplace)
                    {
                        if (AcPowerFactor == null)
                        {
                            if (replacement == null)
                            {
                                AcPowerFactor = new MeasurementValueTypeState<AcPeDataType>(this);
                            }
                            else
                            {
                                AcPowerFactor = (MeasurementValueTypeState<AcPeDataType>)replacement;
                            }
                        }
                    }

                    instance = AcPowerFactor;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcReactiveEnergyTotalExportHp:
                {
                    if (createOrReplace)
                    {
                        if (AcReactiveEnergyTotalExportHp == null)
                        {
                            if (replacement == null)
                            {
                                AcReactiveEnergyTotalExportHp = new MeasurementValueTypeState<double>(this);
                            }
                            else
                            {
                                AcReactiveEnergyTotalExportHp = (MeasurementValueTypeState<double>)replacement;
                            }
                        }
                    }

                    instance = AcReactiveEnergyTotalExportHp;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcReactiveEnergyTotalImportHp:
                {
                    if (createOrReplace)
                    {
                        if (AcReactiveEnergyTotalImportHp == null)
                        {
                            if (replacement == null)
                            {
                                AcReactiveEnergyTotalImportHp = new MeasurementValueTypeState<double>(this);
                            }
                            else
                            {
                                AcReactiveEnergyTotalImportHp = (MeasurementValueTypeState<double>)replacement;
                            }
                        }
                    }

                    instance = AcReactiveEnergyTotalImportHp;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcReactivePower:
                {
                    if (createOrReplace)
                    {
                        if (AcReactivePower == null)
                        {
                            if (replacement == null)
                            {
                                AcReactivePower = new MeasurementValueTypeState<AcPeDataType>(this);
                            }
                            else
                            {
                                AcReactivePower = (MeasurementValueTypeState<AcPeDataType>)replacement;
                            }
                        }
                    }

                    instance = AcReactivePower;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcVoltagePe:
                {
                    if (createOrReplace)
                    {
                        if (AcVoltagePe == null)
                        {
                            if (replacement == null)
                            {
                                AcVoltagePe = new MeasurementValueTypeState<AcPeDataType>(this);
                            }
                            else
                            {
                                AcVoltagePe = (MeasurementValueTypeState<AcPeDataType>)replacement;
                            }
                        }
                    }

                    instance = AcVoltagePe;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.AcVoltagePp:
                {
                    if (createOrReplace)
                    {
                        if (AcVoltagePp == null)
                        {
                            if (replacement == null)
                            {
                                AcVoltagePp = new MeasurementValueTypeState<AcPpDataType>(this);
                            }
                            else
                            {
                                AcVoltagePp = (MeasurementValueTypeState<AcPpDataType>)replacement;
                            }
                        }
                    }

                    instance = AcVoltagePp;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MeasurementValueTypeState<double> m_acActiveEnergyTotalExportHp;
        private MeasurementValueTypeState<double> m_acActiveEnergyTotalImportHp;
        private MeasurementValueTypeState<AcPeDataType> m_acActivePower;
        private MeasurementValueTypeState<AcPeDataType> m_acCurrent;
        private MeasurementValueTypeState<AcPeDataType> m_acPowerFactor;
        private MeasurementValueTypeState<double> m_acReactiveEnergyTotalExportHp;
        private MeasurementValueTypeState<double> m_acReactiveEnergyTotalImportHp;
        private MeasurementValueTypeState<AcPeDataType> m_acReactivePower;
        private MeasurementValueTypeState<AcPeDataType> m_acVoltagePe;
        private MeasurementValueTypeState<AcPpDataType> m_acVoltagePp;
        #endregion
    }
    #endif
    #endregion

    #region EnergyDevicePowerOffTypeState Class
    #if (!OPCUA_EXCLUDE_EnergyDevicePowerOffTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EnergyDevicePowerOffTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public EnergyDevicePowerOffTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.EnergyDevicePowerOffType, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAIAAAAEVuZXJneURldmljZVBvd2VyT2ZmVHlwZUlu" +
           "c3RhbmNlAQH0AwEB9AP0AwAA/////wUAAAAVYIkKAgAAAAEAFAAAAE1vZGVQb3dlckNvbnN1bXB0aW9u" +
           "AQHcFwAvAD/cFwAAAAf/////AQH/////AAAAABVgiQoCAAAAAQAUAAAAUmVndWxhclRpbWVUb09wZXJh" +
           "dGUBAdoXAC8AP9oXAAABACIB/////wEB/////wAAAAAEYYIKBAAAAAEADAAAAFN3aXRjaE9mZldPTAEB" +
           "YRsALwEBYRthGwAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHeFwAuAETe" +
           "FwAAlgUAAAABACoBAW0AAAAGAAAATW9kZUlEAAP/////AAAAAAJUAAAASUQgb2YgdGhlIGRlc3RpbmF0" +
           "aW9uIGVuZXJneSBzYXZpbmcgbW9kZSAoMHhGRSkgIGlmIHN1Y2Nlc3NmdWwsIG90aGVyd2lzZSB1bmNo" +
           "YW5nZWQuAQAqAQF8AAAAGAAAAEN1cnJlbnRUaW1lVG9EZXN0aW5hdGlvbgEAIgH/////AAAAAAJPAAAA" +
           "VGltZSBuZWVkZWQgdG8gcmVhY2ggdGhlIGVuZXJneSBzYXZpbmcgbW9kZSBpZiBzdWNjZXNzZnVsLCBv" +
           "dGhlcndpc2UgdW5jaGFuZ2VkLgEAKgEBvgAAABQAAABSZWd1bGFyVGltZVRvT3BlcmF0ZQEAIgH/////" +
           "AAAAAAKVAAAAVGltZSBuZWVkZWQgdG8gcmVhY2ggUEVfcmVhZHlfdG9fb3BlcmF0ZSBhZ2FpbiBpZiB0" +
           "aGUgZGVzdGluYXRpb24gZW5lcmd5IHNhdmluZyBtb2RlIHdpbGwgYmUgcmVndWxhcmx5IHRlcm1pbmF0" +
           "ZWQgaWYgc3VjY2Vzc2Z1bCwgb3RoZXJ3aXNlIHVuY2hhbmdlZC4BACoBAYYAAAATAAAAVGltZU1pbkxl" +
           "bmd0aE9mU3RheQEAIgH/////AAAAAAJeAAAAVGltZSBvZiBtaW5pbXVtIHN0YXkgaW4gdGhlIGRlc3Rp" +
           "bmF0aW9uIGVuZXJneSBzYXZpbmcgbW9kZSBpZiBzdWNjZXNzZnVsLCBvdGhlcndpc2UgdW5jaGFuZ2Vk" +
           "LgEAKgEBRAAAAAoAAABSZXR1cm5Db2RlAAP/////AAAAAAInAAAAUFJPRkllbmVyZ3kgIHJldHVybiBj" +
           "b2RlLiBTZWUgVGFibGUgMTEuAQAoAQEAAAABAAAABQAAAAEB/////wAAAAAVYIkKAgAAAAEADAAAAFRp" +
           "bWVNaW5QYXVzZQEB2xcALwA/2xcAAAEAIgH/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAV09MTWFn" +
           "aWNQYWNrZXQBAd0XAC4ARN0XAAAAD/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<uint> ModePowerConsumption
        {
            get
            {
                return m_modePowerConsumption;
            }

            set
            {
                if (!Object.ReferenceEquals(m_modePowerConsumption, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_modePowerConsumption = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> RegularTimeToOperate
        {
            get
            {
                return m_regularTimeToOperate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_regularTimeToOperate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_regularTimeToOperate = value;
            }
        }

        /// <remarks />
        public SwitchOffWOLMethodState SwitchOffWOL
        {
            get
            {
                return m_switchOffWOLMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_switchOffWOLMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_switchOffWOLMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> TimeMinPause
        {
            get
            {
                return m_timeMinPause;
            }

            set
            {
                if (!Object.ReferenceEquals(m_timeMinPause, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_timeMinPause = value;
            }
        }

        /// <remarks />
        public PropertyState<byte[]> WOLMagicPacket
        {
            get
            {
                return m_wOLMagicPacket;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wOLMagicPacket, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wOLMagicPacket = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_modePowerConsumption != null)
            {
                children.Add(m_modePowerConsumption);
            }

            if (m_regularTimeToOperate != null)
            {
                children.Add(m_regularTimeToOperate);
            }

            if (m_switchOffWOLMethod != null)
            {
                children.Add(m_switchOffWOLMethod);
            }

            if (m_timeMinPause != null)
            {
                children.Add(m_timeMinPause);
            }

            if (m_wOLMagicPacket != null)
            {
                children.Add(m_wOLMagicPacket);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.ModePowerConsumption:
                {
                    if (createOrReplace)
                    {
                        if (ModePowerConsumption == null)
                        {
                            if (replacement == null)
                            {
                                ModePowerConsumption = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                ModePowerConsumption = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = ModePowerConsumption;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.RegularTimeToOperate:
                {
                    if (createOrReplace)
                    {
                        if (RegularTimeToOperate == null)
                        {
                            if (replacement == null)
                            {
                                RegularTimeToOperate = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                RegularTimeToOperate = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = RegularTimeToOperate;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.SwitchOffWOL:
                {
                    if (createOrReplace)
                    {
                        if (SwitchOffWOL == null)
                        {
                            if (replacement == null)
                            {
                                SwitchOffWOL = new SwitchOffWOLMethodState(this);
                            }
                            else
                            {
                                SwitchOffWOL = (SwitchOffWOLMethodState)replacement;
                            }
                        }
                    }

                    instance = SwitchOffWOL;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.TimeMinPause:
                {
                    if (createOrReplace)
                    {
                        if (TimeMinPause == null)
                        {
                            if (replacement == null)
                            {
                                TimeMinPause = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                TimeMinPause = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = TimeMinPause;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.WOLMagicPacket:
                {
                    if (createOrReplace)
                    {
                        if (WOLMagicPacket == null)
                        {
                            if (replacement == null)
                            {
                                WOLMagicPacket = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                WOLMagicPacket = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = WOLMagicPacket;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<uint> m_modePowerConsumption;
        private BaseDataVariableState<double> m_regularTimeToOperate;
        private SwitchOffWOLMethodState m_switchOffWOLMethod;
        private BaseDataVariableState<double> m_timeMinPause;
        private PropertyState<byte[]> m_wOLMagicPacket;
        #endregion
    }
    #endif
    #endregion

    #region EnergyMeasurementTypeState Class
    #if (!OPCUA_EXCLUDE_EnergyMeasurementTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EnergyMeasurementTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public EnergyMeasurementTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.EnergyMeasurementType, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ResetEnergyCounter != null)
            {
                ResetEnergyCounter.Initialize(context, ResetEnergyCounter_InitializationString);
            }
        }

        #region Initialization String
        private const string ResetEnergyCounter_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIKBAAAAAEAEgAAAFJlc2V0RW5lcmd5Q291bnRlcgEBYBsALwEB" +
           "YBtgGwAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAHQAAAEVuZXJneU1lYXN1cmVtZW50VHlwZUluc3Rh" +
           "bmNlAQHuAwEB7gPuAwAA/////wIAAAAVYIkKAgAAAAEADgAAAFBlT2JqZWN0TnVtYmVyAQGnFwAuAESn" +
           "FwAAAAX/////AQH/////AAAAAARhggoEAAAAAQASAAAAUmVzZXRFbmVyZ3lDb3VudGVyAQFgGwAvAQFg" +
           "G2AbAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ushort> PeObjectNumber
        {
            get
            {
                return m_peObjectNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_peObjectNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_peObjectNumber = value;
            }
        }

        /// <remarks />
        public MethodState ResetEnergyCounter
        {
            get
            {
                return m_resetEnergyCounterMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetEnergyCounterMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetEnergyCounterMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_peObjectNumber != null)
            {
                children.Add(m_peObjectNumber);
            }

            if (m_resetEnergyCounterMethod != null)
            {
                children.Add(m_resetEnergyCounterMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.PeObjectNumber:
                {
                    if (createOrReplace)
                    {
                        if (PeObjectNumber == null)
                        {
                            if (replacement == null)
                            {
                                PeObjectNumber = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                PeObjectNumber = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = PeObjectNumber;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.ResetEnergyCounter:
                {
                    if (createOrReplace)
                    {
                        if (ResetEnergyCounter == null)
                        {
                            if (replacement == null)
                            {
                                ResetEnergyCounter = new MethodState(this);
                            }
                            else
                            {
                                ResetEnergyCounter = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ResetEnergyCounter;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ushort> m_peObjectNumber;
        private MethodState m_resetEnergyCounterMethod;
        #endregion
    }
    #endif
    #endregion

    #region EnergySavingModesContainerTypeState Class
    #if (!OPCUA_EXCLUDE_EnergySavingModesContainerTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EnergySavingModesContainerTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public EnergySavingModesContainerTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.EnergySavingModesContainerType, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAJgAAAEVuZXJneVNhdmluZ01vZGVzQ29udGFpbmVy" +
           "VHlwZUluc3RhbmNlAQHsAwEB7APsAwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region EnergySavingModeStatusTypeState Class
    #if (!OPCUA_EXCLUDE_EnergySavingModeStatusTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EnergySavingModeStatusTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public EnergySavingModeStatusTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.EnergySavingModeStatusType, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CurrentTransitionData != null)
            {
                CurrentTransitionData.Initialize(context, CurrentTransitionData_InitializationString);
            }
        }

        #region Initialization String
        private const string CurrentTransitionData_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8VYIkKAgAAAAEAFQAAAEN1cnJlbnRUcmFuc2l0aW9uRGF0YQEBhxcA" +
           "LwA/hxcAAAEBugv/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAIgAAAEVuZXJneVNhdmluZ01vZGVTdGF0dXNUeXBl" +
           "SW5zdGFuY2UBAeoDAQHqA+oDAAD/////AgAAABVgiQoCAAAAAQAVAAAAQ3VycmVudFRyYW5zaXRpb25E" +
           "YXRhAQGHFwAvAD+HFwAAAQG6C/////8BAf////8AAAAAFWCpCgIAAAABABAAAABTdGF0ZUluZm9ybWF0" +
           "aW9uAQGIFwAvAD+IFwAAFgEBjRMCBgEAADxFbmVyZ3lTdGF0ZUluZm9ybWF0aW9uRGF0YVR5cGUgeG1s" +
           "bnM9Imh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9QTkVNL1R5cGVzLnhzZCI+PElEU291cmNlPjA8" +
           "L0lEU291cmNlPjxJRERlc3RpbmF0aW9uPjA8L0lERGVzdGluYXRpb24+PFJlZ3VsYXJUaW1lVG9PcGVy" +
           "YXRlPjA8L1JlZ3VsYXJUaW1lVG9PcGVyYXRlPjxNb2RlUG93ZXJDb25zdW1wdGlvbj4wPC9Nb2RlUG93" +
           "ZXJDb25zdW1wdGlvbj48L0VuZXJneVN0YXRlSW5mb3JtYXRpb25EYXRhVHlwZT4BAbsL/////wEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<StandbyModeTransitionDataType> CurrentTransitionData
        {
            get
            {
                return m_currentTransitionData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_currentTransitionData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentTransitionData = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<EnergyStateInformationDataType> StateInformation
        {
            get
            {
                return m_stateInformation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stateInformation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stateInformation = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_currentTransitionData != null)
            {
                children.Add(m_currentTransitionData);
            }

            if (m_stateInformation != null)
            {
                children.Add(m_stateInformation);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.CurrentTransitionData:
                {
                    if (createOrReplace)
                    {
                        if (CurrentTransitionData == null)
                        {
                            if (replacement == null)
                            {
                                CurrentTransitionData = new BaseDataVariableState<StandbyModeTransitionDataType>(this);
                            }
                            else
                            {
                                CurrentTransitionData = (BaseDataVariableState<StandbyModeTransitionDataType>)replacement;
                            }
                        }
                    }

                    instance = CurrentTransitionData;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.StateInformation:
                {
                    if (createOrReplace)
                    {
                        if (StateInformation == null)
                        {
                            if (replacement == null)
                            {
                                StateInformation = new BaseDataVariableState<EnergyStateInformationDataType>(this);
                            }
                            else
                            {
                                StateInformation = (BaseDataVariableState<EnergyStateInformationDataType>)replacement;
                            }
                        }
                    }

                    instance = StateInformation;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<StandbyModeTransitionDataType> m_currentTransitionData;
        private BaseDataVariableState<EnergyStateInformationDataType> m_stateInformation;
        #endregion
    }
    #endif
    #endregion

    #region EnergySavingModeTypeState Class
    #if (!OPCUA_EXCLUDE_EnergySavingModeTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EnergySavingModeTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public EnergySavingModeTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.EnergySavingModeType, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ID != null)
            {
                ID.Initialize(context, ID_InitializationString);
            }
        }

        #region Initialization String
        private const string ID_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8VYIkKAgAAAAEAAgAAAElEAQGJFwAuAESJFwAAAAP/////AQH/////" +
           "AAAAAA==";

        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAHAAAAEVuZXJneVNhdmluZ01vZGVUeXBlSW5zdGFu" +
           "Y2UBAesDAQHrA+sDAAD/////CgAAABVgiQoCAAAAAQALAAAARHluYW1pY0RhdGEBAYoXAC4ARIoXAAAA" +
           "Af////8BAf////8AAAAAFWCJCgIAAAABABoAAABFbmVyZ3lDb25zdW1wdGlvblRvT3BlcmF0ZQEBlBcA" +
           "LwEAWUSUFwAAAAr/////AQH/////AQAAABVgiQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwEBlRcA" +
           "LgBElRcAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAQAYAAAARW5lcmd5Q29uc3VtcHRpb25Ub1Bh" +
           "dXNlAQGSFwAvAQBZRJIXAAAACv////8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1Vu" +
           "aXRzAQGTFwAuAESTFwAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABAAIAAABJRAEBiRcALgBEiRcA" +
           "AAAD/////wEB/////wAAAAAVYIkKAgAAAAEAFAAAAE1vZGVQb3dlckNvbnN1bXB0aW9uAQGQFwAvAQBZ" +
           "RJAXAAAACv////8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQGRFwAuAESR" +
           "FwAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABABQAAABSZWd1bGFyVGltZVRvT3BlcmF0ZQEBjxcA" +
           "LwA/jxcAAAEAIgH/////AQH/////AAAAABVgiQoCAAAAAQATAAAAVGltZU1heExlbmd0aE9mU3RheQEB" +
           "jhcALwA/jhcAAAEAIgH/////AQH/////AAAAABVgiQoCAAAAAQATAAAAVGltZU1pbkxlbmd0aE9mU3Rh" +
           "eQEBjRcALwA/jRcAAAEAIgH/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAVGltZU1pblBhdXNlAQGL" +
           "FwAvAD+LFwAAAQAiAf////8BAf////8AAAAAFWCJCgIAAAABAAsAAABUaW1lVG9QYXVzZQEBjBcALwA/" +
           "jBcAAAEAIgH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<bool> DynamicData
        {
            get
            {
                return m_dynamicData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dynamicData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dynamicData = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<float> EnergyConsumptionToOperate
        {
            get
            {
                return m_energyConsumptionToOperate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_energyConsumptionToOperate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_energyConsumptionToOperate = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<float> EnergyConsumptionToPause
        {
            get
            {
                return m_energyConsumptionToPause;
            }

            set
            {
                if (!Object.ReferenceEquals(m_energyConsumptionToPause, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_energyConsumptionToPause = value;
            }
        }

        /// <remarks />
        public PropertyState<byte> ID
        {
            get
            {
                return m_iD;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iD, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iD = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<float> ModePowerConsumption
        {
            get
            {
                return m_modePowerConsumption;
            }

            set
            {
                if (!Object.ReferenceEquals(m_modePowerConsumption, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_modePowerConsumption = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> RegularTimeToOperate
        {
            get
            {
                return m_regularTimeToOperate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_regularTimeToOperate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_regularTimeToOperate = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> TimeMaxLengthOfStay
        {
            get
            {
                return m_timeMaxLengthOfStay;
            }

            set
            {
                if (!Object.ReferenceEquals(m_timeMaxLengthOfStay, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_timeMaxLengthOfStay = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> TimeMinLengthOfStay
        {
            get
            {
                return m_timeMinLengthOfStay;
            }

            set
            {
                if (!Object.ReferenceEquals(m_timeMinLengthOfStay, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_timeMinLengthOfStay = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> TimeMinPause
        {
            get
            {
                return m_timeMinPause;
            }

            set
            {
                if (!Object.ReferenceEquals(m_timeMinPause, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_timeMinPause = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> TimeToPause
        {
            get
            {
                return m_timeToPause;
            }

            set
            {
                if (!Object.ReferenceEquals(m_timeToPause, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_timeToPause = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_dynamicData != null)
            {
                children.Add(m_dynamicData);
            }

            if (m_energyConsumptionToOperate != null)
            {
                children.Add(m_energyConsumptionToOperate);
            }

            if (m_energyConsumptionToPause != null)
            {
                children.Add(m_energyConsumptionToPause);
            }

            if (m_iD != null)
            {
                children.Add(m_iD);
            }

            if (m_modePowerConsumption != null)
            {
                children.Add(m_modePowerConsumption);
            }

            if (m_regularTimeToOperate != null)
            {
                children.Add(m_regularTimeToOperate);
            }

            if (m_timeMaxLengthOfStay != null)
            {
                children.Add(m_timeMaxLengthOfStay);
            }

            if (m_timeMinLengthOfStay != null)
            {
                children.Add(m_timeMinLengthOfStay);
            }

            if (m_timeMinPause != null)
            {
                children.Add(m_timeMinPause);
            }

            if (m_timeToPause != null)
            {
                children.Add(m_timeToPause);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.DynamicData:
                {
                    if (createOrReplace)
                    {
                        if (DynamicData == null)
                        {
                            if (replacement == null)
                            {
                                DynamicData = new PropertyState<bool>(this);
                            }
                            else
                            {
                                DynamicData = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = DynamicData;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.EnergyConsumptionToOperate:
                {
                    if (createOrReplace)
                    {
                        if (EnergyConsumptionToOperate == null)
                        {
                            if (replacement == null)
                            {
                                EnergyConsumptionToOperate = new AnalogUnitState<float>(this);
                            }
                            else
                            {
                                EnergyConsumptionToOperate = (AnalogUnitState<float>)replacement;
                            }
                        }
                    }

                    instance = EnergyConsumptionToOperate;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.EnergyConsumptionToPause:
                {
                    if (createOrReplace)
                    {
                        if (EnergyConsumptionToPause == null)
                        {
                            if (replacement == null)
                            {
                                EnergyConsumptionToPause = new AnalogUnitState<float>(this);
                            }
                            else
                            {
                                EnergyConsumptionToPause = (AnalogUnitState<float>)replacement;
                            }
                        }
                    }

                    instance = EnergyConsumptionToPause;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.ID:
                {
                    if (createOrReplace)
                    {
                        if (ID == null)
                        {
                            if (replacement == null)
                            {
                                ID = new PropertyState<byte>(this);
                            }
                            else
                            {
                                ID = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = ID;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.ModePowerConsumption:
                {
                    if (createOrReplace)
                    {
                        if (ModePowerConsumption == null)
                        {
                            if (replacement == null)
                            {
                                ModePowerConsumption = new AnalogUnitState<float>(this);
                            }
                            else
                            {
                                ModePowerConsumption = (AnalogUnitState<float>)replacement;
                            }
                        }
                    }

                    instance = ModePowerConsumption;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.RegularTimeToOperate:
                {
                    if (createOrReplace)
                    {
                        if (RegularTimeToOperate == null)
                        {
                            if (replacement == null)
                            {
                                RegularTimeToOperate = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                RegularTimeToOperate = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = RegularTimeToOperate;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.TimeMaxLengthOfStay:
                {
                    if (createOrReplace)
                    {
                        if (TimeMaxLengthOfStay == null)
                        {
                            if (replacement == null)
                            {
                                TimeMaxLengthOfStay = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                TimeMaxLengthOfStay = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = TimeMaxLengthOfStay;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.TimeMinLengthOfStay:
                {
                    if (createOrReplace)
                    {
                        if (TimeMinLengthOfStay == null)
                        {
                            if (replacement == null)
                            {
                                TimeMinLengthOfStay = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                TimeMinLengthOfStay = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = TimeMinLengthOfStay;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.TimeMinPause:
                {
                    if (createOrReplace)
                    {
                        if (TimeMinPause == null)
                        {
                            if (replacement == null)
                            {
                                TimeMinPause = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                TimeMinPause = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = TimeMinPause;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.TimeToPause:
                {
                    if (createOrReplace)
                    {
                        if (TimeToPause == null)
                        {
                            if (replacement == null)
                            {
                                TimeToPause = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                TimeToPause = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = TimeToPause;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<bool> m_dynamicData;
        private AnalogUnitState<float> m_energyConsumptionToOperate;
        private AnalogUnitState<float> m_energyConsumptionToPause;
        private PropertyState<byte> m_iD;
        private AnalogUnitState<float> m_modePowerConsumption;
        private BaseDataVariableState<double> m_regularTimeToOperate;
        private BaseDataVariableState<double> m_timeMaxLengthOfStay;
        private BaseDataVariableState<double> m_timeMinLengthOfStay;
        private BaseDataVariableState<double> m_timeMinPause;
        private BaseDataVariableState<double> m_timeToPause;
        #endregion
    }
    #endif
    #endregion

    #region EnergyStandbyManagementTypeState Class
    #if (!OPCUA_EXCLUDE_EnergyStandbyManagementTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EnergyStandbyManagementTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public EnergyStandbyManagementTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.EnergyStandbyManagementType, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (EndPause != null)
            {
                EndPause.Initialize(context, EndPause_InitializationString);
            }

            if (EnergySavingModes != null)
            {
                EnergySavingModes.Initialize(context, EnergySavingModes_InitializationString);
            }

            if (Lock != null)
            {
                Lock.Initialize(context, Lock_InitializationString);
            }

            if (StartPause != null)
            {
                StartPause.Initialize(context, StartPause_InitializationString);
            }

            if (SwitchToEnergySavingMode != null)
            {
                SwitchToEnergySavingMode.Initialize(context, SwitchToEnergySavingMode_InitializationString);
            }
        }

        #region Initialization String
        private const string EndPause_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIKBAAAAAEACAAAAEVuZFBhdXNlAQFeGwAvAQFeG14bAAABAf//" +
           "//8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaYXAC4ARKYXAACWAgAAAAEAKgEBdQAA" +
           "ABQAAABDdXJyZW50VGltZVRvT3BlcmF0ZQEAIgH/////AAAAAAJMAAAAVGltZSBuZWVkZWQgdG8gcmVh" +
           "Y2ggUEVfcmVhZHlfdG9fb3BlcmF0ZSBpZiBzdWNjZXNzZnVsLCBvdGhlcndpc2UgdW5jaGFuZ2VkLgEA" +
           "KgEBSgAAAAoAAABSZXR1cm5Db2RlAAP/////AAAAAAItAAAAUFJPRkllbmVyZ3kgIHJldHVybiBjb2Rl" +
           "LiBTZWUgdGFibGUgVGFibGUgMTEuAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA=";

        private const string EnergySavingModes_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIAKAQAAAAEAEQAAAEVuZXJneVNhdmluZ01vZGVzAQGaEwAvAQHs" +
           "A5oTAAD/////AAAAAA==";

        private const string Lock_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIAKAQAAAAEABAAAAExvY2sBAZwTAC8BAvQYnBMAAP////8IAAAA" +
           "FWCJCgIAAAACAAYAAABMb2NrZWQBAZ0XAC4ARJ0XAAAAAf////8BAf////8AAAAAFWCJCgIAAAACAA0A" +
           "AABMb2NraW5nQ2xpZW50AQGeFwAuAESeFwAAAAz/////AQH/////AAAAABVgiQoCAAAAAgALAAAATG9j" +
           "a2luZ1VzZXIBAZ8XAC4ARJ8XAAAADP////8BAf////8AAAAAFWCJCgIAAAACABEAAABSZW1haW5pbmdM" +
           "b2NrVGltZQEBoBcALgBEoBcAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAgAIAAAASW5pdExvY2sB" +
           "AVsbAC8BAvkYWxsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGbFwAuAESb" +
           "FwAAlgEAAAABACoBARYAAAAHAAAAQ29udGV4dAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBnBcALgBEnBcAAJYBAAAAAQAqAQEdAAAA" +
           "DgAAAEluaXRMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoE" +
           "AAAAAgAJAAAAUmVuZXdMb2NrAQFcGwAvAQL8GFwbAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAaEXAC4ARKEXAACWAQAAAAEAKgEBHgAAAA8AAABSZW5ld0xvY2tTdGF0dXMABv//" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAACAAgAAABFeGl0TG9jawEBWhsA" +
           "LwEC/hhaGwAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGaFwAuAESaFwAA" +
           "lgEAAAABACoBAR0AAAAOAAAARXhpdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAABGGCCgQAAAACAAkAAABCcmVha0xvY2sBAVkbAC8BAgAZWRsAAAEB/////wEAAAAXYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBmRcALgBEmRcAAJYBAAAAAQAqAQEeAAAADwAAAEJyZWFr" +
           "TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string StartPause_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIKBAAAAAEACgAAAFN0YXJ0UGF1c2UBAV0bAC8BAV0bXRsAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGiFwAuAESiFwAAlgEAAAABACoBATMA" +
           "AAAJAAAAUGF1c2VUaW1lAQAiAf////8AAAAAAhUAAABSZXF1ZXN0ZWQgcGF1c2UgdGltZS4BACgBAQAA" +
           "AAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGjFwAuAESjFwAA" +
           "lgUAAAABACoBAWUAAAAGAAAATW9kZUlEAAP/////AAAAAAJMAAAASUQgb2YgdGhlIGRlc3RpbmF0aW9u" +
           "IGVuZXJneSBzYXZpbmcgbW9kZSBpZiBzdWNjZXNzZnVsLCBvdGhlcndpc2UgdW5jaGFuZ2VkLgEAKgEB" +
           "fAAAABgAAABDdXJyZW50VGltZVRvRGVzdGluYXRpb24BACIB/////wAAAAACTwAAAFRpbWUgbmVlZGVk" +
           "IHRvIHJlYWNoIHRoZSBlbmVyZ3kgc2F2aW5nIG1vZGUgaWYgc3VjY2Vzc2Z1bCwgb3RoZXJ3aXNlIHVu" +
           "Y2hhbmdlZC4BACoBAb4AAAAUAAAAUmVndWxhclRpbWVUb09wZXJhdGUBACIB/////wAAAAAClQAAAFRp" +
           "bWUgbmVlZGVkIHRvIHJlYWNoIFBFX3JlYWR5X3RvX29wZXJhdGUgYWdhaW4gaWYgdGhlIGRlc3RpbmF0" +
           "aW9uIGVuZXJneSBzYXZpbmcgbW9kZSB3aWxsIGJlIHJlZ3VsYXJseSB0ZXJtaW5hdGVkIGlmIHN1Y2Nl" +
           "c3NmdWwsIG90aGVyd2lzZSB1bmNoYW5nZWQuAQAqAQGGAAAAEwAAAFRpbWVNaW5MZW5ndGhUb1N0YXkB" +
           "ACIB/////wAAAAACXgAAAFRpbWUgb2YgbWluaW11bSBzdGF5IGluIHRoZSBkZXN0aW5hdGlvbiBlbmVy" +
           "Z3kgc2F2aW5nIG1vZGUgaWYgc3VjY2Vzc2Z1bCwgb3RoZXJ3aXNlIHVuY2hhbmdlZC4BACoBAUMAAAAK" +
           "AAAAUmV0dXJuQ29kZQAD/////wAAAAACJgAAAFBST0ZJZW5lcmd5IHJldHVybiBjb2RlLiBTZWUgVGFi" +
           "bGUgMTEuAQAoAQEAAAABAAAABQAAAAEB/////wAAAAA=";

        private const string SwitchToEnergySavingMode_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIKBAAAAAEAGAAAAFN3aXRjaFRvRW5lcmd5U2F2aW5nTW9kZQEB" +
           "XxsALwEBXxtfGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaQXAC4ARKQX" +
           "AACWAQAAAAEAKgEBQAAAAAYAAABNb2RlSUQAA/////8AAAAAAicAAABJRCBvZiB0aGUgcmVxdWVzdGVk" +
           "IGVuZXJneSBzYXZpbmcgbW9kZS4BACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQGlFwAuAESlFwAAlgUAAAABACoBAYQAAAAPAAAARWZmZWN0aXZlTW9kZUlE" +
           "AAP/////AAAAAAJiAAAASUQgb2YgdGhlIGVmZmVjdGl2ZWx5IGNob3NlbiBkZXN0aW5hdGlvbiBlbmVy" +
           "Z3kgc2F2aW5nIG1vZGUgaWYgc3VjY2Vzc2Z1bCwgb3RoZXJ3aXNlIGN1cnJlbnQgbW9kZS4BACoBAYgA" +
           "AAAYAAAAQ3VycmVudFRpbWVUb0Rlc3RpbmF0aW9uAQAiAf////8AAAAAAlsAAABUaW1lIG5lZWRlZCB0" +
           "byByZWFjaCB0aGUgZGVzdGluYXRpb24gZW5lcmd5IHNhdmluZyBtb2RlIGlmIHN1Y2Nlc3NmdWwsIG90" +
           "aGVyd2lzZSB1bmNoYW5nZWQuAQAqAQG+AAAAFAAAAFJlZ3VsYXJUaW1lVG9PcGVyYXRlAQAiAf////8A" +
           "AAAAApUAAABUaW1lIG5lZWRlZCB0byByZWFjaCBQRV9yZWFkeV90b19vcGVyYXRlIGFnYWluIGlmIHRo" +
           "ZSBkZXN0aW5hdGlvbiBlbmVyZ3kgc2F2aW5nIG1vZGUgd2lsbCBiZSByZWd1bGFybHkgdGVybWluYXRl" +
           "ZCBpZiBzdWNjZXNzZnVsLCBvdGhlcndpc2UgdW5jaGFuZ2VkLgEAKgEBhgAAABMAAABUaW1lTWluTGVu" +
           "Z3RoT2ZTdGF5AQAiAf////8AAAAAAl4AAABUaW1lIG9mIG1pbmltdW0gc3RheSBpbiB0aGUgZGVzdGlu" +
           "YXRpb24gZW5lcmd5IHNhdmluZyBtb2RlIGlmIHN1Y2Nlc3NmdWwsIG90aGVyd2lzZSB1bmNoYW5nZWQu" +
           "AQAqAQE9AAAACgAAAFJldHVybkNvZGUAA/////8AAAAAAiAAAABSZXR1cm4gY29kZS4gU2VlIHRhYmxl" +
           "IFRhYmxlIDExLgEAKAEBAAAAAQAAAAUAAAABAf////8AAAAA";

        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAIwAAAEVuZXJneVN0YW5kYnlNYW5hZ2VtZW50VHlw" +
           "ZUluc3RhbmNlAQHtAwEB7QPtAwAA/////wgAAAAEYYIKBAAAAAEACAAAAEVuZFBhdXNlAQFeGwAvAQFe" +
           "G14bAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaYXAC4ARKYXAACWAgAA" +
           "AAEAKgEBdQAAABQAAABDdXJyZW50VGltZVRvT3BlcmF0ZQEAIgH/////AAAAAAJMAAAAVGltZSBuZWVk" +
           "ZWQgdG8gcmVhY2ggUEVfcmVhZHlfdG9fb3BlcmF0ZSBpZiBzdWNjZXNzZnVsLCBvdGhlcndpc2UgdW5j" +
           "aGFuZ2VkLgEAKgEBSgAAAAoAAABSZXR1cm5Db2RlAAP/////AAAAAAItAAAAUFJPRkllbmVyZ3kgIHJl" +
           "dHVybiBjb2RlLiBTZWUgdGFibGUgVGFibGUgMTEuAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAEYIAK" +
           "AQAAAAEAEQAAAEVuZXJneVNhdmluZ01vZGVzAQGaEwAvAQHsA5oTAAD/////AAAAAARggAoBAAAAAQAW" +
           "AAAARW5lcmd5U2F2aW5nTW9kZVN0YXR1cwEBmRMALwEB6gOZEwAA/////wEAAAAVYKkKAgAAAAEAEAAA" +
           "AFN0YXRlSW5mb3JtYXRpb24BAZcXAC8AP5cXAAAWAQGNEwIGAQAAPEVuZXJneVN0YXRlSW5mb3JtYXRp" +
           "b25EYXRhVHlwZSB4bWxucz0iaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1BORU0vVHlwZXMueHNk" +
           "Ij48SURTb3VyY2U+MDwvSURTb3VyY2U+PElERGVzdGluYXRpb24+MDwvSUREZXN0aW5hdGlvbj48UmVn" +
           "dWxhclRpbWVUb09wZXJhdGU+MDwvUmVndWxhclRpbWVUb09wZXJhdGU+PE1vZGVQb3dlckNvbnN1bXB0" +
           "aW9uPjA8L01vZGVQb3dlckNvbnN1bXB0aW9uPjwvRW5lcmd5U3RhdGVJbmZvcm1hdGlvbkRhdGFUeXBl" +
           "PgEBuwv/////AQH/////AAAAAARggAoBAAAAAQAEAAAATG9jawEBnBMALwEC9BicEwAA/////wgAAAAV" +
           "YIkKAgAAAAIABgAAAExvY2tlZAEBnRcALgBEnRcAAAAB/////wEB/////wAAAAAVYIkKAgAAAAIADQAA" +
           "AExvY2tpbmdDbGllbnQBAZ4XAC4ARJ4XAAAADP////8BAf////8AAAAAFWCJCgIAAAACAAsAAABMb2Nr" +
           "aW5nVXNlcgEBnxcALgBEnxcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAIAEQAAAFJlbWFpbmluZ0xv" +
           "Y2tUaW1lAQGgFwAuAESgFwAAAQAiAf////8BAf////8AAAAABGGCCgQAAAACAAgAAABJbml0TG9jawEB" +
           "WxsALwEC+RhbGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZsXAC4ARJsX" +
           "AACWAQAAAAEAKgEBFgAAAAcAAABDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGcFwAuAEScFwAAlgEAAAABACoBAR0AAAAO" +
           "AAAASW5pdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQA" +
           "AAACAAkAAABSZW5ld0xvY2sBAVwbAC8BAvwYXBsAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBoRcALgBEoRcAAJYBAAAAAQAqAQEeAAAADwAAAFJlbmV3TG9ja1N0YXR1cwAG////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAIACAAAAEV4aXRMb2NrAQFaGwAv" +
           "AQL+GFobAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZoXAC4ARJoXAACW" +
           "AQAAAAEAKgEBHQAAAA4AAABFeGl0TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAIACQAAAEJyZWFrTG9jawEBWRsALwECABlZGwAAAQH/////AQAAABdgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGZFwAuAESZFwAAlgEAAAABACoBAR4AAAAPAAAAQnJlYWtM" +
           "b2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAJAAAA" +
           "UGF1c2VUaW1lAQGYFwAvAD+YFwAAAQAiAf////8BAf////8AAAAAFWCJCgIAAAABABcAAABTdGFuZGJ5" +
           "TWFuYWdlbWVudFN0YXR1cwEBgBcALwEASAmAFwAAAAP/////AQH/////AQAAABdgqQoCAAAAAAALAAAA" +
           "RW51bVN0cmluZ3MBAZYXAC4ARJYXAACVCQAAAAIWAAAARW5lcmd5IHNhdmluZyBkaXNhYmxlZAIJAAAA" +
           "UG93ZXIgT2ZmAhAAAABSZWFkeSB0byBvcGVyYXRlAhwAAABNb3ZpbmcgdG8gRW5lcmd5IFNhdmluZyBN" +
           "b2RlAhIAAABFbmVyZ3kgc2F2aW5nIG1vZGUCGgAAAE1vdmluZyB0byByZWFkeSB0byBvcGVyYXRlAhgA" +
           "AABNb3ZpbmcgdG8gU2xlZXAgbW9kZSBXT0wCDgAAAFNsZWVwIG1vZGUgV09MAgsAAABXYWtlIHVwIFdP" +
           "TAAVAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAKAAAAU3RhcnRQYXVzZQEBXRsALwEBXRtd" +
           "GwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaIXAC4ARKIXAACWAQAAAAEA" +
           "KgEBMwAAAAkAAABQYXVzZVRpbWUBACIB/////wAAAAACFQAAAFJlcXVlc3RlZCBwYXVzZSB0aW1lLgEA" +
           "KAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaMXAC4A" +
           "RKMXAACWBQAAAAEAKgEBZQAAAAYAAABNb2RlSUQAA/////8AAAAAAkwAAABJRCBvZiB0aGUgZGVzdGlu" +
           "YXRpb24gZW5lcmd5IHNhdmluZyBtb2RlIGlmIHN1Y2Nlc3NmdWwsIG90aGVyd2lzZSB1bmNoYW5nZWQu" +
           "AQAqAQF8AAAAGAAAAEN1cnJlbnRUaW1lVG9EZXN0aW5hdGlvbgEAIgH/////AAAAAAJPAAAAVGltZSBu" +
           "ZWVkZWQgdG8gcmVhY2ggdGhlIGVuZXJneSBzYXZpbmcgbW9kZSBpZiBzdWNjZXNzZnVsLCBvdGhlcndp" +
           "c2UgdW5jaGFuZ2VkLgEAKgEBvgAAABQAAABSZWd1bGFyVGltZVRvT3BlcmF0ZQEAIgH/////AAAAAAKV" +
           "AAAAVGltZSBuZWVkZWQgdG8gcmVhY2ggUEVfcmVhZHlfdG9fb3BlcmF0ZSBhZ2FpbiBpZiB0aGUgZGVz" +
           "dGluYXRpb24gZW5lcmd5IHNhdmluZyBtb2RlIHdpbGwgYmUgcmVndWxhcmx5IHRlcm1pbmF0ZWQgaWYg" +
           "c3VjY2Vzc2Z1bCwgb3RoZXJ3aXNlIHVuY2hhbmdlZC4BACoBAYYAAAATAAAAVGltZU1pbkxlbmd0aFRv" +
           "U3RheQEAIgH/////AAAAAAJeAAAAVGltZSBvZiBtaW5pbXVtIHN0YXkgaW4gdGhlIGRlc3RpbmF0aW9u" +
           "IGVuZXJneSBzYXZpbmcgbW9kZSBpZiBzdWNjZXNzZnVsLCBvdGhlcndpc2UgdW5jaGFuZ2VkLgEAKgEB" +
           "QwAAAAoAAABSZXR1cm5Db2RlAAP/////AAAAAAImAAAAUFJPRkllbmVyZ3kgcmV0dXJuIGNvZGUuIFNl" +
           "ZSBUYWJsZSAxMS4BACgBAQAAAAEAAAAFAAAAAQH/////AAAAAARhggoEAAAAAQAYAAAAU3dpdGNoVG9F" +
           "bmVyZ3lTYXZpbmdNb2RlAQFfGwAvAQFfG18bAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBpBcALgBEpBcAAJYBAAAAAQAqAQFAAAAABgAAAE1vZGVJRAAD/////wAAAAACJwAAAElE" +
           "IG9mIHRoZSByZXF1ZXN0ZWQgZW5lcmd5IHNhdmluZyBtb2RlLgEAKAEBAAAAAQAAAAEAAAABAf////8A" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaUXAC4ARKUXAACWBQAAAAEAKgEBhAAAAA8A" +
           "AABFZmZlY3RpdmVNb2RlSUQAA/////8AAAAAAmIAAABJRCBvZiB0aGUgZWZmZWN0aXZlbHkgY2hvc2Vu" +
           "IGRlc3RpbmF0aW9uIGVuZXJneSBzYXZpbmcgbW9kZSBpZiBzdWNjZXNzZnVsLCBvdGhlcndpc2UgY3Vy" +
           "cmVudCBtb2RlLgEAKgEBiAAAABgAAABDdXJyZW50VGltZVRvRGVzdGluYXRpb24BACIB/////wAAAAAC" +
           "WwAAAFRpbWUgbmVlZGVkIHRvIHJlYWNoIHRoZSBkZXN0aW5hdGlvbiBlbmVyZ3kgc2F2aW5nIG1vZGUg" +
           "aWYgc3VjY2Vzc2Z1bCwgb3RoZXJ3aXNlIHVuY2hhbmdlZC4BACoBAb4AAAAUAAAAUmVndWxhclRpbWVU" +
           "b09wZXJhdGUBACIB/////wAAAAAClQAAAFRpbWUgbmVlZGVkIHRvIHJlYWNoIFBFX3JlYWR5X3RvX29w" +
           "ZXJhdGUgYWdhaW4gaWYgdGhlIGRlc3RpbmF0aW9uIGVuZXJneSBzYXZpbmcgbW9kZSB3aWxsIGJlIHJl" +
           "Z3VsYXJseSB0ZXJtaW5hdGVkIGlmIHN1Y2Nlc3NmdWwsIG90aGVyd2lzZSB1bmNoYW5nZWQuAQAqAQGG" +
           "AAAAEwAAAFRpbWVNaW5MZW5ndGhPZlN0YXkBACIB/////wAAAAACXgAAAFRpbWUgb2YgbWluaW11bSBz" +
           "dGF5IGluIHRoZSBkZXN0aW5hdGlvbiBlbmVyZ3kgc2F2aW5nIG1vZGUgaWYgc3VjY2Vzc2Z1bCwgb3Ro" +
           "ZXJ3aXNlIHVuY2hhbmdlZC4BACoBAT0AAAAKAAAAUmV0dXJuQ29kZQAD/////wAAAAACIAAAAFJldHVy" +
           "biBjb2RlLiBTZWUgdGFibGUgVGFibGUgMTEuAQAoAQEAAAABAAAABQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public EndPauseMethodState EndPause
        {
            get
            {
                return m_endPauseMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_endPauseMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_endPauseMethod = value;
            }
        }

        /// <remarks />
        public EnergySavingModesContainerTypeState EnergySavingModes
        {
            get
            {
                return m_energySavingModes;
            }

            set
            {
                if (!Object.ReferenceEquals(m_energySavingModes, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_energySavingModes = value;
            }
        }

        /// <remarks />
        public EnergySavingModeStatusTypeState EnergySavingModeStatus
        {
            get
            {
                return m_energySavingModeStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_energySavingModeStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_energySavingModeStatus = value;
            }
        }

        /// <remarks />
        public LockingServicesTypeState Lock
        {
            get
            {
                return m_lock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lock = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> PauseTime
        {
            get
            {
                return m_pauseTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pauseTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pauseTime = value;
            }
        }

        /// <remarks />
        public MultiStateDiscreteState<byte> StandbyManagementStatus
        {
            get
            {
                return m_standbyManagementStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_standbyManagementStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_standbyManagementStatus = value;
            }
        }

        /// <remarks />
        public StartPauseMethodState StartPause
        {
            get
            {
                return m_startPauseMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startPauseMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startPauseMethod = value;
            }
        }

        /// <remarks />
        public SwitchToEnergySavingModeMethodState SwitchToEnergySavingMode
        {
            get
            {
                return m_switchToEnergySavingModeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_switchToEnergySavingModeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_switchToEnergySavingModeMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_endPauseMethod != null)
            {
                children.Add(m_endPauseMethod);
            }

            if (m_energySavingModes != null)
            {
                children.Add(m_energySavingModes);
            }

            if (m_energySavingModeStatus != null)
            {
                children.Add(m_energySavingModeStatus);
            }

            if (m_lock != null)
            {
                children.Add(m_lock);
            }

            if (m_pauseTime != null)
            {
                children.Add(m_pauseTime);
            }

            if (m_standbyManagementStatus != null)
            {
                children.Add(m_standbyManagementStatus);
            }

            if (m_startPauseMethod != null)
            {
                children.Add(m_startPauseMethod);
            }

            if (m_switchToEnergySavingModeMethod != null)
            {
                children.Add(m_switchToEnergySavingModeMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.EndPause:
                {
                    if (createOrReplace)
                    {
                        if (EndPause == null)
                        {
                            if (replacement == null)
                            {
                                EndPause = new EndPauseMethodState(this);
                            }
                            else
                            {
                                EndPause = (EndPauseMethodState)replacement;
                            }
                        }
                    }

                    instance = EndPause;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.EnergySavingModes:
                {
                    if (createOrReplace)
                    {
                        if (EnergySavingModes == null)
                        {
                            if (replacement == null)
                            {
                                EnergySavingModes = new EnergySavingModesContainerTypeState(this);
                            }
                            else
                            {
                                EnergySavingModes = (EnergySavingModesContainerTypeState)replacement;
                            }
                        }
                    }

                    instance = EnergySavingModes;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.EnergySavingModeStatus:
                {
                    if (createOrReplace)
                    {
                        if (EnergySavingModeStatus == null)
                        {
                            if (replacement == null)
                            {
                                EnergySavingModeStatus = new EnergySavingModeStatusTypeState(this);
                            }
                            else
                            {
                                EnergySavingModeStatus = (EnergySavingModeStatusTypeState)replacement;
                            }
                        }
                    }

                    instance = EnergySavingModeStatus;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.Lock:
                {
                    if (createOrReplace)
                    {
                        if (Lock == null)
                        {
                            if (replacement == null)
                            {
                                Lock = new LockingServicesTypeState(this);
                            }
                            else
                            {
                                Lock = (LockingServicesTypeState)replacement;
                            }
                        }
                    }

                    instance = Lock;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.PauseTime:
                {
                    if (createOrReplace)
                    {
                        if (PauseTime == null)
                        {
                            if (replacement == null)
                            {
                                PauseTime = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                PauseTime = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = PauseTime;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.StandbyManagementStatus:
                {
                    if (createOrReplace)
                    {
                        if (StandbyManagementStatus == null)
                        {
                            if (replacement == null)
                            {
                                StandbyManagementStatus = new MultiStateDiscreteState<byte>(this);
                            }
                            else
                            {
                                StandbyManagementStatus = (MultiStateDiscreteState<byte>)replacement;
                            }
                        }
                    }

                    instance = StandbyManagementStatus;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.StartPause:
                {
                    if (createOrReplace)
                    {
                        if (StartPause == null)
                        {
                            if (replacement == null)
                            {
                                StartPause = new StartPauseMethodState(this);
                            }
                            else
                            {
                                StartPause = (StartPauseMethodState)replacement;
                            }
                        }
                    }

                    instance = StartPause;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.SwitchToEnergySavingMode:
                {
                    if (createOrReplace)
                    {
                        if (SwitchToEnergySavingMode == null)
                        {
                            if (replacement == null)
                            {
                                SwitchToEnergySavingMode = new SwitchToEnergySavingModeMethodState(this);
                            }
                            else
                            {
                                SwitchToEnergySavingMode = (SwitchToEnergySavingModeMethodState)replacement;
                            }
                        }
                    }

                    instance = SwitchToEnergySavingMode;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private EndPauseMethodState m_endPauseMethod;
        private EnergySavingModesContainerTypeState m_energySavingModes;
        private EnergySavingModeStatusTypeState m_energySavingModeStatus;
        private LockingServicesTypeState m_lock;
        private BaseDataVariableState<double> m_pauseTime;
        private MultiStateDiscreteState<byte> m_standbyManagementStatus;
        private StartPauseMethodState m_startPauseMethod;
        private SwitchToEnergySavingModeMethodState m_switchToEnergySavingModeMethod;
        #endregion
    }
    #endif
    #endregion

    #region PeServiceAccessPointTypeState Class
    #if (!OPCUA_EXCLUDE_PeServiceAccessPointTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PeServiceAccessPointTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public PeServiceAccessPointTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.PnEm.ObjectTypes.PeServiceAccessPointType, Opc.Ua.PnEm.Namespaces.PnEm, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (PeClass != null)
            {
                PeClass.Initialize(context, PeClass_InitializationString);
            }

            if (PeSubclass != null)
            {
                PeSubclass.Initialize(context, PeSubclass_InitializationString);
            }

            if (PeVersion != null)
            {
                PeVersion.Initialize(context, PeVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string PeClass_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8VYIkKAgAAAAEABwAAAFBlQ2xhc3MBAeAXAC4AROAXAAABAb8L////" +
           "/wMD/////wAAAAA=";

        private const string PeSubclass_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8VYIkKAgAAAAEACgAAAFBlU3ViY2xhc3MBAeEXAC4AROEXAAABAcAL" +
           "/////wMD/////wAAAAA=";

        private const string PeVersion_InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8VYIkKAgAAAAEACQAAAFBlVmVyc2lvbgEB4hcALgBE4hcAAAEBvAv/" +
           "////AwP/////AAAAAA==";

        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAIAAAAFBlU2VydmljZUFjY2Vzc1BvaW50VHlwZUlu" +
           "c3RhbmNlAQH1AwEB9QP1AwAA/////wMAAAAVYIkKAgAAAAEABwAAAFBlQ2xhc3MBAeAXAC4AROAXAAAB" +
           "Ab8L/////wMD/////wAAAAAVYIkKAgAAAAEACgAAAFBlU3ViY2xhc3MBAeEXAC4AROEXAAABAcAL////" +
           "/wMD/////wAAAAAVYIkKAgAAAAEACQAAAFBlVmVyc2lvbgEB4hcALgBE4hcAAAEBvAv/////AwP/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<PeClassEnumeration> PeClass
        {
            get
            {
                return m_peClass;
            }

            set
            {
                if (!Object.ReferenceEquals(m_peClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_peClass = value;
            }
        }

        /// <remarks />
        public PropertyState<PeSubclassEnumeration> PeSubclass
        {
            get
            {
                return m_peSubclass;
            }

            set
            {
                if (!Object.ReferenceEquals(m_peSubclass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_peSubclass = value;
            }
        }

        /// <remarks />
        public PropertyState<PeVersionDataType> PeVersion
        {
            get
            {
                return m_peVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_peVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_peVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_peClass != null)
            {
                children.Add(m_peClass);
            }

            if (m_peSubclass != null)
            {
                children.Add(m_peSubclass);
            }

            if (m_peVersion != null)
            {
                children.Add(m_peVersion);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.PnEm.BrowseNames.PeClass:
                {
                    if (createOrReplace)
                    {
                        if (PeClass == null)
                        {
                            if (replacement == null)
                            {
                                PeClass = new PropertyState<PeClassEnumeration>(this);
                            }
                            else
                            {
                                PeClass = (PropertyState<PeClassEnumeration>)replacement;
                            }
                        }
                    }

                    instance = PeClass;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.PeSubclass:
                {
                    if (createOrReplace)
                    {
                        if (PeSubclass == null)
                        {
                            if (replacement == null)
                            {
                                PeSubclass = new PropertyState<PeSubclassEnumeration>(this);
                            }
                            else
                            {
                                PeSubclass = (PropertyState<PeSubclassEnumeration>)replacement;
                            }
                        }
                    }

                    instance = PeSubclass;
                    break;
                }

                case Opc.Ua.PnEm.BrowseNames.PeVersion:
                {
                    if (createOrReplace)
                    {
                        if (PeVersion == null)
                        {
                            if (replacement == null)
                            {
                                PeVersion = new PropertyState<PeVersionDataType>(this);
                            }
                            else
                            {
                                PeVersion = (PropertyState<PeVersionDataType>)replacement;
                            }
                        }
                    }

                    instance = PeVersion;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<PeClassEnumeration> m_peClass;
        private PropertyState<PeSubclassEnumeration> m_peSubclass;
        private PropertyState<PeVersionDataType> m_peVersion;
        #endregion
    }
    #endif
    #endregion

    #region SwitchOffWOLMethodState Class
    #if (!OPCUA_EXCLUDE_SwitchOffWOLMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SwitchOffWOLMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SwitchOffWOLMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SwitchOffWOLMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIABAAAAAEAFgAAAFN3aXRjaE9mZldPTE1ldGhvZFR5cGUBAQAA" +
           "AQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SwitchOffWOLMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            byte modeID = (byte)_outputArguments[0];
            double currentTimeToDestination = (double)_outputArguments[1];
            double regularTimeToOperate = (double)_outputArguments[2];
            double timeMinLengthOfStay = (double)_outputArguments[3];
            byte returnCode = (byte)_outputArguments[4];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref modeID,
                    ref currentTimeToDestination,
                    ref regularTimeToOperate,
                    ref timeMinLengthOfStay,
                    ref returnCode);
            }

            _outputArguments[0] = modeID;
            _outputArguments[1] = currentTimeToDestination;
            _outputArguments[2] = regularTimeToOperate;
            _outputArguments[3] = timeMinLengthOfStay;
            _outputArguments[4] = returnCode;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SwitchOffWOLMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref byte modeID,
        ref double currentTimeToDestination,
        ref double regularTimeToOperate,
        ref double timeMinLengthOfStay,
        ref byte returnCode);
    #endif
    #endregion

    #region EndPauseMethodState Class
    #if (!OPCUA_EXCLUDE_EndPauseMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EndPauseMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public EndPauseMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new EndPauseMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIABAAAAAEAEgAAAEVuZFBhdXNlTWV0aG9kVHlwZQEBAAABAQAA" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public EndPauseMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            double currentTimeToOperate = (double)_outputArguments[0];
            byte returnCode = (byte)_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref currentTimeToOperate,
                    ref returnCode);
            }

            _outputArguments[0] = currentTimeToOperate;
            _outputArguments[1] = returnCode;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult EndPauseMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref double currentTimeToOperate,
        ref byte returnCode);
    #endif
    #endregion

    #region StartPauseMethodState Class
    #if (!OPCUA_EXCLUDE_StartPauseMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartPauseMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public StartPauseMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new StartPauseMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIABAAAAAEAFAAAAFN0YXJ0UGF1c2VNZXRob2RUeXBlAQEAAAEB" +
           "AAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public StartPauseMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            double pauseTime = (double)_inputArguments[0];

            byte modeID = (byte)_outputArguments[0];
            double currentTimeToDestination = (double)_outputArguments[1];
            double regularTimeToOperate = (double)_outputArguments[2];
            double timeMinLengthToStay = (double)_outputArguments[3];
            byte returnCode = (byte)_outputArguments[4];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    pauseTime,
                    ref modeID,
                    ref currentTimeToDestination,
                    ref regularTimeToOperate,
                    ref timeMinLengthToStay,
                    ref returnCode);
            }

            _outputArguments[0] = modeID;
            _outputArguments[1] = currentTimeToDestination;
            _outputArguments[2] = regularTimeToOperate;
            _outputArguments[3] = timeMinLengthToStay;
            _outputArguments[4] = returnCode;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult StartPauseMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        double pauseTime,
        ref byte modeID,
        ref double currentTimeToDestination,
        ref double regularTimeToOperate,
        ref double timeMinLengthToStay,
        ref byte returnCode);
    #endif
    #endregion

    #region SwitchToEnergySavingModeMethodState Class
    #if (!OPCUA_EXCLUDE_SwitchToEnergySavingModeMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SwitchToEnergySavingModeMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SwitchToEnergySavingModeMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SwitchToEnergySavingModeMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACEAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvUE5FTS8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIABAAAAAEAIgAAAFN3aXRjaFRvRW5lcmd5U2F2aW5nTW9kZU1l" +
           "dGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SwitchToEnergySavingModeMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            byte modeID = (byte)_inputArguments[0];

            byte effectiveModeID = (byte)_outputArguments[0];
            double currentTimeToDestination = (double)_outputArguments[1];
            double regularTimeToOperate = (double)_outputArguments[2];
            double timeMinLengthOfStay = (double)_outputArguments[3];
            byte returnCode = (byte)_outputArguments[4];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    modeID,
                    ref effectiveModeID,
                    ref currentTimeToDestination,
                    ref regularTimeToOperate,
                    ref timeMinLengthOfStay,
                    ref returnCode);
            }

            _outputArguments[0] = effectiveModeID;
            _outputArguments[1] = currentTimeToDestination;
            _outputArguments[2] = regularTimeToOperate;
            _outputArguments[3] = timeMinLengthOfStay;
            _outputArguments[4] = returnCode;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SwitchToEnergySavingModeMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        byte modeID,
        ref byte effectiveModeID,
        ref double currentTimeToDestination,
        ref double regularTimeToOperate,
        ref double timeMinLengthOfStay,
        ref byte returnCode);
    #endif
    #endregion
}